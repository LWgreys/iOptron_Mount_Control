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



namespace Optron_Mount_Control
{

    public partial class MainControlForm : Form
    {
        //*** CEM Mount get command strings
        public const string get_CEM_Info = ":MountInfo#"; // retuns "nnnn" = Mount
        public const string get_MB_HC_Firmware = ":FW1#"; // returns "YYMMDDYYMMDD#" first date mainborad, second date hand controler
        public const string get_RA_DEC_Firmware = ":FW2#"; // returns "YYMMDDYYMMDD#" first data RA borad, second date DEC board
        public const string get_Loc_Stat = ":GLS#"; // returns "sTTTTTTTTTTTTTTTTnnnnnn#" s=sign -or+ first 8 Ts=Longitude in .01 arcsecound,
                                                    // second 8 Ts=Latitude in .01 arcseconds,
                                                    // first n=0 GPS malfunction, n=1 GPS not received valid data, n=2 GPS valid data received
                                                    // second n=0 Stoped at Non-Zero Position, n=1 Tracking no PEC, n=2 Slewing, n=3 Auto Guiding, n=4 Meridian Flipping, n=5 Tracking with PEC, n=6 Parked, n=7 Stopped at Zero position
                                                    // third n=0 Sidereal Rate, n=1 Lunar Rate, n=2 Solar Rate, n=3 King Rate, n=4 Custom Rate
                                                    // forth n= Moving Speed by Arror, 1= 1x, 2= 2x, 3= 8x, 4= 16x, 5= 64x, 6= 128x, 7= 256x, 8= 512x, 9= MAX
                                                    // fifth n= The Source of Time, 1= From RS-232 port or Ethernet port, 2= From Hand Controller, 3= From GPS
                                                    // sixth n= Hemisphere, 0= Southern, 1= Northern
        public const string get_UTC_Time = ":GUT#"; // returns "sMMMnXXXXXXXXXXXXX#" sMMM= UTC Offset for local time,
                                                    // n= Day Light Savings 0=OFF 1=ON,
                                                    // 13 digits XXXXXXXXXXXXX= Julian Date of current UTC Time
        public const string get_RA_DEC_Pos = ":GEP#"; // returns "sTTTTTTTTTTTTTTTTnn#" sTTTTTTTT= signed current DEC Position in .01 Arcseconds,
                                                      // second TTTTTTTT= current RA Position in .01 Arcseconds, 
                                                      // first n=0 for Pier East, n=1 for Pier West , n=2 for Undetermend Pier Position,
                                                      // second n=0 counterweight up, n=1 counterwieght normal
        public const string get_Alt_Az_Pos = ":GAC#"; //returns "sTTTTTTTTTTTTTTTTT#" sTTTTTTTT= signed Current Altitude in .01 Arcseconds
                                                      // second 9 digits TTTTTTTTT= Curent Azimuth in .01 Arcseconds of 360 degrees
        public const string get_Tracking_Rate = ":GTR#"; // returns "nnnnn#" = Current Custom Tracking Rate 0.1000 to 1.9000
        public const string get_Park_Pos = ":GPC#"; // returns "TTTTTTTTTTTTTTTTT#" first 8 digits = Parking Altitude in .01 Arcseconds
                                                    // second 9 Digits = Parking Azimuth in .01 Arcseconds of 360 degrees
        public const string get_MAX_Slew_Rate = ":GSR#"; // returns Slew Rate "7#"=256x, "8#"=512x, "9#"=MAX
        public const string get_Alt_Limit = ":GAL#"; // returns "snn#" = Altitude Limit signed degrees
        public const string get_RA_DEC_Guide_Rate = ":AG#"; // returns "nnnn#" first 2 digits = RA Guiding Rate, second 2 digits = DEC Guiding Rate
        public const string get_Meridian_Treatment = ":GMT#"; // returns "nnn#" first digit 0=Stop at Meridian, 1=Flipp at second 2 digits degrees 0 to 10
        public const string get_Guiding_Filter_RA = ":GGF#"; // returns RA AutoGuiding "0"=Off "1"=ON, Available only equatorial mount with encoders
        public const string get_Periodic_Error_Data = ":GPE#"; // returns "0"=incomplete PED, "1"=Completed PED, Available only equatorial mount without encoders
        public const string get_Periodic_Error_Stat = ":GPR#"; // returns "0"=PE recording Stopped, "1"=PE being Recorded, Available only equatorial mount without encoders
        //*** CEM Mount set command strings
        public string set_Tracking_Rate = ":RT"; // +"0#" = Sidereal, +"1#" = Lunar, +"2#" = Solar, +"3#" = King, +"4#" = Custom
        public string set_Moving_Rate = ":SR"; // +"1#" = 1x, +"2#" = 2x, +"3#" = 8x, +"4#" = 16x, +"5#" = 64x, +"6#" = 128x, +"7#" = 256x, +"8#" = 512x, +"9#" = MAX
        public string set_Guiding_Filter = ":SGF"; // +"0#" = OFF, +"1#" = ON // Available only equatorial mount with encoders
        //*** CEM Mount set command strings that are saved in mount after poower cycle
        public string set_UTC_offset_Localtime = ":SG"; // +"sMMM#" s=sign -or+, MMM=minutes
        public const string set_DayLightSavings_OFF = ":SDS0#"; // returns "1", set daylight savings OFF
        public const string set_DayLightSavings_ON = ":SDS1#"; // returns "1", set daylight savings ON
        public string set_UTC_Time = ":SUT"; // +"XXXXXXXXXXXXX#" = Julian Date of current UTC Time in 1 milliseconds
        public string set_Longitude = ":SLO:"; // +"sTTTTTTTT#" s=sign -West or +East, TTTTTTTT=arc-seconds 0.01 resolution
        public string set_Latitude = ":SLA"; // +"sTTTTTTTT#" s=sign -South or +North, TTTTTTTT=arc-seconds 0.01 resolution
        public const string set_Hemisphere_South = ":SHE0#";// returns "1", Southern hemisphere
        public const string set_Hemisphere_North = ":SHE1#";// returns "1", Northen hemisphere
        public string set_MAX_Slew_Rate = ":MSR"; // +"7#"=256x, +"8#"=512x, +"9#"=MAX
        public string set_Altitude_Limit = ":SAL"; // +"snn#" s=sign -or+, nn=Degrees
        public string set_Guiding_Rate = ":RG"; // +"nnnn#" first 2 digits set RA rate [.01 to .90], second 2 digits set DEC Rate [.01 to .99]
        public string set_Meridian_Treatment = ":SMT"; // +"nnn#" first digit 0=Stop or 1=Flip at second 2 digits Degrees
        public const string reset_All_to_Defaults = ":RAS#"; // returns "1" Does NOT reset any date, time or time zone settings
        //*** CEM Mount Motion commands
        public string slew_Previous_RA_DEC = ":MS"; // +"1#" slew normal previous set RA DEC position, +"2#"= slew counter weight up, 
                                                    // return "1" if command accepted, "0" if object below limit or exceeds mechanical limits
        public const string slew_Previous_Alt_Az = ":MSS#"; // Slew to previous set Altitude Azimuth postion,
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
        public const string slew_Zero_Position = ":MH#"; // slew to zero position immediatly, returns "1"
        public const string search_Zero_Position = ":MSH#"; // returns "1", availble only for CEM120, CEM70, Gem45, CEM40
        public const string set_PE_Record_Stop = ":SPR0#"; // returns "1", stop Periodic Error Recording
        public const string set_PE_Record_Start = ":SPR1#"; // returns "1", strat Periodic Error Recording
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
        public const string Query_Num_Aval_Positions = ":QAP#"; // returns "0#", "1#", "2#"
        public const string set_Calibrate_RA = ":SRA"; // +"TTTTTTTTT#"= .01 Arcseconds to most recent defined RA, returns "1"
        public const string set_Calibrate_DEC = ":Sd"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined DEC, returns "1"
        public const string set_Calibrate_Alt = ":Sa"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined Altitude, returns "1"
        public const string set_Calibrate_Aa = ":Sz"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined Azimuth, returns "1"
        public const string set_Zero_Position = ":SZP#"; // set current poosition as ZERO Position, returns "1"
        public const string set_AZ_Park_Position = ":SPA"; // +"TTTTTTTTT#= .01 Arcseconds, returns "1"
        public const string set_Alt_Park_Position = ":SPH"; // +"TTTTTTTTT#= .01 Arcseconds, returns "1"

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
        public static bool cemPECdataComplete;
        public static bool cemPECrecording;
        public static bool cemPECplaybackOnOff;
        public static bool cemPECenabled;

