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
    public partial class formUserInput : Form
    {
        public string _DialogText;
        public string _TextEntered;
        public bool _FormStatus;

        public formUserInput()
        {
            InitializeComponent();
        }

        private void formUserInput_Load(object sender, EventArgs e)
        {
            _EntryDialog.Text = _DialogText;
            _UserEntry.Focus();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            _FormStatus = false;
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (_UserEntry.Text == "")
            {
                _FormStatus = false;
                Close();
            }
            _TextEntered = _UserEntry.Text;
            _FormStatus = true;
            Close();
        }
    }
}
