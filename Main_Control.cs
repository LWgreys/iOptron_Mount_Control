/*
 * This program and code is OPEN SOURCE and you can modifi it as long as you use a branch and keep it updated.
 * The master branch is my coding but will accept updates to the master on approval.
*/

// Ignore Spelling: CEM Optron HC Loc UTC Localtime mov Unpark Bfirmware Cfirmware Afirmware Sstatus Aposition Cposition Ctime Coffset Aguiding Cguiding Cdata Crecording Cplayback Cenabled ret Postion pdd Costum Meridain

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;
using System.Security.Policy;
using System.Threading;
using System.IO;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using iOptron_Mount_Control;



namespace iOptron_Mount_Control
{

    public partial class MainControlForm : Form
    {
        //*** CEM Mount get command strings
        public const string get_CEM_Info = ":MountInfo#"; // returns "nnnn" = Mount
        public const string get_MB_HC_Firmware = ":FW1#"; // returns "YYMMDDYYMMDD#" first date mainboard, second date hand controller
        public const string get_RA_DEC_Firmware = ":FW2#"; // returns "YYMMDDYYMMDD#" first data RA board, second date DEC board
        public const string get_Loc_Stat = ":GLS#"; // returns "sTTTTTTTTTTTTTTTTnnnnnn#" s=sign -or+ first 8 Ts=Longitude in .01 arcsecound,
                                                    // second 8 Ts=Latitude in .01 arc-seconds,
                                                    // first n=0 GPS malfunction, n=1 GPS not received valid data, n=2 GPS valid data received
                                                    // second n=0 Stopped at Non-Zero Position, n=1 Tracking no PEC, n=2 Slewing, n=3 Auto Guiding, n=4 Meridian Flipping, n=5 Tracking with PEC, n=6 Parked, n=7 Stopped at Zero position
                                                    // third n=0 Sidereal Rate, n=1 Lunar Rate, n=2 Solar Rate, n=3 King Rate, n=4 Custom Rate
                                                    // forth n= Moving Speed by Arrow, 1= 1x, 2= 2x, 3= 8x, 4= 16x, 5= 64x, 6= 128x, 7= 256x, 8= 512x, 9= MAX
                                                    // fifth n= The Source of Time, 1= From RS-232 port or Ethernet port, 2= From Hand Controller, 3= From GPS
                                                    // sixth n= Hemisphere, 0= Southern, 1= Northern
        public const string get_UTC_Time = ":GUT#"; // returns "sMMMnXXXXXXXXXXXXX#" sMMM= UTC Offset for local time,
                                                    // n= Day Light Savings 0=OFF 1=ON,
                                                    // 13 digits XXXXXXXXXXXXX= Julian Date of current UTC Time
        public const string get_RA_DEC_Pos = ":GEP#"; // returns "sTTTTTTTTTTTTTTTTnn#" sTTTTTTTT= signed current DEC Position in .01 arc-seconds,
                                                      // second TTTTTTTT= current RA Position in .01 arc-seconds, 
                                                      // first n=0 for Pier East, n=1 for Pier West , n=2 for indeterminate Pier Position,
                                                      // second n=0 counterweight up, n=1 counterweight normal
        public const string get_Alt_Az_Pos = ":GAC#"; //returns "sTTTTTTTTTTTTTTTTT#" sTTTTTTTT= signed Current Altitude in .01 arc-seconds
                                                      // second 9 digits TTTTTTTTT= current Azimuth in .01 arc-seconds of 360 degrees
        public const string get_Tracking_Rate = ":GTR#"; // returns "nnnnn#" = Current Custom Tracking Rate 0.1000 to 1.9000
        public const string get_Park_Pos = ":GPC#"; // returns "TTTTTTTTTTTTTTTTT#" first 8 digits = Parking Altitude in .01 arc-seconds
                                                    // second 9 Digits = Parking Azimuth in .01 arc-seconds of 360 degrees
        public const string get_MAX_Slew_Rate = ":GSR#"; // returns Slew Rate "7#"=256x, "8#"=512x, "9#"=MAX
        public const string get_Alt_Limit = ":GAL#"; // returns "snn#" = Altitude Limit signed degrees
        public const string get_RA_DEC_Guide_Rate = ":AG#"; // returns "nnnn#" first 2 digits = RA Guiding Rate, second 2 digits = DEC Guiding Rate
        public const string get_Meridian_Treatment = ":GMT#"; // returns "nnn#" first digit 0=Stop at Meridian, 1=Flip at second 2 digits degrees 0 to 10
        public const string get_Guiding_Filter_RA = ":GGF#"; // returns RA AutoGuiding "0"=Off "1"=ON, Available only equatorial mount with encoders
        public const string getPeriodicErrorDataComplete = ":GPE#"; // returns "0"=incomplete PED, "1"=Completed PED, Available only equatorial mount without encoders
        public const string getPeriodicError_RecordStat = ":GPR#"; // returns "0"=PE recording Stopped, "1"=PE being Recorded, Available only equatorial mount without encoders
        //*** CEM Mount set command strings
        public string set_Tracking_Rate = ":RT"; // +"0#" = Sidereal, +"1#" = Lunar, +"2#" = Solar, +"3#" = King, +"4#" = Custom
        public string set_Moving_Rate = ":SR"; // +"1#" = 1x, +"2#" = 2x, +"3#" = 8x, +"4#" = 16x, +"5#" = 64x, +"6#" = 128x, +"7#" = 256x, +"8#" = 512x, +"9#" = MAX
        public string set_Guiding_Filter = ":SGF"; // +"0#" = OFF, +"1#" = ON // Available only equatorial mount with encoders
        //*** CEM Mount set command strings that are saved in mount after power cycle
        public string set_UTC_offset_Localtime = ":SG"; // +"sMMM#" s=sign -or+, MMM=minutes
        public const string set_DayLightSavings_OFF = ":SDS0#"; // returns "1", set daylight savings OFF
        public const string set_DayLightSavings_ON = ":SDS1#"; // returns "1", set daylight savings ON
        public string set_UTC_Time = ":SUT"; // +"XXXXXXXXXXXXX#" = Julian Date of current UTC Time in 1 milliseconds
        public string set_Longitude = ":SLO:"; // +"sTTTTTTTT#" s=sign -West or +East, TTTTTTTT=arc-seconds 0.01 resolution
        public string set_Latitude = ":SLA"; // +"sTTTTTTTT#" s=sign -South or +North, TTTTTTTT=arc-seconds 0.01 resolution
        public const string set_Hemisphere_South = ":SHE0#";// returns "1", Southern hemisphere
        public const string set_Hemisphere_North = ":SHE1#";// returns "1", Northern hemisphere
        public string set_MAX_Slew_Rate = ":MSR"; // +"7#"=256x, +"8#"=512x, +"9#"=MAX
        public string set_Altitude_Limit = ":SAL"; // +"snn#" s=sign -or+, nn=Degrees
        public string set_Guiding_Rate = ":RG"; // +"nnnn#" first 2 digits set RA rate [.01 to .90], second 2 digits set DEC Rate [.01 to .99]
        public string set_Meridian_Treatment = ":SMT"; // +"nnn#" first digit 0=Stop or 1=Flip at second 2 digits Degrees
        public const string reset_All_to_Defaults = ":RAS#"; // returns "1" Does NOT reset any date, time or time zone settings
        //*** CEM Mount Motion commands
        public string slew_to_set_RA_DEC = ":MS"; // +"1#" slew normal previous set RA DEC position, +"2#"= slew counter weight up, 
                                                    // return "1" if command accepted, "0" if object below limit or exceeds mechanical limits
        public const string slew_to_set_Alt_Az = ":MSS#"; // Slew to previous set Altitude Azimuth postion,
                                                            // return "1" if command accepted, "0" if object below limit or exceeds mechanical limits
        public const string slew_Stop = ":Q#"; // stops all slewing operations, tracking will not be effected, returns "1"
        public const string set_Tracking_OFF = ":ST0#"; // returns "1", turns tracking OFF
        public const string set_Tracking_ON = ":ST1#"; // returns "1", turns tracking ON
        public const string mov_Guiding_RA_Plus = ":ZS"; // +"XXXXX#"=milliseconds RA+ at current guiding rate
        public const string mov_Guiding_RA_Minus = ":ZQ"; // +"XXXXX#"=milliseconds RA- at current guiding rate
        public const string mov_Guiding_DEC_Plus = ":ZE"; // +"XXXXX#"=milliseconds DEC+ at current guiding rate
        public const string mov_Guiding_DEC_Minus = ":ZC"; // +"XXXXX#"=milliseconds DEC- at current guiding rate