        const string NO_PORTS_MESSAGE = "No COM ports found";
        static byte _OtherData_;
        const double miliSecondsInDay = 86400000.0;     // Number of seconds in a day
        const double J2000 = 2451545.0;                 // Julian date time 2000-01-01 12:00.00 noon
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
            buttonResetPEC.Enabled = OFF;

            // Get a list of COM ports
            ComboBoxComPort.Items.Clear(); // Clear any existing entries
            foreach (string ComString in SerialPort.GetPortNames())
                ComboBoxComPort.Items.Add(ComString); // Get Avaliable ComPorts
            if (ComboBoxComPort.Items.Count == 0)
            {
                ButtonCOMPortConnect.Text = NO_PORTS_MESSAGE;
                ButtonCOMPortConnect.Enabled = ON;
            }

            _OtherData_ = 0;
            timer1.Stop();
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

            if (ButtonCOMPortConnect.Text == NO_PORTS_MESSAGE) // Exit progam if no ports found
                return;

            if (MountComPort.IsOpen == false)
            {
                MountComPort.Open(); // Open mount COM port if not already open
                MountComPort.DiscardOutBuffer();
                MountComPort.DiscardInBuffer();
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
                groupBoxMountGPS_Time.Enabled = OFF;
                groupBoxMountPad.Enabled = OFF;
                groupBoxMountParking.Enabled = OFF;
                groupBoxMountPointingPosition.Enabled = OFF;
                groupBoxMountTracking.Enabled = OFF;
                groupBoxMountZeroPosition.Enabled = OFF;
                groupBoxSettings_Limits.Enabled = OFF;
                return;
            }

