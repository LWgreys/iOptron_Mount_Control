using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;


namespace iOptron_Mount_Control
{
    public partial class Slew2Object : Form
    {
        public bool _FormStatus;
        public string _RA_of_Object, _DEC_of_Object;
        string inData;
        string[] COO_Split;
        double[] t = { 0, 0, 0, 0, 0, 0, 0, 0 };
        int n;

        public Slew2Object()
        {
            InitializeComponent();
            textboxObject.Text = RA_Coordinate.Text = DEC_Coordinate.Text = "";
            textboxObject.Focus();
        }

        private async void buttonSearchSIMBAD_Click(object sender, EventArgs e)
        {
            if (buttonSearchSIMBAD.Text == $"SLEW to {textboxObject.Text}")
            {
                _FormStatus = true;
                Close();
            }

            // check if object entered
            if (textboxObject.Text == "")
            {
                _FormStatus = false;
                Close();
            }

            // search SIMBA for object
            HttpClient client = new HttpClient();
            var uri = $"https://simbad.cds.unistra.fr/simbad/sim-script?script=format%20object%20%22%7E%7E%20%25COO(2%3BC%3BJ2000%3b2000)%22%0A{textboxObject.Text}";
            // var uri = $"https://simbad.cds.unistra.fr/simbad/sim-script?script=format%20object%20%22%7E%7E%20%25COO(2%3BC%3BJ2025%3B2025)%22%0A{textboxObject.Text}";
            HttpResponseMessage response = await client.GetAsync(uri);
            // check if http client successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                inData = responseContent;
            }
            else
            {
                ErrorForm _error_ = new ErrorForm();
                _error_.ErrorText = "ERROR: Unalble to connect to internet.";
                _error_.ShowDialog();
                Close();
            }
            client.Dispose();

            if (inData.LastIndexOf(":error:::::", inData.Length) > 1)
            {
                ErrorForm _error_ = new ErrorForm();
                _error_.ErrorText = "ERROR: Invalid object.\n\rCheck Object entered.";
                _error_.ShowDialog();
            }

            if (inData.LastIndexOf(":data:::::", inData.Length) > 1)
            {
                // clear t array
                for (int i = 0; i < t.Length; i++)
                    t[i] = 0;

                int j = inData.LastIndexOf("~~", inData.Length) + 3;
                inData = inData.Substring(j);

                if (inData != "")
                {
                    COO_Split = inData.Split(' ');
                    n = 0;
                    foreach (string num in COO_Split)
                    {
                        t[n++] = Convert.ToDouble(num);
                    }
                }
                RA_Coordinate.Text = string.Format("{0:##} {1:##} {2:#0.0###}", t[0], t[1], t[2]);
                DEC_Coordinate.Text = string.Format(string.Format("{0:+##0;-##0;0} {1:#0} {2:#0.0####}", t[3], t[4], t[5]));
                _RA_of_Object = $"{t[0]} {t[1]} {t[2]}";
                _DEC_of_Object = $"{t[3]} {t[4]} {t[5]}";

                buttonSearchSIMBAD.Text = $"SLEW to {textboxObject.Text}";
                MainControlForm.slewedObject = textboxObject.Text.ToUpper();
            }
        }

        
        private void buttonCancelSlew_Click(object sender, EventArgs e)
        {
            _FormStatus = false;
            Close();
        }
        
    }
}
