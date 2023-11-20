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


namespace Optron_Mount_Control
{

    public partial class MainControlForm : Form
    {
        //*** CEM Mount get command strings
        public const string get_CEM_Info = ":MountInfo#"; // retuns "nnnn" = Mount
        public const string get_CEM_MB_HC_Firmware = ":FW1#"; // returns "YYMMDDYYMMDD#" first date mainborad, second date hand controler
        public const string get_CEM_RA_DEC_Firmware = ":FW2#"; // returns "YYMMDDYYMMDD#" first data RA borad, second date DEC board
        public const string get_GPS_Loc_Stat = ":GLS#"; // returns "sTTTTTTTTTTTTTTTTnnnnnn#" s=sign -or+ first 8 Ts=Longitude in .01 arcsecound,
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
        public string set_Tracking_OFF = ":ST0#"; // returns "1", turns tracking OFF
        public string set_Tracking_ON = ":ST1#"; // returns "1", turns tracking ON
        public string mov_Guiding_RA_Plus = ":ZS"; // +"XXXXX#"=milliseconds RA+ at current guiding rate
        public string mov_Guiding_RA_Minus = ":ZQ"; // +"XXXXX#"=milliseconds RA- at current guiding rate
        public string mov_Guiding_DEC_Plus = ":ZE"; // +"XXXXX#"=milliseconds DEC+ at current guiding rate
        public string mov_Guiding_DEC_Minus = ":ZC"; // +"XXXXX#"=milliseconds DEC- at current guiding rate
        //*** The following commands are no longer used, supersede by above commands
        // public string mov_Guiding_RA_Plus = ":Mw"; // +"XXXXX#"=milliseconds RA+ at current guiding rate
        // public string mov_Guiding_RA_Minus = ":Me"; // +"XXXXX#"=milliseconds RA- at current guiding rate
        // public string mov_Guiding_DEC_Plus = ":Mn"; // +"XXXXX#"=milliseconds DEC- at current guiding rate
        // public string mov_Guiding_DEC_Minus = ":Ms"; // +"XXXXX#"=milliseconds DEC+ at current guiding rate
        public const string mov_Parking_Position = ":MP1#"; // move to previous set parking position, return "1"
        public const string mov_Unpark = ":MP0#"; // unpark mount, returns "1"
        public const string slew_Zero_Position = ":MH#"; // slew to zero position immediatly, returns "1"
        public const string search_Zero_Position = ":MSH#"; // returns "1", availble only for CEM120, CEM70, Gem45, CEM40
        public const string set_PE_Record_Stop = ":SPR0#"; // returns "1", stop Periodic Error Recording
        public const string set_PE_Record_Start = ":SPR1#"; // returns "1", strat Periodic Error Recording
        public const string set_Playback_PR_OFF = ":SPP0#"; // returns "1", disable Periodic Error Correction playback
        public const string set_Playback_PR_ON = ":SPP1#"; // returns "1", enable Periodic Error Correction playback
        public string set_Custom_Tracking_Rate = ":RR"; // +"nnnnn#"=0.1000 to 1.9000 no decimal, returns "1"
        public const string mov_Manual_DEC_Minus = ":mn#"; // start move manually DEC- direction until next stop command
        public const string mov_Manual_DEC_Plus = ":ms#"; // start move manually DEC+ direction until next stop command
        public const string mov_Manual_RA_Minus = ":me#"; // start move manually RA- direction until next stop command
        public const string mov_Manual_RA_Plus = ":mw#"; // start move manually RA+ direction until next stop command
        public const string mov_Manual_RA_Stop = ":qR#"; // stop moving manually RA only, returns "1"
        public const string mov_Manual_DEC_Stop = ":qD#"; // stop moving manually DEC only, returns "1"
        //*** CEM Mount Position commands
        public const string Calibrate_Mount = ":CM#"; // Calibrate Mount, returns "1"
        public const string Query_Num_Aval_Positions = ":QAP#"; // returns "0#", "1#", "2#"
        public string set_Calibrate_RA = ":SRA"; // +"TTTTTTTTT#"= .01 Arcseconds to most recent defined RA, returns "1"
        public string set_Calibrate_DEC = ":Sd"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined DEC, returns "1"
        public string set_Calibrate_Alt = ":Sa"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined Altitude, returns "1"
        public string set_Calibrate_Aa = ":Sz"; // +"sTTTTTTTT#"= signed -+.01 Arcseconds to most recent defined Azimuth, returns "1"
        public const string set_Zero_Position = ":SZP#"; // set current poosition as ZERO Position, returns "1"
        public string set_AZ_Park_Position = ":SPA"; // +"TTTTTTTTT#= .01 Arcseconds, returns "1"
        public string set_Alt_Park_Position = ":SPH"; // +"TTTTTTTTT#= .01 Arcseconds, returns "1"
        //*** CEM Mount Models
        public string[,] Mount_Model = { {"0026", "0027", "0028", "0029", "0040", "0041", "0043", "0044", "0070", "0071", "0120", "0121", "0122"},
            {"CEM26", "CEM26-EC", "GEM28", "GEM28-EC", "CEM40(G)", "CEM40(G)-EC", "GEM45(G)", "GEM45(G)-EC", "CEM70(G)", "CEM70(G)-EC", "CEM120", "CEM120-EC", "CEM120-EC2"} };

        public const string NO_PORTS_MESSAGE = "No COM ports found";
        public SerialPort MountComPort;
        private static string COMindata;

        public MainControlForm()
        {
            InitializeComponent();

            // Disable Connect Button
            ButtonCOMPortConnect.Enabled = false;

            // Get a list of Comports
            // Clear any existing entries
            ComboBoxComPort.Items.Clear();
            // Get Avaliable ComPorts
            foreach (string ComString in SerialPort.GetPortNames())
                ComboBoxComPort.Items.Add(ComString);
        }

 
        private void ButtonEXIT_Click(object sender, EventArgs e)
        {
            if (MountComPort != null) 
                MountComPort.Close();
            Close();
        }

        private void ComboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com_string;
            //int atimer, initime;

            com_string = ComboBoxComPort.Text;
            
            try
            {
                // Set mount COM port parameters
                MountComPort = new SerialPort(com_string, 11520, Parity.None, 8, StopBits.One);
                // Set mount read & write timeout values
                MountComPort.WriteTimeout = 500;
                MountComPort.ReadTimeout = 500;
                // Open mount COM port
                MountComPort.Open();
                // Send for mount infomation
                MountComPort.Write(":MountInfo#");
                COMindata = MountComPort.ReadExisting();

            }
            catch (TimeoutException)
            {
                //TEST.Text = "COM Port Timedout, Try another port.";
                throw;
            }

            MountComPort.Close();
            
            TEST.Text = com_string;

        }
    }
}
