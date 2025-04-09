using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iOptron_Mount_Control
{
    public partial class DomeController : Form
    {

        //*** NexDome Responses
        public const string RotatorStatusReply = ":SER,";
        public const string ShutterStatusReply = ":SES,";
        public const string BatteryVoltageNotification = ":BV";

        //*** NexDome Command Codes
        public const string CommandPrefix = "@";
        public const string RequestRotatorStatus = "@SRR";
        public const string RequestShutterStatus = "@SRS";
        public const string CmdHardStopShutter = "SWS";
        public const string CmdHardStopRotator = "SWR";
        public const string CmdOpenShutter = "OPS";
        public const string CmdCloseShutter = "CLS";
        public const string CmdSaveShutterSettings = "@ZWS";
        public const string CmdSaveRotatorSettings = "@ZWR";
        public const string CmdSetHomeSensorAzimuthTemplate = "@HWR,{0:D}";
        public const string CmdGetRotatorVersion = "@FRR";
        public const string CmdGetShutterVersion = "@FRS";
        public const string CmdSetMotorSpeedTemplate = "@VW{0},{1:0000}";
        public const string CmdSetRampTimeTemplate = "@AW{0},{1:0000}";
        public const string CmdSetLowBatteryVoltsThreshold = "@BWS,{0:0000}";
        /// <summary>
        ///     Format string used with <see cref="string.Format(string,object)" /> for building a "GoTo Azimuth" command.
        ///     Format Gxxx, 3 digits packed with leading zeroes as necessary.
        ///     <seealso cref="string.Format(string,object)" />
        ///     Response is a series of Pxxx position update packets, followed by a GINF status packet when
        ///     movement has ceased.
        /// </summary>
        public const string CmdGotoAzimuthTemplate = "GAR,{0:000}";
        /// <summary>
        ///     Format string used with <see cref="string.Format(string,object)" /> for building a "GoTo Step-position" command.
        ///     Format GSR, 6 digits packed with leading zeroes as necessary.
        ///     <seealso cref="string.Format(string,object)" />
        /// </summary>
        public const string CmdGotoStepPositionTemplate = "GSR,{0:000000}";
        /// <summary>
        ///     Command to move the DomeComPortComboBox to the home position.
        ///     Response is a series of Pxxx position update packets, followed by a SER status packet.
        /// </summary>
        public const string CmdGotoHome = "GHR";
        /// <summary>
        ///     Format string used with <see cref="string.Format(string,object)" /> for building a "Sync Azimuth" command.
        ///     Format Gxxx, 3 digits packed with leading zeroes as necessary.
        ///     <seealso cref="string.Format(string,object)" />
        /// </summary>
        public const string CmdSyncAzimuthTemplate = "PWR,{0:000}";


        public DomeController()
        {
            InitializeComponent();
            GetListOfComPorts(); // get list of avalable COM ports
            DomeConnectbutton.Enabled = false;
        }

        // ***** Get a list of COM ports *****
        public void GetListOfComPorts()
        {
            DomeComPortComboBox.Items.Clear(); // Clear any existing entries
            DomeComPortComboBox.Items.AddRange(SerialPort.GetPortNames()); // Get Available ComPorts using System.IO because it's static
            if (DomeComPortComboBox.Items.Count == 0)
            {
                return;
            }
            DomeConnectbutton.Enabled = true;
        }

        //***** Select COM Port *****
        private void DomeComboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomeSerialPort.PortName = DomeComPortComboBox.Text;
            DomeConnectbutton.Enabled = true;
            this.ActiveControl = null;
        }

        //***** Connect to DomeComPortComboBox *****
        private void DomeConnectbutton_Click(object sender, EventArgs e)
        {
            if (DomeSerialPort.IsOpen == false)
            {
                DomeSerialPort.Open();
                DomeSerialPort.DiscardOutBuffer();
                DomeSerialPort.DiscardInBuffer();
                DomeComPortComboBox.Enabled = false;
            }
            else
            {       
                DomeSerialPort.Close();
                DomeSerialPort.DiscardInBuffer();
                DomeSerialPort.DiscardOutBuffer();
                DomeComPortComboBox.Enabled = true;
                return;
            }

        }


    }
}
