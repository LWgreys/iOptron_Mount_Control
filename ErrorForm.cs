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
    public partial class ErrorForm : Form
    {
        public string ErrorText;

        public ErrorForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            labelERROR.Text = ErrorText;
        }
    }
}