            labelTimeSource.Text = "....";

            // Get mount model number
            SendMountCommand(get_CEM_Info);
            inData = GetMountResponce(4);
            index = MountModel.Length / 2;
            for (i = 0; i < index; i++)
            {
                if (MountModel[0, i] == inData)
                    break;
            }
            cemMountModel = MountModel[1, i];
            ButtonCOMPortConnect.Text = "Connected To " + MountModel[1, i];
            // Get firmware dates
            firmwareDate = null;
            SendMountCommand(get_MB_HC_Firmware);
            firmwareDate = GetMountResponce(13);
            cemMBfirmwareDate = firmwareDate.Substring(0, 6);
            cemHCfirmwareDate = firmwareDate.Substring(6, 6);
            firmwareDate = null;
            SendMountCommand(get_RA_DEC_Firmware);
            firmwareDate = GetMountResponce(13);
            cemRAfirmwareDate = firmwareDate.Substring(0, 6);
            cemDECfirmwareDate = firmwareDate.Substring(6, 6);

            timer1.Start();
        }


        //*** Send Mount Command String ***
        public void SendMountCommand(string outString)
        {
            MountComPort.Write(text: outString);
        }


        //*** Get Responce From Mount ***
        public string GetMountResponce(int numberOfChar)
        {
            string inBuffer;
            byte[] buffer = new byte[numberOfChar];
            int i;

            for (i = 0; i != numberOfChar; i++)
                buffer[i] = (byte)MountComPort.ReadByte();
            inBuffer = UTF8Encoding.UTF8.GetString(buffer);
            return inBuffer;
        }



