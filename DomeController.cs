using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iOptron_Mount_Control
{
    public partial class DomeController : Form
    {
        //***** Beaver Control Commands *****
        //***** The responce format is = !the command sent 123#
        public const string echo = "!seletek echo#";                                    // Confirm whether the board is alive -- Returns 0 if it is
        public const string powerOK = "!seletek powok#";                                // Checks if power is OK -- Returns 0 if OK else null not OK
        public const string reboot = "!seletek reboot#";                                // Reboot the board -- Returns 0
        public const string getsernum = "!seletek getsernum#";                          // Get serial number of board -- Returns the boards serial number
        public const string gotoAZ = "!dome gotoaz {0}#";                               // Goto azimuth <position> -- Returns 0
        public const string getAZ = "!dome getaz#";                                     // Get current azimuth -- Returns 0 to 360 degrees
        public const string setAZ = "!dome setaz {0}#";                                 // Set the current azimuth to <degrees> -- Returns nothing
        public const string shutterstatus = "!dome shutterstatus#";                     // Returns the shutter status -- 0 = Open, 1 = Closed 2 = Opening, 3 = Closing, 4 = Error
        public const string gohome = "!dome gohome#";                                   // Move dome to Home position -- Returns 0
        public const string gopark = "1dome gopark#";                                   // Goto park postion -- Returns 0
        public const string athome = "!dome athome#";                                   // At home position? -- Returns 0 = No, 1 = Yes
        public const string atpark = "!dome atpark#";                                   // At park position? -- Returns 0 = No, 1 = Yes
        public const string status = "!dome status#";                                   // Get dome itwise status -- Returns bit status
                                                                                            // bit 0 = Whether dome is moving
                                                                                            // bit 1 = Whether the shutter is moving
                                                                                            // bit 2 = Whether the rotator calibration has failed
                                                                                            // bit 3 = Whether there is an error in the shutter
                                                                                            // bit 4 = Whethe there is communication error between dome & shutter
                                                                                            // bit 5 = Status of weather switch -- 0 unsafe, 1 safe
                                                                                            // bit 6 = Status of the RG-x switch
                                                                                            // bit 7 = Whether the shutter is fully closed
                                                                                            // bit 8 = Whether the shutter is fully open
                                                                                            // bit 9 = Wheterr the shutter is opening
                                                                                            // bit 10 = Whether the shutter is closing
                                                                                            // bit 11 = Whether the rotator is at home
                                                                                            // bit 12 = Whether the rotator is at park
        public const string clearerrs = "!dome clearerrs#";                             // Clears the last detected error -- Returns 0
        public const string abort = "!dome abort#";                                     // Abort both dome move and shutter move
        public const string autocalrot = "!dome autocalrot#";                           // Dome rotater calibrate -- Returns 0
        public const string autocalshutter = "!dome autocalshutter#";                   // Dome shutter calibrate -- Returns 0
        public const string sendtoshutter = "!dome sendtoshutter {0}#";                 // Send <command> to shutter board -- Returns 0
        public const string setpark = "!dome setpark#";                                 // Set rotator park to current position -- Returns 0
        public const string getshuttermaxspeed = "!dome getshuttermaxspeed#";           // Get shutter max speed -- Returns <speed>
        public const string setshuttermaxspeed = "!dome setshuttermaxspeed {0}#";       // Set shutter max <speed> -- Returns 0
        public const string getshutterminspeed = "!dome getshutterminspeed#";           // Get shutter min speed -- Returns <speed>
        public const string setshutterminspeed = "!dome setshutterminspeed {0}#";       // Set shutter min <speed> -- Returns 0
        public const string getshutteracceleration = "!dome getshutteracceleration#";   // Get shutter acceleration -- Returns <acceleration>
        public const string setshutteracceleration = "!dome setshutteracceleration {0}#"; // Set shutter <acceleration> -- Return 0
        public const string getshuttertimeoutopenclose = "!dome getshuttertimeoutopenclose#"; // Get shutter timeout opening closing -- Returns <timeout>
        public const string setshuttertimeoutopenclose = "!dome setshuttertimeoutopenclose {0}#"; // Set shutter <timeout> open close -- Return 0
        public const string shutterisup = "!dome shutterisup#";                         // Retuns 0 = no shutter, 1 = shutter is up
        public const string getshutterenable = "!dome getshutterenable#";               // Returns 0 = shutter disabled, 1 = shutter enabled
        public const string setshutterenable = "!dome setshutterenable {0}#";           // Set shutter 0 = disable, 1 = enable -- Return 0





        public DomeController()
        {
            InitializeComponent();
            GetListOfComPorts(); // get list of avalable COM ports
            DomeConnectbutton.Enabled = false;
        }

        //***** Get a list of COM ports *****
        public void GetListOfComPorts()
        {
            DomeComPortComboBox.Items.Clear(); // Clear any existing entries
            DomeComPortComboBox.Items.AddRange(SerialPort.GetPortNames()); // Get Available ComPorts using System.IO because it's static
            if (DomeComPortComboBox.Items.Count == 0)
            {
                return; //*** Return if no COM port exist
            }
            DomeConnectbutton.Enabled = true;
        }

        //***** Select COM Port *****
        private void DomeComPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomeSerialPort.PortName = DomeComPortComboBox.Text;
            DomeConnectbutton.Enabled = true;
            this.ActiveControl = null;
        }

        //***** Connect to DomeComPortComboBox *****
        private void DomeConnectbutton_Click(object sender, EventArgs e)
        {
            try //*** Check selected COM port in use
            {
                if (DomeSerialPort.IsOpen == false) //*** If not connected to COM port then connect
                {
                    DomeSerialPort.Open();
                    DomeSerialPort.DiscardOutBuffer();
                    DomeSerialPort.DiscardInBuffer();
                    DomeComPortComboBox.Enabled = false;
                }
                else
                {   //*** else disconnect COM port
                    DomeSerialPort.DiscardInBuffer(); 
                    DomeSerialPort.DiscardOutBuffer();
                    DomeSerialPort.Close();
                    DomeComPortComboBox.Enabled = true;
                    return;
                }
            }
            catch (System.UnauthorizedAccessException) //*** Return error COM port in use
            {
                ErrorForm _error_ = new ErrorForm();
                _error_.ErrorText = "This COM Port is in use.\nChoose the correct COM Port!";
                _error_.ShowDialog();
                return;
            }

            //*** Get dome info and status

        }

        private void DomeControllerExitButton(object sender, EventArgs e)
        {
            if (DomeSerialPort.IsOpen == true)
            {
                // *** Close the shutter if Open ***

                // *** Flush COM port buffers and Close port ***
                DomeSerialPort.DiscardInBuffer();
                DomeSerialPort.DiscardOutBuffer();
                DomeSerialPort.Close();
            }
            Close();
        }

        private void ShutterOpenCloseButton_Click(object sender, EventArgs e)
        {

        }

        private void incDegreesCCWbutton_Click(object sender, EventArgs e)
        {

        }

        private void incDegreesCWbutton_Click(object sender, EventArgs e)
        {

        }

        private void SyncDome_button_Click(object sender, EventArgs e)
        {

        }

        private void GotoDomeAzimith_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buttonParkDome_Click(object sender, EventArgs e)
        {

        }

        private void buttonHomeDome_Click(object sender, EventArgs e)
        {

        }
    }
}