        //*** The following commands are no longer used, supersede by above commands
        public const string mov_Guiding_RA_Plus_old = ":Mw"; // +"XXXXX#"=milliseconds RA+ at current guiding rate
        public const string mov_Guiding_RA_Minus_old = ":Me"; // +"XXXXX#"=milliseconds RA- at current guiding rate
        public const string mov_Guiding_DEC_Plus_old = ":Mn"; // +"XXXXX#"=milliseconds DEC- at current guiding rate
        public const string mov_Guiding_DEC_Minus_old = ":Ms"; // +"XXXXX#"=milliseconds DEC+ at current guiding rate
        public const string mov_Parking_Position = ":MP1#"; // move to previous set parking position, return "1"
        public const string mov_Unpark = ":MP0#"; // unpark mount, returns "1"
        public const string slew_Zero_Position = ":MH#"; // slew to zero position immediately, returns "1"
        public const string search_Zero_Position = ":MSH#"; // returns "1", available only for CEM120, CEM70, Gem45, CEM40
        public const string set_PE_Record_Stop = ":SPR0#"; // returns "1", stop Periodic Error Recording
        public const string set_PE_Record_Start = ":SPR1#"; // returns "1", start Periodic Error Recording
        public const string set_Playback_PR_OFF = ":SPP0#"; // returns "1", disable Periodic Error Correction playback
        public const string set_Playback_PR_ON = ":SPP1#"; // returns "1", enable Periodic Error Correction playback
        public const string set_Custom_Tracking_Rate = ":RR"; // +"nnnnn#"=0.1000 to 1.9000 no decimal, returns "1"
        public const string mov_Manual_DEC_Minus = ":mn#"; // start move manually DEC- direction until next stop command
        public const string mov_Manual_DEC_Plus = ":ms#"; // start move manually DEC+ direction until next stop command
        public const string mov_Manual_RA_Minus = ":me#"; // start move manually RA- direction until next stop command
        public const string mov_Manual_RA_Plus = ":mw#"; // start move manually RA+ direction until next stop command
        public const string mov_Manual_RA_Stop = ":qR#"; // stop moving manually RA only, returns "1"
        public const string mov_Manual_DEC_Stop = ":qD#"; // stop moving manually DEC only, returns "1"
        //*** CEM Mount Position commands
        public const string Calibrate_Mount = ":CM#"; // Calibrate Mount, returns "1"
        public const string Query_Num_Positions = ":QAP#"; // returns "0#"= cannot slew, "1#"= can slew, "2#"= ?CWup slew 
        public const string set_RA_Position = ":SRA"; // +"TTTTTTTTT#"= .01 arc-seconds to set defined RA, returns "1"
        public const string set_DEC_Position = ":Sd"; // +"sTTTTTTTT#"= signed -+.01 arc-seconds to set defined DEC, returns "1"
        public const string set_ALT_Position = ":Sa"; // +"sTTTTTTTT#"= signed -+.01 arc-seconds to set defined Altitude, returns "1"
        public const string set_AZ_Position = ":Sz"; // +"sTTTTTTTT#"= .01 arc-seconds to set defined Azimuth, returns "1"
        public const string set_Zero_Position = ":SZP#"; // set current position as ZERO Position, returns "1"
        public const string set_AZ_Park_Position = ":SPA"; // +"TTTTTTTTT#= .01 arc-seconds, returns "1"
        public const string set_Alt_Park_Position = ":SPH"; // +"TTTTTTTTT#= .01 arc-seconds, returns "1"

        //*** CEM Mount Models
        public string[,] MountModel = { {"0026", "0027", "0028", "0029", "0040", "0041", "0043", "0044", "0070", "0071", "0120", "0121", "0122"},
            {"CEM26", "CEM26-EC", "GEM28", "GEM28-EC", "CEM40(G)", "CEM40(G)-EC", "GEM45(G)", "GEM45(G)-EC", "CEM70(G)", "CEM70(G)-EC", "CEM120", "CEM120-EC", "CEM120-EC2"} };

        public static string cemMountModel;
        public static string cemMBfirmwareDate;
        public static string cemHCfirmwareDate;
        public static string cemRAfirmwareDate;
        public static string cemDECfirmwareDate;
        public static string cemLongitude;
        public static string cemLatitude;
        public static byte cemGPSstatus;
        public static byte cemInMotion;
        public static byte cemTrackingRate;
        public static byte cemMovingRate;
        public static byte cemTimeSource;
        public static byte cemHemisphere;
        public static string cemLatitudeEastWest;
        public static string cemMountTime;
        public static string cemRAposition;
        public static string cemDECposition;
        public static string cemAltitudePosition;
        public static string cemAzimuthPosition;
        public static string cemUTCtime;
        public static string cemUTCoffset;
        public static bool cemDaylightTime;
        public static double cemLocalTime;
        public static byte cemPierPosition;
        public static byte cemPointingState;
        public static string cemCustomTrackRate;
        public static string cemParkingAltitude;
        public static string cemParkingAzimuth;
        public static byte cemMAXSlewingRate;
        public static sbyte cemAltitudeLimit;
        public static string cemRAguidingRate;
        public static string cemDECguidingRate;
        public static bool cemMeridianFlipStatus;
        public static byte cemMeridianFlipDegrees;
        public static bool cemTrackingOnOff;
        public static bool cemMountParked;
        public static bool cemPECdataComplete; //.................. Periodic Error Recorded Data Complete Status
        public static bool cemPECrecording; //..................... Periodic Error Recording Status
        public static bool cemPECplaybackOnOff; //................. Periodic Error Playback Status
        public static bool cemPECenabled; // ...................... Periodic Error Enabled Status
        public static bool cemCustomTrackingRateChanged;
        public static bool cemParkingPositionChanged;
        public static bool cemMeridianTreatmentChanged;
        public static bool cemAltitudeLimitChanged;
        public static bool cemRA_DEC_GuidingRateChanged;
        public static bool cemMaxSlewRateChanged;
        public static double LST_longitude; // .....................Used for LocalSiderealTime()
        const string NO_PORTS_MESSAGE = "No COM ports found";
        static byte _OtherData_;
        const double miliSecondsInDay = 86400000.0;     // Number of milliseconds in a day
        const double JD_J2000 = 2451545.0;                 // Julian date time 2000-01-01 12:00.00 noon
        static readonly bool ON = true;
        static readonly bool OFF = false;
        static readonly object InOut = new object();


