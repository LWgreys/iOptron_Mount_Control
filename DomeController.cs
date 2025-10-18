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
        //***** The responce format is = "!the command sent 123#" -- Returns nothing if error else a number if successful
        // seletek group
        public const string seletekecho = "!seletek echo#";                                     // Confirm whether the board is alive -- Returns 0 if it is
        public const string seletekpowerOK = "!seletek powok#";                                 // Checks if power is OK -- Returns 0 if OK else null not OK
        public const string seletekreboot = "!seletek reboot#";                                 // Reboot the board -- Returns 0
        public const string seletekgetsernum = "!seletek getsernum#";                           // Get serial number of board -- Returns the boards serial number
        // dome-shutter group
        public const string domegotoaz = "!dome gotoaz {0}#";                                   // Goto azimuth <position> -- Returns 0
        public const string domegetaz = "!dome getaz#";                                         // Get current azimuth -- Returns 0 to 360 degrees
        public const string domesetaz = "!dome setaz {0}#";                                     // Set the current azimuth to <degrees> -- Returns nothing
        public const string domeopenshutter = "!dome openshutter#";                             // Open the shutter -- Returns 0
        public const string domecloseshutter = "!dome closeshutter#";                           // Close the shutter -- Returns 0
        public const string domegohome = "!dome gohome#";                                       // Move dome to Home position -- Returns 0
        public const string domegopark = "!dome gopark#";                                       // Goto park postion -- Returns 0
        public const string domeathome = "!dome athome#";                                       // At home position? -- Returns 0 = No, 1 = Yes
        public const string domeatpark = "!dome atpark#";                                       // At park position? -- Returns 0 = No, 1 = Yes
        public const string domesetpark = "!dome setpark#";                                     // Set rotator park to current position -- Returns 0
        public const string domeshutterstatus = "!dome shutterstatus#";                         // Returns the shutter status -- 0 = Open, 1 = Closed 2 = Opening, 3 = Closing, 4 = Error
        public const string domestatus = "!dome status#";                                       // Get dome bitwise status -- Returns bit status
        public const uint bit0_DomeMoving = 0b1;                                                    // bit 0 = Dome is moving
        public const uint bit1_ShutterMoving = 0b10;                                                // bit 1 = Shutter is moving
        public const uint bit2_RotatorError = 0b100;                                                // bit 2 = Rotator error
        public const uint bit3_ShutterError = 0b1000;                                               // bit 3 = Shutter Error
        public const uint bit4_CommunicationError = 0b1_0000;                                       // bit 4 = Communication error between dome & shutter
        public const uint bit5_WeatherStatus = 0b10_0000;                                           // bit 5 = Status of weather switch -- 0 unsafe, 1 safe
        public const uint bit6_RG_Status = 0b100_0000;                                              // bit 6 = Status of the RG-x switch
        public const uint bit7_ShutterOpen = 0b1000_0000;                                           // bit 7 = Shutter is fully open
        public const uint bit8_ShutterClose = 0b1_0000_0000;                                        // bit 8 = Shutter is fully closed
        public const uint bit9_ShutterOpening = 0b10_0000_0000;                                     // bit 9 = Shutter is opening
        public const uint bit10_ShutterClosing = 0b100_0000_0000;                                   // bit 10 = Shutter is closing
        public const uint bit11_DomeAtHome = 0b1000_0000_0000;                                      // bit 11 = Rotator is at home
        public const uint bit12_DomeAtPark = 0b1_0000_0000_0000;                                    // bit 12 = Rotator is at park
        public const string domeclearerrs = "!dome clearerrs#";                                 // Clears the last detected error -- Returns 0
        public const string domeabort = "!dome abort#";                                         // Abort both dome move and shutter move
        public const string domeautocalrot = "!dome autocalrot#";                               // Dome rotater calibrate -- Returns 0
        public const string domeautocalshutter = "!dome autocalshutter#";                       // Dome shutter calibrate -- Returns 0
        public const string domesendtoshutter = "!dome sendtoshutter {0}#";                     // Send <command> to shutter board -- Returns 0
        public const string domegetshuttermaxspeed = "!dome getshuttermaxspeed#";               // Get shutter max speed -- Returns <speed>
        public const string domesetshuttermaxspeed = "!dome setshuttermaxspeed {0}#";           // Set shutter max <speed> -- Returns 0
        public const string domegetshutterminspeed = "!dome getshutterminspeed#";               // Get shutter min speed -- Returns <speed>
        public const string domesetshutterminspeed = "!dome setshutterminspeed {0}#";           // Set shutter min <speed> -- Returns 0
        public const string domegetshutteracceleration = "!dome getshutteracceleration#";       // Get shutter acceleration -- Returns <acceleration>
        public const string domesetshutteracceleration = "!dome setshutteracceleration {0}#";   // Set shutter <acceleration> -- Return 0
        public const string domegetshuttertimeoutopenclose = "!dome getshuttertimeoutopenclose#"; // Get shutter timeout opening closing -- Returns <timeout>
        public const string domesetshuttertimeoutopenclose = "!dome setshuttertimeoutopenclose {0}#"; // Set shutter <timeout> open close -- Return 0
        public const string domeshutterisup = "!dome shutterisup#";                             // Retuns 0 = no shutter, 1 = shutter is up
        public const string domegetshutterenable = "!dome getshutterenable#";                   // Returns 0 = shutter disabled, 1 = shutter enabled
        public const string domesetshutterenable = "!dome setshutterenable {0}#";               // Set shutter 0 = disable, 1 = enable -- Return 0
        public const string domegetweatherprotdisable = "!dome getweatherprotdisable#";         // Get weather protection disable -- Returns 0 = disable, 1 = enable
        public const string domesetweatherprotdisable = "!dome setweatherprotdisable {0}#";     // Set weather <protection> disable 0 = disable, 1 = enable -- Returns 0
        // domerot group
        public const string rotatorgoto = "!domerot goto {0}#";                                 // Goto azimuth <postion> -- Return 0
        public const string rotatorgetroterr = "!domerot getroterr#";                           // Get rotator <error> -- Returns error number
        public const string rotatorgetpos = "!domerot getpos#";                                 // Get current rotator <postion> -- Returns postion
        public const string rotatorsetpos = "!domerot setpos {0}#";                             // Set current rotator postion to number -- Returns ?
        public const string rotatorgetstepsperdegree = "!domerot getstepsperdegree#";           // Get number of motor steps for 1 degree -- Returns number of steps
        public const string rotatorsetstepsperdegree = "!domerot setstepsperdegree {0}#";       // Set number of <steps> for 1 degree -- Returns 0
        public const string rotatorathome = "!domerot athome#";                                 // Rotator at home position -- Return 0 = Not at home, 1 = at home
        public const string rotatorgethome = "!domerot gethome#";                               // Get current set home <position> -- Returns position in degrees
        public const string rotatorsethome = "!domerot sethome {0}#";                           // Set home to position in <degrees> -- Return 0
        public const string rotatoratpark = "!domerot atpark#";                                 // Dome at park position -- Returns 0 = Not at park, 1 = At park position
        public const string rotatorgetpark = "!domerot getpark#";                               // Get park postion -- Returns par postion in degrees
        public const string rotatorsetpark = "!domerot setpark {0}#";                           // Set park postion in <degrees> -- Returns 0
        public const string rotatorcalibrate = "!domerot calibrate {0}#";                       // Starts rotor calibration, Parameter is timeout in <seconds> -- Returns 0
        public const string rotatorgetcalibrationstatus = "!domerot getcalibrationstatus#";     // Get calibration status -- Returns numerical value of calibration status
        public const string rotatorabortcalibration = "!domerot abortcalibration#";             // Aborts rotator calibration -- Returns 0
        public const string rotatorabort = "!domerot abort#";                                   // Aborts any rotator movement -- Returns 0
        public const string rotatorstop = "!domerot stop#";                                     // Same as abort
        public const string rotatordisablemonitor = "!domerot disablemonitor {0}#";             // Monitoring safety precaution 0 = disable, 1 = enable -- Returns 0
        public const string rotatorgetmaxspeed = "!domerot getmaxspeed#";                       // Get maximum % speed -- Returns the % of the motor's speed
        public const string rotatorsetmaxspeed = "!domerot setmaxspeed {0}#";                   // Set maximum <%> speed -- Returns 0
        public const string rotatorgetminspeed = "!domerot getminspeed#";                       // Get minimum % speed -- Returns the % of the motor's speed
        public const string rotatorsetminspeed = "!domerot setminspeed {0}#";                   // Set minimum <%> speed -- Returns 0
        public const string rotatorgetmaxfullrotsecs = "!domerot getmaxfullrotsecs#";           // Get maximum seconds of 1 full rotation takes -- Returns seconds
        public const string rotatorsetmaxfullrotsecs = "!domerot setmaxfullrotsecs {0}#";       // Set in <seconds> time it takes for 1 full rotation -- Returns 0

        // Dome Controler Variables
        public int DomePositionCurrent;
        public int DomePositionLast;
        public int DomePositionNew;
        public string status_DomeCommand;

        // Other public Variables
        public uint status_DomeMoving;
        public uint status_ShutterMoving;
        public uint status_RotatorError;
        public uint status_ShutterError;
        public uint status_CommunicationError;
        public uint status_Weather;
        public uint status_RainSensor;
        public uint status_ShutterOpen;
        public uint status_ShutterClose;
        public uint status_ShutterOpening;
        public uint status_ShutterClosing;
        public uint status_DomeAtPark;
        public uint status_DomeAtHome;



        //***** DomeController main initialization
        public DomeController()
        {
            InitializeComponent();
            GetListOfComPorts(); // get list of avalable COM ports
            DomeConnectbutton.Enabled = false;
            timerDome.Stop();
        }

        //***** Get a list of COM ports
        public void GetListOfComPorts()
        {
            DomeComPortComboBox.Items.Clear(); // Clear any existing entries
            DomeComPortComboBox.Items.AddRange(SerialPort.GetPortNames()); // Get Available ComPorts using System.IO because it's static
            if (DomeComPortComboBox.Items.Count == 0)
            {
                return; // Return if no COM port exist
            }
            DomeConnectbutton.Enabled = true;
        }

        //***** Select COM Port
        private void DomeComPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomeSerialPort.PortName = DomeComPortComboBox.Text;
            DomeConnectbutton.Enabled = true;
            this.ActiveControl = null;
        }

        //***** Connect to DomeComPortComboBox
        private void DomeConnectbutton_Click(object sender, EventArgs e)
        {
            try // Check selected COM port in use
            {
                if (DomeSerialPort.IsOpen == false) // If not connected to COM port then connect
                {
                    DomeSerialPort.Open();
                    DomeSerialPort.DiscardOutBuffer();
                    DomeSerialPort.DiscardInBuffer();
                    DomeSerialPort.NewLine = "#";
                    DomeComPortComboBox.Enabled = false;
                }
                else
                {   // else disconnect COM port
                    DomeSerialPort.DiscardInBuffer(); 
                    DomeSerialPort.DiscardOutBuffer();
                    // DomeSerialPort.NewLine = "\n";
                    DomeSerialPort.Close();
                    DomeComPortComboBox.Enabled = true;
                    return;
                }
            }
            catch (System.UnauthorizedAccessException) // Return error COM port in use
            {
                ErrorForm _error_ = new ErrorForm();
                _error_.ErrorText = "This COM Port is in use.\nChoose the correct COM Port!";
                _error_.ShowDialog();
                return;
            }

            // Check dome powered up
            if (DomeCommand(seletekecho) == "")
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.ErrorText = "No dome controler detected.";
                errorForm.ShowDialog();
                return;
            }
            if (DomeCommand(seletekpowerOK) != "0")
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.ErrorText = "Incomplete power to dome controlers.";
                errorForm.ShowDialog();
                return;
            }
            
            // Check shutter is connected and enabled
            if (DomeCommand(domeshutterisup) == "0")
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.ErrorText = "No power to shutter controller.";
                errorForm.ShowDialog();
                return;
            }
            if (DomeCommand(domegetshutterenable) == "0")   // If shutter not enabled then enable shutter
                DomeCommand(string.Format(domesetshutterenable, "1"));
            if (DomeCommand(domeshutterstatus) == "4")      // If shutter status has an error then close the shutter
                DomeCommand(domecloseshutter);

            // Start Dome Timer
            timerDome.Enabled = true;
        }

        //***** Send commands to dome & recive responce
        public string DomeCommand(string outString)
        {
            string inbuffer;
            byte[] buffer = new byte[1024];
            int i, j;

            // send command to dome
            DomeSerialPort.Write(text: outString);
            // get dome responce
            i = 0;
            do
            {
                buffer[i] = (byte)DomeSerialPort.ReadByte();
            }
            while (buffer[i++] == 35); // 35 for ASCII decimal for #
            DomeSerialPort.DiscardInBuffer();
            DomeSerialPort.DiscardOutBuffer();
            inbuffer = UTF8Encoding.UTF8.GetString(buffer);
            i = inbuffer.LastIndexOf(":") + 1;
            j = i - inbuffer.LastIndexOf("#") - 1;
            if ((j - i) <= 0)
            {
                return null; // Return null string if no responce or error
            }
            return inbuffer.Substring(i, j); // Return the responce from the dome
        }


        //===== Dome Timer ===================================================================== Dome Timer ====================================
        private void timerDome_Tick(object sender, EventArgs e)
        {
            uint uStatus;
            string dome_status;
            bool tictoc = false;

            // Get dome azimuth
            dome_status = DomeCommand(domegetaz);
            DomeAzimith.Text = "Dome Azimith " + dome_status + "°";
            DomePositionCurrent = Convert.ToInt32(dome_status);

            // Get dome status
            uStatus = Convert.ToUInt32(DomeCommand(domestatus));

            status_DomeMoving = uStatus & bit0_DomeMoving;
            status_ShutterMoving = uStatus & bit1_ShutterMoving;
            status_RotatorError = uStatus & bit2_RotatorError;
            status_ShutterError = uStatus & bit3_ShutterError;
            status_CommunicationError = uStatus & bit4_CommunicationError;
            status_Weather = uStatus & bit5_WeatherStatus;
            status_RainSensor = uStatus & bit6_RG_Status;
            status_ShutterOpen = uStatus & bit7_ShutterOpen;
            status_ShutterClose = uStatus & bit8_ShutterClose;
            status_ShutterOpening = uStatus & bit9_ShutterOpening;
            status_ShutterClosing = uStatus & bit10_ShutterClosing;
            status_DomeAtPark = uStatus & bit11_DomeAtHome;
            status_DomeAtHome = uStatus & bit12_DomeAtPark;

            // Is dome moving
            if (status_DomeMoving != 0)
            {
                DomeAzimith.BackColor = Color.Yellow;
                DomeAzimith.ForeColor = Color.Black;
                ProgressBarUpdate();
            }
            else
            {
                DomeAzimith.BackColor = Color.Black;
                DomeAzimith.ForeColor = Color.Yellow;
                ProgressBarUpdate();
            }

            // Is shutter moving
            if (status_ShutterMoving != 0)
            {
                if (tictoc)
                {
                    ShutterOpenCloseButton.BackColor = Color.Yellow;
                    ShutterOpenCloseButton.ForeColor = Color.Black;
                } else
                {
                    ShutterOpenCloseButton.BackColor = Color.Black;
                    ShutterOpenCloseButton.ForeColor = Color.Yellow;
                }
            }
            else
            {
                ShutterOpenCloseButton.BackColor = Color.DarkRed;
                ShutterOpenCloseButton.ForeColor = Color.Yellow;
            }

            // Is there a rotator error
            if (status_RotatorError != 0)
            {
                DomeAzimith.Text = "Dome ERROR";
                if (tictoc)
                    DomeAzimith.BackColor = Color.Red;
                else
                    DomeAzimith.BackColor = Color.Black;
            }
            else
            {
                DomeAzimith.BackColor = Color.Black;
            }
                
            // Is there a shutter error
            if (status_ShutterError != 0)
            {
                ShutterOpenCloseButton.Text = "Shutter ERROR";
                if (tictoc)
                    ShutterOpenCloseButton.BackColor = Color.Red;
                else
                    ShutterOpenCloseButton.BackColor = Color.DarkRed;
            }
                
            // Is there a communication error between dome and shutter
            if (status_CommunicationError != 0)
            {
                if (tictoc)
                    groupBox1.BackColor = Color.Red;
                else
                    groupBox1.BackColor = Color.Black;
            }
                
            // Weather status
            if (status_Weather != 0)
            {

            }
                
            // RG Rain Sensor status
            if (status_RainSensor != 0)
            {
                if (tictoc)
                {
                    buttonRainSensor.BackColor = Color.Red;
                    buttonRainSensor.ForeColor = Color.White;
                }
                else
                {
                    buttonRainSensor.BackColor = Color.Yellow;
                    buttonRainSensor.ForeColor = Color.Black;
                }
                // *** Close shutter
                DomeCommand(domecloseshutter);
            }
                
            // Is shutter fully open
            if (status_ShutterOpen != 0)
            {
                ShutterOpenCloseButton.BackColor = Color.Red;
                ShutterOpenCloseButton.ForeColor = Color.Yellow;
                ShutterOpenCloseButton.Text = "Close Shutter";
            }
                
            // Is shutter fully closed
            if (status_ShutterClose != 0)
            {
                ShutterOpenCloseButton.BackColor = Color.Green;
                ShutterOpenCloseButton.ForeColor = Color.Yellow;
                ShutterOpenCloseButton.Text = "Open Shutter";
            }
                
            // Is shutter opening
            if (status_ShutterOpening != 0)
            {
                ShutterOpenCloseButton.Text = "Opening";
            }
                
            // Is shutter closing
            if (status_ShutterClosing != 0)
            {
                ShutterOpenCloseButton.Text = "Closing";
            }
                
            // Is dome at home position
            if (status_DomeAtHome != 0)
            {
                buttonHomeDome.BackColor = Color.Green;
            } 
            else
            {
                buttonHomeDome.BackColor = Color.DarkRed;
            }
                
            // Is dome at park position
            if (status_DomeAtPark != 0)
            {
                buttonParkDome.BackColor = Color.Green;
            }
            else
            {
                buttonParkDome.BackColor = Color.DarkRed;
            }


            // Flip flop ticker
            tictoc = (tictoc ? false : true);

        }
        //===== End Of Dome Timer ============================================================ End Of Dome Timer =================================


        //***** Exit dome controler button
        private void DomeControllerExitButton(object sender, EventArgs e)
        {
            if (DomeSerialPort.IsOpen == true)
            {
                // Stop Dome Timer
                timerDome.Enabled=false;
                // Close the shutter if open & park the dome
                DomeCommand(domecloseshutter);
                DomeCommand(domegopark);
                // -------------------------------------------------May need some status check here

                // Flush COM port buffers and Close port
                DomeSerialPort.DiscardInBuffer();
                DomeSerialPort.DiscardOutBuffer();
                DomeSerialPort.Close();
            }
            // Close this form & exit
            Close();
        }

        //***** ProgressBar movement indicator
        private void ProgressBarUpdate()
        {
            if (DomePositionCurrent == DomePositionNew)
            {
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Maximum = 360;
                return;
            }
            if (DomePositionLast < DomePositionNew)
            {
                progressBar1.Minimum = DomePositionLast;
                progressBar1.Maximum = DomePositionNew;
                progressBar1.Value = DomePositionCurrent;
                return;
            }
            if (DomePositionLast > DomePositionNew)
            {
                progressBar1.Minimum = DomePositionNew;
                progressBar1.Maximum = DomePositionLast;
                progressBar1.Value = DomePositionCurrent;
                return;
            }
            progressBar1.Value = progressBar1.Minimum;
        }


        private void ShutterOpenCloseButton_Click(object sender, EventArgs e)
        {
            if (status_ShutterMoving == 0)
            {
                if ((status_ShutterOpen & status_ShutterClose) != 0)
                {
                    DomeCommand(domecloseshutter);
                }
                else
                {
                    if (status_ShutterClose == bit8_ShutterClose)
                        DomeCommand(domeopenshutter);
                    else if (status_ShutterOpen == bit7_ShutterOpen)
                        DomeCommand(domecloseshutter);
                }
            }
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