        //********** TIMER 1 ***************************************************************************** TIMER 1 *******************
        public void getMountData(Object myObject, EventArgs myEventArgs)
        {
            string inData;

            // Get GPS Longitude Latitude and other infomation
            lock (InOut)
            {
                SendMountCommand(get_Loc_Stat);
                inData = GetMountResponce(24);
            }
            cemLongitude = inData.Substring(0, 9);
            cemLatitude = inData.Substring(9, 8);
            cemLatitudeEastWest = inData.Substring(0, 1);
            cemGPSstatus = Convert.ToByte(inData.Substring(17, 1));
            cemInMotion = Convert.ToByte(inData.Substring(18, 1));
            cemTrackingRate = Convert.ToByte(inData.Substring(19, 1));
            cemMovingRate = Convert.ToByte(inData.Substring(20, 1));
            cemTimeSource = Convert.ToByte(inData.Substring(21, 1));
            cemHemisphere = Convert.ToByte(inData.Substring(22, 1));
            switch (cemGPSstatus)
            {
                case 2:
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
            switch (cemInMotion)
            {
                case 0: // stopped at none zero position
                    if ((cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
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
                    if (cemPECdataComplete == ON)
                    {
                        buttonPeriodicErrorCorrection.BackColor = Color.Green;
                        buttonPeriodicErrorCorrection.Text = "PEC Tracking ON";
                    }
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
                    if ((cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
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
            // Tracking rate
            comboBoxTrackingRate.SelectedIndex = cemTrackingRate;
            if (cemTrackingRate == 4)
                labelCustomeTrackingRate.Enabled = ON;
            else
                labelCustomeTrackingRate.Enabled = OFF;
            // Moving rate
            comboBoxManualMovingRate.SelectedIndex = cemMovingRate - 1;

            // Get Mount UTC time
            if ((cemTimeSource == 2) || (cemTimeSource == 3) || (labelTimeSource.Text == "CPU"))
            {
                byte DLST;
                double UTCtime, UTCoffset, MountTime, LocalTime, localJ2000;

                lock (InOut)
                {
                    SendMountCommand(get_UTC_Time);
                    inData = GetMountResponce(19);
                }
                // convert mount time to UTC time
                cemUTCoffset = labelUTC_Offset.Text = inData.Substring(0, 4);
                UTCoffset = Convert.ToDouble(cemUTCoffset);
                DLST = Convert.ToByte(inData.Substring(4, 1));
                cemMountTime = inData.Substring(5, 13);
                MountTime = Convert.ToDouble(cemMountTime);
                cemDaylightTime = checkBoxDayLightSavingsOnOff.Checked = (DLST == 1) ? ON : OFF;
                UTCtime = (MountTime / miliSecondsInDay) + J2000;     // convert Mount Time to UTC time
                UTCtime -= (int)UTCtime;                        // get the time part
                cemUTCtime = labelTimeUTC.Text = retTimeString(UTCtime);
                // convert mount time to Local time
                LocalTime = MountTime / miliSecondsInDay;
                localJ2000 = J2000 - (1.0 - ((1440.0 + ((DLST == 1) ? (UTCoffset - -60.0) : UTCoffset)) / 1440.0));
                LocalTime += localJ2000;
                LocalTime -= (int)LocalTime;
                labelTimeLocal.Text = retTimeString(LocalTime);
            }

            switch (cemTimeSource)  // show were souce of time comming from
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
                    if (labelTimeSource.Text != "CPU")
                    {
                        setToComputerTime();
                        labelTimeSource.Text = "CPU";
                    }
                    break;
            }

            // get RA and DEC position
            lock (InOut)
            {
                SendMountCommand(get_RA_DEC_Pos); // get RA and DEC possition
                inData = GetMountResponce(21);
            }
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
            // get ALT and AZ position
            lock (InOut)
            {
                SendMountCommand(get_Alt_Az_Pos);
                inData = GetMountResponce(19);
            }
            cemAltitudePosition = inData.Substring(0, 9);
            cemAzimuthPosition = inData.Substring(9, 9);
            cemAltitudePosition = labelAltitude.Text = RetPostionString(Convert.ToDouble(cemAltitudePosition), 0);
            cemAzimuthPosition = labelAzimuth.Text = RetPostionString(Convert.ToDouble(cemAzimuthPosition), 0);

            // periodic error correction
            if (cemPECenabled == ON) // && (cemTrackingOnOff == ON))
            {
                lock (InOut)
                    GetPeriodicErrorStatus();
                if (cemPECdataComplete == ON)
                    buttonResetPEC.Enabled = ON;
                else
                    buttonResetPEC.Enabled = OFF;

                if (cemPECplaybackOnOff == OFF)
                {
                    if ((cemPECdataComplete == OFF) && (cemPECrecording == OFF))
                    {
                        buttonPeriodicErrorCorrection.BackColor = Color.OrangeRed;
                        buttonPeriodicErrorCorrection.Text = "Recording PEC";
                        cemPECrecording = ON;
                        lock (InOut)
                        {
                            SendMountCommand(set_PE_Record_Start);                      // turn periodic error record ON
                            inData = GetMountResponce(1);
                        }
                    }
                    else if ((cemPECdataComplete == ON) && (cemPECrecording == ON))
                    {
                        cemPECrecording = OFF;
                        lock (InOut)
                        {
                            SendMountCommand(set_PE_Record_Stop);                       // periodic error recording OFF
                            inData = GetMountResponce(1);
                        }
                    }
                    else if ((cemPECdataComplete == ON) && (cemPECrecording == OFF))
                    {
                        cemPECplaybackOnOff = ON;
                        lock (InOut)
                        {
                            SendMountCommand(set_Playback_PR_ON);                       // turn periodic error playback ON
                            inData = GetMountResponce(1);
                        }
                    }
                }
            }
            else if (cemPECplaybackOnOff == ON)
            {
                lock (InOut)
                {
                    SendMountCommand(set_Playback_PR_OFF);
                    inData = GetMountResponce(1);
                }
                cemPECplaybackOnOff = OFF;

            }

            // get other data
            getOtherData(_OtherData_);
        }
        //***************** END TIMER 1 ******************************************************************** END TIME 1 **************/

        // ***** get Periodic Error Status
        public void GetPeriodicErrorStatus()
        {
            string inData;

            SendMountCommand(get_Periodic_Error_Data);
            inData = GetMountResponce(1);
            if (inData == "1")
                cemPECdataComplete = ON;  // periodic error recording complete
            else
                cemPECdataComplete = OFF; // recording incomplete

            SendMountCommand(get_Periodic_Error_Stat);
            inData = GetMountResponce(1);
            if (inData == "1")
                cemPECrecording = ON;   // periodic erreo being recorded
            else
                cemPECrecording = OFF;  // periodic error recording STOPPED
        }


        // ***** stop periodic error playback & recording
        private void StopPlaybackRecord()
        {
            string inData;

            cemPECenabled = OFF;
            cemPECrecording = OFF;
            SendMountCommand(set_PE_Record_Stop);                       // periodic error recording OFF
            inData = GetMountResponce(1);
            cemPECplaybackOnOff = OFF;
            SendMountCommand(set_Playback_PR_OFF);                      // periodic error playback OFF
            inData = GetMountResponce(1);
        }


        // ***** return formated time string
        public static string retTimeString(double tdd)
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
                    // return string.Format("{0:0} : {1:00} : {2:00}", _degrees, _minutes, _seconds);
                    return string.Format("{0:0}", _degrees);
                default:
                    return string.Format("{0:0}h {1:00}m {2:00}.{3:00}s", _degrees, _minutes, _seconds, _decimal);
            }
        }


        // set mount time to computer time
        public void setToComputerTime()
        {
            string inData;

            DateTime utcdatetime = DateTime.UtcNow;
            double jUTC = JD(utcdatetime);                                      // convert UTC DateTime to Julian date.time
            ulong mountUTCtime = (ulong)((jUTC - J2000) * miliSecondsInDay);    // convert Julian date.time to mount time
            SendMountCommand(string.Format("{0}{1:0000000000000}#", set_UTC_Time, mountUTCtime));
            inData = GetMountResponce(1);
        }



        //******************* Julian Date ************************************************** Julian Date *****************************
        public static bool isJulianDate(int year, int month, int day)
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
            bool JulianCalendar = isJulianDate(year, month, day);

            int M = month > 2 ? month : month + 12;
            int Y = month > 2 ? year : year - 1;
            double D = day + hour / 24.0 + minute / 1440.0 + (second + millisecond / 1000.0) / 86400.0;
            int B = JulianCalendar ? 0 : 2 - Y / 100 + Y / 100 / 4;

            return (int)(365.25 * (Y + 4716)) + (int)(30.6001 * (M + 1)) + D + B - 1524.5;
        }

        static public double JD(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            return DateToJD(year, month, day, hour, minute, second, millisecond);
        }

        static public double JD(DateTime date)
        {
            return DateToJD(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, date.Millisecond);
        }


        //******************* Get Other Data *********************************************************** Get Other Data **************
        public void GetCostumTrackingRate()
        {
            string inData;

            SendMountCommand(get_Tracking_Rate);
            inData = GetMountResponce(6);
            cemCustomTrackRate = labelCustomeTrackingRate.Text = inData.Substring(0, 1) + "." + inData.Substring(1, 4);
        }


        public void GetParkingPostion()
        {
            string inData;

            SendMountCommand(get_Park_Pos);
            inData = GetMountResponce(18);
            cemParkingAltitude = inData.Substring(0, 8);
            cemParkingAzimuth = inData.Substring(8, 9);
            cemParkingAltitude = labelMountParkingAltitude.Text = RetPostionString(Convert.ToDouble(cemParkingAltitude), 4);
            cemParkingAzimuth = labelMountParkingAzimuth.Text = RetPostionString(Convert.ToDouble(cemParkingAzimuth), 4);
        }


        public void GetMaximumSlewingRate()
        {
            string inData;

            SendMountCommand(get_MAX_Slew_Rate);
            inData = GetMountResponce(2);
            cemMAXSlewingRate = Convert.ToByte(inData.Substring(0, 1));
            cemMAXSlewingRate -= 7;
            comboBoxMaxSlewingRate.SelectedIndex = cemMAXSlewingRate;
        }


        public void GetAltitudeLimit()
        {
            string inData;

            SendMountCommand(get_Alt_Limit);
            inData = GetMountResponce(4);
            labelAltitudeLimitMIN.Text = inData.Substring(0, 3);
            cemAltitudeLimit = Convert.ToSByte(inData.Substring(0, 3));
        }


        public void GetRA_DEC_GuidingRates()
        {
            string inData;

            SendMountCommand(get_RA_DEC_Guide_Rate);
            inData = GetMountResponce(5);
            cemRAguidingRate = inData.Substring(0, 2);
            cemDECguidingRate = inData.Substring(2, 2);
            labelRA_GuidingRate.Text = string.Format("0.{0}", cemRAguidingRate);
            labelDEC_GuidingRate.Text = string.Format("0.{0}", cemDECguidingRate);
        }


        public void GetMeridainTreatment()
        {
            string inData;

            SendMountCommand(get_Meridian_Treatment);
            inData = GetMountResponce(4);
            cemMeridianFlipStatus = checkBoxMeridianFlipOnOff.Checked = (inData.Substring(0, 1) == "1") ? ON : OFF;
            cemMeridianFlipDegrees = Convert.ToByte(inData.Substring(1, 2));
            labelMeridianFlipDegrees.Text = string.Format("{0}", cemMeridianFlipDegrees);
        }


        public void GetStatusOfAutoGuidingFilterRA()
        {
            string inData;

            if (cemMountModel.Contains("EC") == true)
            {
                SendMountCommand(get_Guiding_Filter_RA);
                inData = GetMountResponce(1);
                // ADD CODE FOR AUTO-GUIDING FILTER HERE

            }
        }


        public void getOtherData(byte b)
        {
            if (b != 1)
                GetCostumTrackingRate();
            if (b != 2)
                GetParkingPostion();
            if (b != 3)
                GetMaximumSlewingRate();
            if (b != 4)
                GetAltitudeLimit();
            if (b != 5)
                GetRA_DEC_GuidingRates();
            if (b != 6)
                GetMeridainTreatment();
            //if (b != 7)
            //    GetStatusOfAutoGuidingFilterRA();
        }



        //****************** Set Other Data *********************************************************** Set Other Data ***************
        // set meridian treatment, s=0 for OnOff treatment
        public void SetMeridianTreatment(byte s)
        {
            if (s == 0)
                SendMountCommand(string.Format((cemMeridianFlipStatus ? "{0}0{1:00}#" : "{0}1{1:00}#"), set_Meridian_Treatment, cemMeridianFlipDegrees));
            else
                SendMountCommand(string.Format((cemMeridianFlipStatus ? "{0}1{1:00}#" : "{0}0{1:00}#"), set_Meridian_Treatment, cemMeridianFlipDegrees));
            string inData = GetMountResponce(1);
        }



        // ********** Combo Boxes ************************************************************************ Combo Boxes ***************
        private void comboBoxTrackingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemTrackingRate = (byte)comboBoxTrackingRate.SelectedIndex;
            SendMountCommand((set_Tracking_Rate + cemTrackingRate + "#"));
            inData = GetMountResponce(1);
            timer1.Start();
            this.ActiveControl = null;
        }


        private void comboBoxTrackingRate_DropDown(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void comboBoxMaxSlewingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemMAXSlewingRate = (byte)comboBoxMaxSlewingRate.SelectedIndex;
            cemMAXSlewingRate += 7;
            SendMountCommand((set_MAX_Slew_Rate + cemMAXSlewingRate + "#"));
            inData = GetMountResponce(1);
            timer1.Start();
            this.ActiveControl = null;
        }


        private void comboBoxMaxSlewingRate_DropDown(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void comboBoxManualMovingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inData;

            cemMovingRate = (byte)comboBoxManualMovingRate.SelectedIndex;
            cemMovingRate += 1;
            SendMountCommand((set_Moving_Rate + cemMovingRate + "#"));
            inData = GetMountResponce(1);
            timer1.Start();
            this.ActiveControl = null;
        }


        private void comboBoxManualMovingRate_DropDown(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        //********************* CHECK BOXES ******************************************************************* CHECK BOXES ******************/
        private void checkBoxDayLightSavingsOnOff_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            if (checkBoxDayLightSavingsOnOff.Checked == true)
                SendMountCommand(set_DayLightSavings_OFF);
            else
                SendMountCommand(set_DayLightSavings_ON);
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        private void checkBoxMeridianFlipOnOff_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            GetMeridainTreatment();
            SetMeridianTreatment(0);
            timer1.Start();
        }


        //********************* BUTTONS ****************************************************************** BUTTONS ******************/

        // ***** turn tracking on - off
        private void buttonTrackingOnOff_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            string inData;

            if (cemMountParked == ON)
                return;
            if (cemTrackingOnOff == ON)
            {
                cemTrackingOnOff = OFF;
                SendMountCommand(set_Tracking_OFF); // tracking OFF
                inData = GetMountResponce(1);
            }
            else
            {
                cemTrackingOnOff = ON;
                SendMountCommand(set_Tracking_ON);  // tracking ON
                inData = GetMountResponce(1);
            }
            timer1.Start();
        }