        //****************************************************************************************************************************
        //****************************************************************************************************************************

        // *** Main Control Form ***
        public MainControlForm()
        {
            InitializeComponent();

            // Disable Button
            ButtonCOMPortConnect.Enabled = OFF;
            GetListOfComPorts();
            _OtherData_ = 0;
            timer1.Stop();
        }


        // Get a list of COM ports
        public void GetListOfComPorts()
        {
            ComboBoxComPort.Items.Clear(); // Clear any existing entries
            foreach (string ComString in SerialPort.GetPortNames())
                ComboBoxComPort.Items.Add(ComString); // Get Available ComPorts
            if (ComboBoxComPort.Items.Count == 0)
            {
                ButtonCOMPortConnect.Text = NO_PORTS_MESSAGE;
                ButtonCOMPortConnect.Enabled = ON;
            }
        }


        // *** Exit Button ***
        private void ButtonEXIT_Click(object sender, EventArgs e)
        {
            if (MountComPort.IsOpen)
                MountComPort.Close();
            Application.Exit();
        }


        // *** Select COM Port ***
        private void ComboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set mount COM port
            MountComPort.PortName = ComboBoxComPort.Text;
            ButtonCOMPortConnect.Enabled = ON;
            this.ActiveControl = null;
        }


        // *** Connect to Mount and Check Model ***
        private void ButtonCOMPortConnect_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            int i, index;
            string firmwareDate;
            string inData;

            if (ButtonCOMPortConnect.Text == NO_PORTS_MESSAGE) // Exit program if no ports found
                return;

            if (MountComPort.IsOpen == false)
            {
                MountComPort.Open(); // Open mount COM port if not already open
                MountComPort.DiscardOutBuffer();
                MountComPort.DiscardInBuffer();
                buttonResetPEC.Enabled = OFF;
                buttonSlewToObject.Enabled = ON;
                groupBoxMountGPS_Time.Enabled = ON;
                groupBoxMountPad.Enabled = ON;
                groupBoxMountParking.Enabled = ON;
                groupBoxMountPointingPosition.Enabled = ON;
                groupBoxMountTracking.Enabled = ON;
                groupBoxMountZeroPosition.Enabled = ON;
                groupBoxSettings_Limits.Enabled = ON;
            }
            else
            {
                MountComPort.Close();
                ButtonCOMPortConnect.Text = "Connect";
                buttonSlewToObject.Enabled = OFF;
                groupBoxMountGPS_Time.Enabled = OFF;
                groupBoxMountPad.Enabled = OFF;
                groupBoxMountParking.Enabled = OFF;
                groupBoxMountPointingPosition.Enabled = OFF;
                groupBoxMountTracking.Enabled = OFF;
                groupBoxMountZeroPosition.Enabled = OFF;
                groupBoxSettings_Limits.Enabled = OFF;
                return;
            }

            // Get mount model number
            inData = MountCommand(get_CEM_Info, 4);
            index = MountModel.Length / 2;
            for (i = 0; i < index; i++)
            {
                if (MountModel[0, i] == inData)
                    break;
            }
            cemMountModel = MountModel[1, i];
            ButtonCOMPortConnect.Text = "Connected To " + MountModel[1, i];

            // Get firmware dates
            firmwareDate = MountCommand(get_MB_HC_Firmware, 13);
            cemMBfirmwareDate = firmwareDate.Substring(0, 6);
            cemHCfirmwareDate = firmwareDate.Substring(6, 6);
            firmwareDate = MountCommand(get_RA_DEC_Firmware, 13);
            cemRAfirmwareDate = firmwareDate.Substring(0, 6);
            cemDECfirmwareDate = firmwareDate.Substring(6, 6);
            GetPeriodicErrorStatus();

            // set other data attributes
            labelTimeSource.Text = "....";
            cemCustomTrackingRateChanged = true;
            cemParkingPositionChanged = true;
            cemMeridianTreatmentChanged = true;
            cemAltitudeLimitChanged = true;
            cemRA_DEC_GuidingRateChanged = true;
            cemMaxSlewRateChanged = true;

