using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOptron_Mount_Control
{
    public partial class FormUserInput2 : Form
    {
        public string _DialogLabel1;
        public string _DialogLabel2;
        public string _TextEntered1;
        public string _TextEntered2;
        public bool _FormStatus;

        public FormUserInput2()
        {
            InitializeComponent();
        }

        private void UserInput2_Load(object sender, EventArgs e)
        {
            DialogLabel1.Text = _DialogLabel1;
            DialogLabel2.Text = _DialogLabel2;
            _UserEntry1.Focus();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if ((_UserEntry1.Text == "") || (_UserEntry2.Text == ""))
            {
                _FormStatus = false;
                Close();
            }
            _TextEntered1 = _UserEntry1.Text;
            _TextEntered2 = _UserEntry2.Text;
            _FormStatus = true;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            _FormStatus = false;
            Close();
        }
    }
}