        // ***** Periodic Error Correction
        private void buttonPeriodicErrorCorrection_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (cemMountParked == ON)
                return;
            if (cemPECenabled == ON)
                StopPlaybackRecord();
            else
                cemPECenabled = ON;
            timer1.Start();
        }


        // ***** 
        private void buttonResetPECrecording_Click(object sender, EventArgs e)
        {
            // do a PEC record then stop to reset PEC recording
            SendMountCommand(set_PE_Record_Start);
            GetMountResponce(1);
            SendMountCommand(set_PE_Record_Stop);
            GetMountResponce(1);
        }


        // ***** go immediately to mount zero
        private void buttonGotoZeroPosition_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SendMountCommand(slew_Zero_Position);
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        // ***** set new mount zero
        private void buttonSetNewZeroPosition_Click(object sender, EventArgs e)
        {
            // initializes variables to pass to MessageBox
            string _question = "Set New Zero?";
            string _caption = "YES NO Answer";
            MessageBoxButtons _buttons = MessageBoxButtons.YesNo;
            DialogResult _answer;
            // displays MessageBox
            _answer = MessageBox.Show(_question, _caption, _buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            // exit buttonSetNewZeroPosition_Click if NO answre
            if (_answer == DialogResult.No)
                return;

            timer1.Stop();
            SendMountCommand(set_Zero_Position);
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        // ***** search mount zero
        private void buttonSearchMountZero_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SendMountCommand(search_Zero_Position);
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        // ***** park - unpark mount
        private void buttonParkMount_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            GetParkingPostion();
            if (cemMountParked == ON)
                SendMountCommand(mov_Unpark);
            else
            {
                if ((cemPECplaybackOnOff == ON) || (cemPECrecording == ON))
                    StopPlaybackRecord();
                SendMountCommand(mov_Parking_Position);
            }
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        // ***** mount stop all slewing
        private void buttonAllStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SendMountCommand(slew_Stop);
            GetMountResponce(1);
            timer1.Start();
        }


        // ***** mount manual move north *****
        private void buttonMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_DEC_Minus);
            timer1.Start();
        }

        // ***** mount manual move south *****
        private void buttonMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_DEC_Plus);
            timer1.Start();
        }
        // ***** stop DEC manual move *****
        private void Manual_DEC_MoveSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_DEC_Stop);
            string inData = GetMountResponce(1);
            timer1.Start();
        }


        // ***** mount manual move east *****
        private void buttonMoveRight_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_RA_Minus);
            timer1.Start();
        }

        // ***** mount manual move west *****
        private void buttonMoveLeft_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_RA_Plus);
            timer1.Start();
        }
        // ***** stop RA manual move *****
        private void Manual_RA_MoveSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            SendMountCommand(mov_Manual_RA_Stop);
            string inData = GetMountResponce(1);
            timer1.Start();
        }



        // ******************** User Data Entry **************************************************** User Data Entry ******************

        // ***** enter parking altitude degrees *****
        private void MountParkingAltitude_Click(object sender, EventArgs e)
        {
            _OtherData_ = 2;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 89";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                uint bb = Convert.ToUInt32(userInput._TextEntered);
                if ((bb >= 0) && (bb <= 89))
                {
                    timer1.Stop();
                    cemParkingAltitude = userInput._TextEntered;
                    SendMountCommand(string.Format("{0}{1:000000000}#", set_Alt_Park_Position, bb * 360000));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }


        // ***** set parking azimuth degrees *****
        private void MountParkingAzimuth_Click(object sender, EventArgs e)
        {
            _OtherData_ = 2;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 359";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                uint bb = Convert.ToUInt32(userInput._TextEntered);
                if ((bb >= 0) && (bb <= 359))
                {
                    timer1.Stop();
                    cemParkingAzimuth = userInput._TextEntered;
                    SendMountCommand(string.Format("{0}{1:000000000}#", set_AZ_Park_Position, bb * 360000));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
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
                    timer1.Stop();
                    cemMeridianFlipDegrees = bb;
                    SetMeridianTreatment(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

        private void AltitudeLimitMIN_Click(object sender, EventArgs e)
        {
            _OtherData_ = 4;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0 to 89";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                sbyte sb = Convert.ToSByte(userInput._TextEntered);
                if ((sb >= 0) && (sb <= 89))
                {
                    timer1.Stop();
                    cemAltitudeLimit = sb;
                    SendMountCommand(string.Format((cemHemisphere == 1) ? "{0}+{1:00}#" : "{0}-{1:00}#", set_Altitude_Limit, sb));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

        private void CustomeTrackingRate_Click(object sender, EventArgs e)
        {
            _OtherData_ = 1;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.1000 to 1.9000";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double dc = Convert.ToDouble(userInput._TextEntered);
                if ((dc >= 0.1000) && (dc <= 1.9000))
                {
                    timer1.Stop();
                    string _CTR = string.Format("{0:0.0000}", dc);
                    _CTR = _CTR.Substring(0, 1) + _CTR.Substring(2, 4);
                    SendMountCommand(string.Format("{0}{1}#", set_Custom_Tracking_Rate, _CTR));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

        private void RA_GuidingRate_Click(object sender, EventArgs e)
        {
            _OtherData_ = 5;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.01 to 0.90";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double gr = Convert.ToDouble(userInput._TextEntered);
                if ((gr >= 0.01) && (gr <= 0.90))
                {
                    timer1.Stop();
                    string _RAgr = string.Format("{0:0.00}", gr);
                    _RAgr = _RAgr.Substring(2, 2);
                    SendMountCommand(string.Format("{0}{1}{2}#", set_Guiding_Rate, _RAgr, cemDECguidingRate));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

        private void DEC_GuidingRate_Click(object sender, EventArgs e)
        {
            _OtherData_ = 5;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry 0.10 to 0.99";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                double gr = Convert.ToDouble(userInput._TextEntered);
                if ((gr >= 0.10) && (gr <= 0.99))
                {
                    timer1.Stop();
                    string _DECgr = string.Format("{0:0.00}", gr);
                    _DECgr = _DECgr.Substring(2, 2);
                    SendMountCommand(string.Format("{0}{1}{2}#", set_Guiding_Rate, cemRAguidingRate, _DECgr));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

        private void UTC_Offset_Click(object sender, EventArgs e)
        {
            _OtherData_ = 20;
            formUserInput userInput = new formUserInput();
            userInput._DialogText = "Entry -720 to +780 minutes";
            userInput.ShowDialog();
            if (userInput._FormStatus == true)
            {
                short os = Convert.ToInt16(userInput._TextEntered);
                if ((os >= -720) && (os <= +780))
                {
                    timer1.Stop();
                    // cemUTCoffset = userInput._TextEntered;
                    SendMountCommand(string.Format((os >= 0) ? "{0}+{1:000}#" : "{0}-{1:000}#", set_UTC_offset_Localtime, Math.Abs(os)));
                    GetMountResponce(1);
                    timer1.Start();
                }
            }
            this.ActiveControl = null;
            _OtherData_ = 0;
        }

    }
}