            timer1.Start();
        }


        // ***** send Mount Command & return Response
        public string MountCommand(string outString, int numberOfChar)
        {
            string inBuffer;
            byte[] buffer = new byte[numberOfChar];
            int i;

            // send mount command
            MountComPort.Write(text: outString);
            // get mount responce if any
            if (numberOfChar == 0)
                return null;
            for (i = 0; i != numberOfChar; i++)
                buffer[i] = (byte)MountComPort.ReadByte();
            inBuffer = UTF8Encoding.UTF8.GetString(buffer);
            return inBuffer;
        }


        // this part of code runs every 1 second once the program is connect to a mount 
        //********** TIMER 1 ***************************************************************************** TIMER 1 *******************
        public void GetMountData(Object myObject, EventArgs myEventArgs)
        {
            string inData;

            // Get GPS Longitude Latitude and other information
            lock (InOut)
                inData = MountCommand(get_Loc_Stat, 24);
            cemLongitude = inData.Substring(0, 9);
            cemLatitude = inData.Substring(9, 8);
            cemLatitudeEastWest = inData.Substring(0, 1);
            cemGPSstatus = Convert.ToByte(inData.Substring(17, 1));
            cemInMotion = Convert.ToByte(inData.Substring(18, 1));
            cemTrackingRate = Convert.ToByte(inData.Substring(19, 1));
            cemMovingRate = Convert.ToByte(inData.Substring(20, 1));
            cemTimeSource = Convert.ToByte(inData.Substring(21, 1));
            cemHemisphere = Convert.ToByte(inData.Substring(22, 1));
            LST_longitude = 0.0; // Convert.ToDouble(cemLongitude) / 360000.0;

            // *** GPS status
            switch (cemGPSstatus)
            {
                case 2:
                    LST_longitude = Convert.ToDouble(cemLongitude) / 360000.0;
                    if (cemLatitudeEastWest == "+")
                        cemLongitude = labelLongitude.Text = RetPostionString(Convert.ToDouble(cemLongitude), 0) + " E"; // convert string to double
                    else
                        cemLongitude = labelLongitude.Text = RetPostionString(Convert.ToDouble(cemLongitude), 0) + " W"; // convert string to double
                    if (cemHemisphere == 1)
                        cemLatitude = labelLatitude.Text = RetPostionString(Convert.ToDouble(cemLatitude), 3) + " N"; // convert string to double
                    else
                        cemLatitude = labelLatitude.Text = RetPostionString(Convert.ToDouble(cemLatitude), 3) + " S"; // convert string to double
                    break;
                case 1:
                    labelLongitude.Text = labelLatitude.Text = "No Data Yet";
                    break;
                case 0:
                    labelLongitude.Text = labelLatitude.Text = "Malfunction";
                    break;
            }

            // *** mount motion status
            switch (cemInMotion)
            {
                case 0: // stopped at none zero position
                    if ((cemPECenabled == ON) || (cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
                        lock (InOut)
                            StopPlaybackRecord();
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 1: // tracking with periodic error correction disabled
                    cemPECplaybackOnOff = OFF;
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.Green;
                    buttonTrackingOnOff.Text = "Tracking ON";
                    cemTrackingOnOff = ON;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 2: // slewing
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Green;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 3: // auto-guiding
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 4: // meridian flipping
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Green;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 5: // tracking with periodic error correction enabled
                    if (cemPECrecording == ON)
                    {
                        buttonPeriodicErrorCorrection.BackColor = Color.OrangeRed;
                        buttonPeriodicErrorCorrection.Text = "Recording PEC";
                    }
                    if (cemPECdataComplete == ON)
                    {
                        buttonPeriodicErrorCorrection.BackColor = Color.Green;
                        buttonPeriodicErrorCorrection.Text = "PEC Tracking ON";
                    }
                    cemPECenabled = ON;
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.Green;
                    buttonTrackingOnOff.Text = "Tracking ON";
                    cemTrackingOnOff = ON;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
                case 6: // parked
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Maroon;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Green;
                    buttonParkMount.Text = "Unpark Mount";
                    cemMountParked = ON;
                    break;
                case 7: //stopped at zero position
                    if ((cemPECenabled == ON) || (cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
                        lock (InOut)
                            StopPlaybackRecord();
                    buttonPeriodicErrorCorrection.BackColor = Color.Maroon;
                    buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
                    labelMountZeroPosition.BackColor = Color.Green;
                    buttonTrackingOnOff.BackColor = Color.DarkRed;
                    buttonTrackingOnOff.Text = "Tracking OFF";
                    cemTrackingOnOff = OFF;
                    labelMountSlewing.BackColor = Color.Maroon;
                    checkBoxMeridianFlipOnOff.BackColor = Color.Black;
                    buttonParkMount.BackColor = Color.Maroon;
                    buttonParkMount.Text = "Park Mount";
                    cemMountParked = OFF;
                    break;
            }

            // *** Tracking rate
            comboBoxTrackingRate.SelectedIndex = cemTrackingRate;
            if (cemTrackingRate == 4)
                labelCustomeTrackingRate.Enabled = ON;
            else
                labelCustomeTrackingRate.Enabled = OFF;

            // *** Moving rate
            comboBoxManualMovingRate.SelectedIndex = cemMovingRate - 1;
            
            // *** show were source of time coming from
            switch (cemTimeSource)
            {
                //case 1:
                //    labelTimeSource.Text = "Net";
                //    break;
                case 2:
                    labelTimeSource.Text = "HC";
                    break;
                case 3:
                    labelTimeSource.Text = "GPS";
                    break;
                default:
                    // set to computer UTC time if no HC or GPS
                    SetToComputerTime();
                    labelTimeSource.Text = "CPU";
                    break;
            }

            // *** Get Mount UTC time
            if ((cemTimeSource == 2) || (cemTimeSource == 3) || (labelTimeSource.Text == "CPU"))
            {
                byte DLST;
                double UTCtime, UTCoffset, MountTime, LocalTime, localJ2000;

                lock (InOut)
                    inData = MountCommand(get_UTC_Time, 19);
                // convert mount time to UTC time
                cemUTCoffset = labelUTC_Offset.Text = inData.Substring(0, 4);
                UTCoffset = Convert.ToDouble(cemUTCoffset);
                DLST = Convert.ToByte(inData.Substring(4, 1));
                cemMountTime = inData.Substring(5, 13);
                MountTime = Convert.ToDouble(cemMountTime);
                cemDaylightTime = checkBoxDayLightSavingsOnOff.Checked = (DLST == 1) ? ON : OFF;
                UTCtime = (MountTime / miliSecondsInDay) + JD_J2000;     // convert Mount Time to UTC time
                lock (InOut)
                    labelLST.Text = LocalSiderealTime(UTCtime, LST_longitude);
                UTCtime -= (int)UTCtime;                        // get the time part
                cemUTCtime = labelTimeUTC.Text = RetTimeString(UTCtime);
                // convert mount time to Local time
                LocalTime = MountTime / miliSecondsInDay;
                localJ2000 = JD_J2000 - (1.0 - ((1440.0 + ((DLST == 1) ? (UTCoffset - -60.0) : UTCoffset)) / 1440.0)); // 1440 = minutes in 24 hours
                LocalTime += localJ2000;
                LocalTime -= (int)LocalTime;
                labelTimeLocal.Text = RetTimeString(LocalTime);
            }

            // *** get RA and DEC position
            lock (InOut)
                inData = MountCommand(get_RA_DEC_Pos, 21);
            cemDECposition = inData.Substring(0, 9);
            cemRAposition = inData.Substring(9, 9);
            cemPierPosition = Convert.ToByte(inData.Substring(18, 1));
            cemPointingState = Convert.ToByte(inData.Substring(19, 1));
            cemDECposition = labelDEC.Text = RetPostionString(Convert.ToDouble(cemDECposition), 0);
            cemRAposition = labelRA.Text = RetPostionString((Convert.ToDouble(cemRAposition) / 360.0) * 24.0, 1);
            switch (cemPierPosition)
            {
                case 0:
                    labelPierEAST.BackColor = Color.Green;
                    labelPierWEST.BackColor = Color.Maroon;
                    break;
                case 1:
                    labelPierEAST.BackColor = Color.Maroon;
                    labelPierWEST.BackColor = Color.Green;
                    break;
                default:
                    labelPierEAST.BackColor = Color.Maroon;
                    labelPierWEST.BackColor = Color.Maroon;
                    break;
            }

            // *** get ALT and AZ position
            lock (InOut)
                inData = MountCommand(get_Alt_Az_Pos, 19);
            cemAltitudePosition = inData.Substring(0, 9);
            cemAzimuthPosition = inData.Substring(9, 9);
            cemAltitudePosition = labelAltitude.Text = RetPostionString(Convert.ToDouble(cemAltitudePosition), 0);
            cemAzimuthPosition = labelAzimuth.Text = RetPostionString(Convert.ToDouble(cemAzimuthPosition), 0);

            // *** periodic error correction
            if (cemPECenabled == ON)
            {
                lock (InOut)
                    GetPeriodicErrorStatus();
                if ((cemPECdataComplete == ON) && (cemPECrecording == OFF) && (cemPECplaybackOnOff == OFF))
                {
                    lock (InOut)
                        inData = MountCommand(set_Playback_PR_ON, 1);   // turn periodic error playback ON
                    cemPECplaybackOnOff = ON;
                }
            }
            if (cemPECdataComplete == ON)
                buttonResetPEC.Enabled = ON;
            else
                buttonResetPEC.Enabled = OFF;
            
            // *** get other data
            GetOtherData(_OtherData_);
        }
        //***************** END TIMER 1 ******************************************************************** END TIME 1 **************/


        // ***** siderealtime of location
        public static string LocalSiderealTime(double dUTC, double _longitude_)
        {
            // varibles for Local Sidereal Time
            double Tropical_year = 365.2421875; // = 365 days 5 hours 48 minutes 45 seconds
            double _SDx_ = 360.0 / Tropical_year; // SD multiplyer
            DateTime J2000 = new DateTime(2000, 1, 1, 12, 0, 0);
            double Days_dif, UT, LST;
            DateTime _UTC;
            
            dUTC -= JD_J2000;
            _UTC = ((((DateTime.FromOADate(dUTC)).AddYears(100)).AddHours(12)).AddMinutes(3)).AddSeconds(56);
            Days_dif = (_UTC - J2000).TotalDays;
            UT = _UTC.Hour + _UTC.Minute / 60.0 + _UTC.Second / 3600.0;
            LST = 100.4606184 + (_SDx_ * Days_dif) + _longitude_ + (15 * UT);
            LST %= 360;
            LST /= 15.0;
            var h = (int)LST;
            LST -= (int)LST;
            LST *= 60.0;
            var m = (int)LST;
            LST -= (int)LST;
            LST *= 60.0;
            var s = LST;
            return string.Format(" {0:00} : {1:00} : {2:00}", h, m, s);
        }


        // ***** get Periodic Error Status
        public void GetPeriodicErrorStatus()
        {
            string inData;

            inData = MountCommand(getPeriodicError_RecordStat, 1);
            if (inData == "1")
                cemPECrecording = ON;   // periodic erreo being recorded
            else
                cemPECrecording = OFF;  // periodic error recording STOPPED

            inData = MountCommand(getPeriodicErrorDataComplete, 1);
            if (inData == "1")
                cemPECdataComplete = ON;  // periodic error recording complete
            else
                cemPECdataComplete = OFF; // recording incomplete
        }


        // ***** stop periodic error playback & recording
        private void StopPlaybackRecord()
        {
            string inData;

            cemPECenabled = OFF;
            cemPECrecording = OFF;
            cemPECplaybackOnOff = OFF;
            inData = MountCommand(set_PE_Record_Stop, 1);               // periodic error recording OFF
            inData = MountCommand(set_Playback_PR_OFF, 1);             	// periodic error playback OFF
        }


        // ***** return formated time string
        public static string RetTimeString(double tdd)
        {
            int _hours, _minutes, _seconds;

            if (tdd > 0.5)
                tdd -= 0.5;
            else if (tdd < 0.5)
                tdd += 0.5;

            tdd *= 24.0;
            _hours = (int)tdd;
            tdd -= (int)tdd;
            tdd *= 60.0;
            _minutes = (int)tdd;
            tdd -= (int)tdd;
            tdd *= 60.0;
            _seconds = (int)tdd;
            return string.Format(" {0:00} : {1:00} : {2:00}", _hours, _minutes, _seconds);
        }


        // ***** returns formated position string
        public static string RetPostionString(double pdd, byte _rf)
        {
            int _degrees, _minutes, _seconds, _decimal;

            pdd = Math.Abs(pdd /= 360000.0);
            if (_rf == 3)
                pdd -= 90;
            _degrees = (int)pdd;
            pdd -= (int)pdd;
            pdd *= 60.0;
            _minutes = (int)pdd;
            pdd -= (int)pdd;
            pdd *= 60.0;
            _seconds = (int)pdd;
            pdd -= (int)pdd;
            pdd *= 100.0;
            _decimal = (int)pdd;
            switch (_rf)
            {
                case 0:
                case 3:
                    return string.Format("{0:0} : {1:00} : {2:00}.{3:00}", _degrees, _minutes, _seconds, _decimal);
                case 4:
                    return string.Format("{0:0}", _degrees);
                case 1:
                    return string.Format("{0:0}h {1:00}m {2:00}.{3:00}s", _degrees, _minutes, _seconds, _decimal);
                default:
                    return string.Format("{0:0} : {1:00} : {2:00}", _degrees, _minutes, _seconds);
            }
        }


        // do mount slew --- entry RA DEC arc-seconds or AZ ALT arc-seconds, 0 for RA DEC or 1 for ALT AZ --- returns 1=success 0=failed
        // DEC & ALT are signed values
        public byte DoMountSlew(string uRA_AZ, string sDEC_ALT, byte axisType)
        {
            string inData;

            if (axisType == 0)
            {
                inData = MountCommand(set_RA_Position + uRA_AZ + "#", 1);
                inData = MountCommand(set_DEC_Position + sDEC_ALT + "#", 1);
                inData = MountCommand(Query_Num_Positions, 2);
                if (inData == "0#")
                    return 0;
                inData = MountCommand(set_RA_Position + uRA_AZ + "#", 1);
                inData = MountCommand(set_DEC_Position + sDEC_ALT + "#", 1);
                inData = MountCommand(slew_to_set_RA_DEC + "1#", 1);
                if (inData == "1")
                    return 1;
                else
                    return 0;
            }
            if (axisType == 1)
            {
                inData = MountCommand(set_AZ_Position + uRA_AZ + "#", 1);
                inData = MountCommand(set_ALT_Position + sDEC_ALT + "#", 1);
                inData = MountCommand(Query_Num_Positions, 2);
                if (inData == "0#")
                    return 0;
                inData = MountCommand(set_AZ_Position + uRA_AZ + "#", 1);
                inData = MountCommand(set_ALT_Position + sDEC_ALT + "#", 1);
                inData = MountCommand(slew_to_set_RA_DEC + "1#", 1);
                if (inData == "1")
                    return 1;
                else
                    return 0;
            }
            return 0;
        }


        // set mount time to computer time
        public void SetToComputerTime()
        {
            string inData;

            DateTime utcdatetime = DateTime.UtcNow;
            double jUTC = JD(utcdatetime);                                      // convert UTC DateTime to Julian date.time
            ulong mountUTCtime = (ulong)((jUTC - JD_J2000) * miliSecondsInDay);    // convert Julian date.time to mount time
            lock (InOut)
                inData = MountCommand(string.Format("{0}{1:0000000000000}#", set_UTC_Time, mountUTCtime), 1);
        }


        //******************* Julian Date ************************************************** Julian Date *****************************
        public static bool IsJulianDate(int year, int month, int day)
        {
            // All dates prior to 1582 are in the Julian calendar
            if (year < 1582)
                return true;
            // All dates after 1582 are in the Gregorian calendar
            else if (year > 1582)
                return false;
            else
            {
                // If 1582, check before October 4 (Julian) or after October 15 (Gregorian)
                if (month < 10)
                    return true;
                else if (month > 10)
                    return false;
                else
                {
                    if (day < 5)
                        return true;
                    else if (day > 14)
                        return false;
                    else
                        // Any date in the range 10/5/1582 to 10/14/1582 is invalid 
                        throw new ArgumentOutOfRangeException(
                            "This date is not valid as it does not exist in either the Julian or the Gregorian calendars.");
                }
            }
        }

        static private double DateToJD(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            // Determine correct calendar based on date
            bool JulianCalendar = IsJulianDate(year, month, day);

            int M = month > 2 ? month : month + 12;
            int Y = month > 2 ? year : year - 1;
            double D = day + hour / 24.0 + minute / 1440.0 + (second + millisecond / 1000.0) / 86400.0;
            int B = JulianCalendar ? 0 : 2 - Y / 100 + Y / 100 / 4;

            return (int)(365.25 * (Y + 4716)) + (int)(30.6001 * (M + 1)) + D + B - 1524.5;
        }

        /*
        static public double JD(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            return DateToJD(year, month, day, hour, minute, second, millisecond);
        }
        */

        static public double JD(DateTime date)
        {
            return DateToJD(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, date.Millisecond);
        }
        //******************* END Julian Date


        //******************* Get Other Data *********************************************************** Get Other Data **************
        public void GetCostumTrackingRate()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_Tracking_Rate, 6);
            cemCustomTrackRate = labelCustomeTrackingRate.Text = inData.Substring(0, 1) + "." + inData.Substring(1, 4);
            cemCustomTrackingRateChanged = false;
        }

        public void GetParkingPostion()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_Park_Pos, 18);
            cemParkingAltitude = inData.Substring(0, 8);
            cemParkingAzimuth = inData.Substring(8, 9);
            cemParkingAltitude = labelMountParkingAltitude.Text = RetPostionString(Convert.ToDouble(cemParkingAltitude), 4);
            cemParkingAzimuth = labelMountParkingAzimuth.Text = RetPostionString(Convert.ToDouble(cemParkingAzimuth), 4);
            cemParkingPositionChanged = false;
        }

        public void GetMaximumSlewingRate()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_MAX_Slew_Rate, 2);
            cemMAXSlewingRate = Convert.ToByte(inData.Substring(0, 1));
            cemMAXSlewingRate -= 7;
            comboBoxMaxSlewingRate.SelectedIndex = cemMAXSlewingRate;
            cemMaxSlewRateChanged = false;
        }

        public void GetAltitudeLimit()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_Alt_Limit, 4);
            labelAltitudeLimitMIN.Text = inData.Substring(0, 3);
            cemAltitudeLimit = Convert.ToSByte(inData.Substring(0, 3));
            cemAltitudeLimitChanged = false;
        }

        public void GetRA_DEC_GuidingRates()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_RA_DEC_Guide_Rate, 5);
            cemRAguidingRate = inData.Substring(0, 2);
            cemDECguidingRate = inData.Substring(2, 2);
            labelRA_GuidingRate.Text = string.Format("0.{0}", cemRAguidingRate);
            labelDEC_GuidingRate.Text = string.Format("0.{0}", cemDECguidingRate);
            cemRA_DEC_GuidingRateChanged = false;
        }

        public void GetMeridainTreatment()
        {
            string inData;

            lock (InOut)
                inData = MountCommand(get_Meridian_Treatment, 4);
            cemMeridianFlipStatus = checkBoxMeridianFlipOnOff.Checked = (inData.Substring(0, 1) == "1") ? ON : OFF;
            cemMeridianFlipDegrees = Convert.ToByte(inData.Substring(1, 2));
            labelMeridianFlipDegrees.Text = string.Format("{0}", cemMeridianFlipDegrees);
            cemMeridianTreatmentChanged = false;
        }

        public void GetStatusOfAutoGuidingFilterRA() // ********** NOT CODED YET - FOR MOUNTS WITH ENCODERS
        {
            string inData;

            if (cemMountModel.Contains("EC") == true)
            {
                lock (InOut)
                    inData = MountCommand(get_Guiding_Filter_RA, 1);
                // ADD CODE FOR AUTO-GUIDING FILTER HERE
            }
        }

        public void GetOtherData(byte b) //********** Entry point to get other data ** b = what data not to get due to button press
        {
            if ((b != 1) && (cemTrackingRate == 4) && (cemCustomTrackingRateChanged == true))
                GetCostumTrackingRate();
            if ((b != 2) && (cemParkingPositionChanged == true))
                GetParkingPostion();
            if ((b != 3) && (cemMaxSlewRateChanged == true))
                GetMaximumSlewingRate();
            if ((b != 4) && (cemAltitudeLimitChanged == true))
                GetAltitudeLimit();
            if ((b != 5) && (cemRA_DEC_GuidingRateChanged == true))
                GetRA_DEC_GuidingRates();
            if ((b != 6) && (cemMeridianTreatmentChanged == true))
                GetMeridainTreatment();
            //if (b != 7)
            //    GetStatusOfAutoGuidingFilterRA();
        }


        //****************** Set Other Data *********************************************************** Set Other Data ***************
        // set meridian treatment, s=0 for OnOff treatment
        public void SetMeridianTreatment(byte s)
        {
            string inData;

            lock (InOut)
            {
                if (s == 0)
                    inData = MountCommand(string.Format(cemMeridianFlipStatus ? "{0}0{1:00}#" : "{0}1{1:00}#", set_Meridian_Treatment, cemMeridianFlipDegrees), 1);
                else
                    inData = MountCommand(string.Format(cemMeridianFlipStatus ? "{0}1{1:00}#" : "{0}0{1:00}#", set_Meridian_Treatment, cemMeridianFlipDegrees), 1);
            }
        }


        // ********** Combo Boxes ************************************************************************ Combo Boxes ***************
        // ***** tracking rates
        private void ComboBoxTrackingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemTrackingRate = (byte)comboBoxTrackingRate.SelectedIndex;
            inData = MountCommand((set_Tracking_Rate + cemTrackingRate + "#"), 1);
            if (cemTrackingRate == 4)
                cemCustomTrackingRateChanged = true;
            timer1.Start();
            this.ActiveControl = null;
        }

        // ***** max slewing rates
        private void ComboBoxMaxSlewingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemMAXSlewingRate = (byte)comboBoxMaxSlewingRate.SelectedIndex;
            cemMAXSlewingRate += 7;
            inData = MountCommand((set_MAX_Slew_Rate + cemMAXSlewingRate + "#"), 1);
            cemMaxSlewRateChanged = true;
            timer1.Start();
            this.ActiveControl = null;
        }

        // ***** moving rates
        private void ComboBoxManualMovingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemMovingRate = (byte)comboBoxManualMovingRate.SelectedIndex;
            cemMovingRate += 1;
            inData = MountCommand((set_Moving_Rate + cemMovingRate + "#"), 1);
            timer1.Start();
            this.ActiveControl = null;
        }

        private void ComboBox_StopTimer_DropDown(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        //********************* CHECK BOXES ******************************************************************* CHECK BOXES ******************/
        private void CheckBoxDayLightSavingsOnOff_MouseDown(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
            {
                if (checkBoxDayLightSavingsOnOff.Checked == true)
                    inData = MountCommand(set_DayLightSavings_OFF, 1);
                else
                    inData = MountCommand(set_DayLightSavings_ON, 1);
            }
        }

        private void CheckBoxMeridianFlipOnOff_MouseDown(object sender, MouseEventArgs e)
        {
            //GetMeridainTreatment();
            SetMeridianTreatment(0);            // change the flip statas ON or OFF
            cemMeridianTreatmentChanged = true;
        }


        //********************* BUTTONS ****************************************************************** BUTTONS ******************/

        // ***** turn tracking on - off
        private void ButtonTrackingOnOff_MouseClick(object sender, MouseEventArgs e)
        {
            string inData;

            if (cemMountParked == ON)
                return;
            if (cemTrackingOnOff == ON)
            {
                cemTrackingOnOff = OFF;
                lock (InOut)
                    inData = MountCommand(set_Tracking_OFF, 1);     // tracking OFF
            }
            else
            {
                cemTrackingOnOff = ON;
                lock (InOut)
                    inData = MountCommand(set_Tracking_ON, 1);  	// tracking ON
            }
        }

        // ***** Periodic Error Correction
        private void ButtonPeriodicErrorCorrection_Click(object sender, EventArgs e)
        {
            string inData;

            if (cemMountParked == ON)
                return;
            lock(InOut)
                GetPeriodicErrorStatus();
            if (cemPECenabled == OFF)
            {
                lock (InOut)
                    inData = MountCommand(set_Playback_PR_ON, 1);               // periodic error playback ON
                if (cemPECdataComplete == OFF)
                    lock (InOut)
                        inData = MountCommand(set_PE_Record_Start, 1);          // periodic error record ON
                cemPECplaybackOnOff = ON;
                cemPECenabled = ON;
            }
            else
            {
                if (cemPECrecording == ON)
                    lock (InOut)
                        inData = MountCommand(set_PE_Record_Stop, 1);           // periodic error record OFF
                lock (InOut)
                    inData = MountCommand(set_Playback_PR_OFF, 1);              // periodic error playback OFF
                cemPECplaybackOnOff = OFF;
                cemPECenabled = OFF;
            }
        }

        // ***** reset PEC recording
        private void ButtonResetPECrecording_Click(object sender, EventArgs e)
        {
            string inData;

            lock (InOut)
            {
                inData = MountCommand(set_PE_Record_Start, 1);
                inData = MountCommand(set_PE_Record_Stop, 1);
            }
        }

        // ***** go immediately to mount zero
        private void ButtonGotoZeroPosition_Click(object sender, EventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(slew_Zero_Position, 1);
        }

        // ***** set new mount zero
        private void ButtonSetNewZeroPosition_Click(object sender, EventArgs e)
        {
            string inData;

            // initializes variables to pass to MessageBox
            string _question = "Set New Zero?";
            string _caption = "YES NO Answer";
            MessageBoxButtons _buttons = MessageBoxButtons.YesNo;
            DialogResult _answer;
            // displays MessageBox
            _answer = MessageBox.Show(_question, _caption, _buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            // exit ButtonSetNewZeroPosition_Click if NO answer
            if (_answer == DialogResult.No)
                return;
            lock (InOut)
                inData = MountCommand(set_Zero_Position, 1);
        }

        // ***** search mount zero
        private void ButtonSearchMountZero_Click(object sender, EventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(search_Zero_Position, 1);
        }

        // ***** park - unpark mount
        private void ButtonParkMount_Click(object sender, EventArgs e)
        {
            string inData;

            GetParkingPostion();
            if (cemMountParked == ON)
                lock (InOut)
                    inData = MountCommand(mov_Unpark, 1);
            else
            {
                if ((cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
                    lock (InOut)
                        StopPlaybackRecord();
                lock (InOut)
                    inData = MountCommand(mov_Parking_Position, 1);
            }
        }

        // ***** mount stop all slewing
        private void ButtonAllStop_Click(object sender, EventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(slew_Stop, 1);
        }

        // ***** mount manual move north *****
        private void ButtonMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_DEC_Minus, 0);
        }

        // ***** mount manual move south *****
        private void ButtonMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_DEC_Plus, 0);
        }

        // ***** stop DEC manual move *****
        private void Manual_DEC_MoveSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_DEC_Stop, 1);
        }

        // ***** mount manual move east *****
        private void ButtonMoveRight_MouseDown(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_RA_Minus, 0);
        }

        // ***** mount manual move west *****
        private void ButtonMoveLeft_MouseDown(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_RA_Plus, 0);
        }

        // ***** stop RA manual move *****
        private void Manual_RA_MoveSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            string inData;

            lock (InOut)
                inData = MountCommand(mov_Manual_RA_Stop, 1);
        }

        // ***** slew to object *****
        private void SlewToObject_Click(object sender, EventArgs e)
        {
            string _RA, _DEC;
            // double[] d;
            // byte n;

            Slew2Object Slew2 = new Slew2Object();
            Slew2.ShowDialog();
            if (Slew2._FormStatus == true)
            {
                _RA = Str2MilliSecRAstr(Slew2._RA_of_Object);
                _DEC = Str2MiliSecDegStr(Slew2._DEC_of_Object, 8);
                lock (InOut)
                    if (DoMountSlew(_RA, _DEC, 0) == 0)
                    {
                        ErrorForm _error_ = new ErrorForm();
                        _error_.ErrorText = "ERROR: Cannot slew due to mount limits.";
                        _error_.ShowDialog();
                    }
            }

        }

        private string Str2MilliSecRAstr(string _str) //*** convert HH MM SS.SS to RA milliseconds
        {
            double[] d;
            byte n;

            d = new double[] { 0, 0, 0, 0, 0 };
            string[] RA_Split = _str.Split(' ');
            n = 0;
            foreach (string num in RA_Split)
                d[n++] = Convert.ToDouble(num);
            return string.Format("{0:000000000}", (d[2] / 3600.0 * 15.0) + (d[1] / 60.0 * 15.0) + (360.0 / 24.0 * d[0]) * 3600.0 * 100.0);
        }

        // ******************** User Data Entry **************************************************** User Data Entry ******************

        // ***** enter parking altitude degrees *****
        private void MountParkingAltitude_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 2;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 89";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                uint bb = Convert.ToUInt32(userInput._TextEntered);
                if ((bb >= 0) && (bb <= 89))
                {
                    cemParkingAltitude = userInput._TextEntered;
                    lock (InOut)
                        inData = MountCommand(string.Format("{0}{1:000000000}#", set_Alt_Park_Position, bb * 360000), 1);
                }
            }
            _OtherData_ = 0;
            cemParkingPositionChanged = true;
            this.ActiveControl = null;
        }

        // ***** set parking azimuth degrees *****
        private void MountParkingAzimuth_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 2;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 359";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                uint bb = Convert.ToUInt32(userInput._TextEntered);
                if ((bb >= 0) && (bb <= 359))
                {
                    cemParkingAzimuth = userInput._TextEntered;
                    lock (InOut)
                        inData = MountCommand(string.Format("{0}{1:000000000}#", set_AZ_Park_Position, bb * 360000), 1);
                }
            }
            _OtherData_ = 0;
            cemParkingPositionChanged = true;
            this.ActiveControl = null;
        }

        // ***** set meridian flip degrees *****
        private void MeridianFlipDegrees_Click(object sender, EventArgs e)
        {
            _OtherData_ = 6;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 10";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                byte bb = Convert.ToByte(userInput._TextEntered);
                if ((bb >= 0) && (bb <= 10))
                {
                    cemMeridianFlipDegrees = bb;
                    SetMeridianTreatment(1);        // change the flip degrees
                }
            }
            cemMeridianTreatmentChanged = true;
            _OtherData_ = 0;
            this.ActiveControl = null;
        }

        // ***** set altitude limit *****
        private void AltitudeLimitMIN_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 4;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 89";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                sbyte sb = Convert.ToSByte(userInput._TextEntered);
                if ((sb >= 0) && (sb <= 89))
                {
                    cemAltitudeLimit = sb;
                    lock (InOut)
                        inData = MountCommand(string.Format((cemHemisphere == 1) ? "{0}+{1:00}#" : "{0}-{1:00}#", set_Altitude_Limit, sb), 1);
                }
            }
            cemAltitudeLimitChanged = true;
            _OtherData_ = 0;
            this.ActiveControl = null;
        }

        // ***** set custom tracking rate *****
        private void CustomeTrackingRate_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 1;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.1000 to 1.9000";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double dc = Convert.ToDouble(userInput._TextEntered);
                if ((dc >= 0.1000) && (dc <= 1.9000))
                {
                    string _CTR = string.Format("{0:0.0000}", dc);
                    _CTR = _CTR.Substring(0, 1) + _CTR.Substring(2, 4);
                    lock (InOut)
                        inData = MountCommand(string.Format("{0}{1}#", set_Custom_Tracking_Rate, _CTR), 1);
                }
            }
            cemCustomTrackingRateChanged = true;
            _OtherData_ = 0;
            this.ActiveControl = null;
        }

        // ***** set RA guiding rate *****
        private void RA_GuidingRate_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 5;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.01 to 0.90";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double gr = Convert.ToDouble(userInput._TextEntered);
                if ((gr >= 0.01) && (gr <= 0.90))
                {
                    string _RAgr = string.Format("{0:0.00}", gr);
                    _RAgr = _RAgr.Substring(2, 2);
                    lock (InOut)
                        inData = MountCommand(string.Format("{0}{1}{2}#", set_Guiding_Rate, _RAgr, cemDECguidingRate), 1);
                }
            }
            cemRA_DEC_GuidingRateChanged = true;
            _OtherData_ = 0;
            this.ActiveControl = null;
        }

        // ***** set DEC guiding rate *****
        private void DEC_GuidingRate_Click(object sender, EventArgs e)
        {
            string inData;

            _OtherData_ = 5;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.10 to 0.99";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double gr = Convert.ToDouble(userInput._TextEntered);
                if ((gr >= 0.10) && (gr <= 0.99))
                {
                    string _DECgr = string.Format("{0:0.00}", gr);
                    _DECgr = _DECgr.Substring(2, 2);
                    lock (InOut)
                        inData = MountCommand(string.Format("{0}{1}{2}#", set_Guiding_Rate, cemRAguidingRate, _DECgr), 1);
                }
            }
            cemRA_DEC_GuidingRateChanged = true;
            _OtherData_ = 0;
            this.ActiveControl = null;
        }

        // ***** set the time zone offset *****
        private void UTC_Offset_Click(object sender, EventArgs e)
        {
            string inData;

            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry -720 to +780 minutes";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                short os = Convert.ToInt16(userInput._TextEntered);
                if ((os >= -720) && (os <= +780))
                {
                    lock (InOut)
                        inData = MountCommand(string.Format((os >= 0) ? "{0}+{1:000}#" : "{0}-{1:000}#", set_UTC_offset_Localtime, Math.Abs(os)), 1);
                }
            }
            this.ActiveControl = null;
        }

        // ***** goto RA DEC position *****
        private void Goto_RA_DEC_Position_Click(object sender, EventArgs e)
        {
            string _RA, _DEC; // , inData
            // double RA_Deg;
            // double[] d;
            // byte n;

            FormUserInput2 userInput2 = new FormUserInput2();
            userInput2._DialogLabel1 = "RA: hh mm ss";
            userInput2._DialogLabel2 = "DEC: dd mm ss";
            userInput2.ShowDialog();
            if (userInput2._FormStatus == true)
            {
                _RA = Str2MilliSecRAstr(userInput2._TextEntered1);
                _DEC = Str2MiliSecDegStr(userInput2._TextEntered2, 8);
                lock(InOut)
                    if (DoMountSlew(_RA, _DEC, 0) == 0)
                    {
                        ErrorForm _error_ = new ErrorForm();
                        _error_.ErrorText = "ERROR: Cannot slew due to mount limits.";
                        _error_.ShowDialog();
                    }
            }
        }

        // ***** goto ALT AZ position *****
        private void Goto_ALT_AZ_Position_Click(object sender, EventArgs e)
        {
            string _AZ, _ALT;

            FormUserInput2 userInput2 = new FormUserInput2();
            userInput2._DialogLabel1 = "ALT: dd mm ss";
            userInput2._DialogLabel2 = "AZ: ddd mm ss";
            userInput2.ShowDialog();
            if (userInput2._FormStatus == true)
            {
                _ALT = Str2MiliSecDegStr(userInput2._TextEntered1, 8);
                _AZ = Str2MiliSecDegStr(userInput2._TextEntered2, 9);
                lock(InOut)
                    if (DoMountSlew(_AZ, _ALT, 1) == 0)
                    {
                        ErrorForm _error_ = new ErrorForm();
                        _error_.ErrorText = "ERROR: Cannot slew due to mount limits.";
                        _error_.ShowDialog();
                    }
            }
        }

        // ***** convert string to millisecond string *****
        private string Str2MiliSecDegStr(string _str, byte T) //*** T = 8 for DEC or 9 for RA number of digits returned
        {
            double _Deg;
            double[] d;
            byte n;

            d = new double[] {0,0,0,0,0,0,0,0};
            string[] _Split = _str.Split(' ');
            n = 0;
            foreach (string num in _Split)
                d[n++] = Convert.ToDouble(num);
            _Deg = d[2] / 3600.0;
            _Deg += d[1] / 60.0;
            _Deg += Math.Abs(d[0]);
            return string.Format(T == 8 ? (d[0] < 0.0 ? "{0:-00000000}" : "{0:+00000000}") : "{0:000000000}", _Deg * 3600.0 * 100.0);
        }

        // ***** set latitude longitude position *****
        private void Set_Latitude_Longitude_Click(object sender, EventArgs e)
        {
            string _LOG, _LAT, inData;

            FormUserInput2 userInput2 = new FormUserInput2();
            userInput2._DialogLabel1 = "LAT: dd mm ss";
            userInput2._DialogLabel2 = "LOG: ddd mm ss";
            userInput2.ShowDialog();
            if (userInput2._FormStatus == true)
            {
                lock (InOut)
                {
                    _LAT = Str2MiliSecDegStr(userInput2._TextEntered1, 8);
                    inData = MountCommand(set_Latitude + _LAT + "#", 1);
                    _LOG = Str2MiliSecDegStr(userInput2._TextEntered2, 8);
                    inData = MountCommand(set_Longitude + _LOG + "#", 1);
                }
            }
        }

 
        //############################################################ WORK IN PROGRESS ################################################
    }
}
