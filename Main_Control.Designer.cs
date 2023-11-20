namespace Optron_Mount_Control
{
    partial class MainControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControlForm));
            this.ComboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCOMPortConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMountGPS_Time = new System.Windows.Forms.GroupBox();
            this.textBoxTimeLocal = new System.Windows.Forms.TextBox();
            this.textBoxTimeUTC = new System.Windows.Forms.TextBox();
            this.checkBoxDayLightSavingsOnOff = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxUTC_Offset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMountPointingPosition = new System.Windows.Forms.GroupBox();
            this.labelAzimuth = new System.Windows.Forms.Label();
            this.labelDEC = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelRA = new System.Windows.Forms.Label();
            this.groupBoxSettings_Limits = new System.Windows.Forms.GroupBox();
            this.textBoxDEC_GuidingRate = new System.Windows.Forms.TextBox();
            this.textBoxRA_GuidingRate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxCustomeTrackingRate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxTrackingRateType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxMeridianFlipOnOff = new System.Windows.Forms.CheckBox();
            this.comboBoxMaxSlewingRate = new System.Windows.Forms.ComboBox();
            this.textBoxMeridianFlipDegrees = new System.Windows.Forms.TextBox();
            this.textBoxAltitudeLimitMIN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxMountParking = new System.Windows.Forms.GroupBox();
            this.buttonUnparkMount = new System.Windows.Forms.Button();
            this.buttonParkMount = new System.Windows.Forms.Button();
            this.buttonSetParkingPosition = new System.Windows.Forms.Button();
            this.textBoxMountParkingAzimuth = new System.Windows.Forms.TextBox();
            this.textBoxMountParkingAltitude = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxMountZeroPosition = new System.Windows.Forms.GroupBox();
            this.buttonSetZeroPosition = new System.Windows.Forms.Button();
            this.buttonGotoZeroPosition = new System.Windows.Forms.Button();
            this.buttonSearchMountZero = new System.Windows.Forms.Button();
            this.groupBoxMountPad = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxManualMovingRate = new System.Windows.Forms.ComboBox();
            this.buttonAllStop = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.groupBoxMountTracking = new System.Windows.Forms.GroupBox();
            this.buttonTrackingOnOff = new System.Windows.Forms.Button();
            this.ButtonEXIT = new System.Windows.Forms.Button();
            this.buttonConnectComPort = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TEST = new System.Windows.Forms.Label();
            this.groupBoxMountGPS_Time.SuspendLayout();
            this.groupBoxMountPointingPosition.SuspendLayout();
            this.groupBoxSettings_Limits.SuspendLayout();
            this.groupBoxMountParking.SuspendLayout();
            this.groupBoxMountZeroPosition.SuspendLayout();
            this.groupBoxMountPad.SuspendLayout();
            this.groupBoxMountTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxComPort
            // 
            this.ComboBoxComPort.BackColor = System.Drawing.Color.Firebrick;
            this.ComboBoxComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxComPort.ForeColor = System.Drawing.Color.Yellow;
            this.ComboBoxComPort.FormattingEnabled = true;
            this.ComboBoxComPort.Location = new System.Drawing.Point(103, 13);
            this.ComboBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxComPort.MaxDropDownItems = 3;
            this.ComboBoxComPort.Name = "ComboBoxComPort";
            this.ComboBoxComPort.Size = new System.Drawing.Size(78, 23);
            this.ComboBoxComPort.TabIndex = 0;
            this.ComboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // ButtonCOMPortConnect
            // 
            this.ButtonCOMPortConnect.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonCOMPortConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonCOMPortConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCOMPortConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCOMPortConnect.Location = new System.Drawing.Point(189, 9);
            this.ButtonCOMPortConnect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCOMPortConnect.Name = "ButtonCOMPortConnect";
            this.ButtonCOMPortConnect.Size = new System.Drawing.Size(116, 31);
            this.ButtonCOMPortConnect.TabIndex = 2;
            this.ButtonCOMPortConnect.Text = "Connect";
            this.ButtonCOMPortConnect.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude";
            // 
            // groupBoxMountGPS_Time
            // 
            this.groupBoxMountGPS_Time.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountGPS_Time.Controls.Add(this.textBoxTimeLocal);
            this.groupBoxMountGPS_Time.Controls.Add(this.textBoxTimeUTC);
            this.groupBoxMountGPS_Time.Controls.Add(this.checkBoxDayLightSavingsOnOff);
            this.groupBoxMountGPS_Time.Controls.Add(this.label13);
            this.groupBoxMountGPS_Time.Controls.Add(this.textBoxLatitude);
            this.groupBoxMountGPS_Time.Controls.Add(this.textBoxLongitude);
            this.groupBoxMountGPS_Time.Controls.Add(this.textBoxUTC_Offset);
            this.groupBoxMountGPS_Time.Controls.Add(this.label3);
            this.groupBoxMountGPS_Time.Controls.Add(this.label2);
            this.groupBoxMountGPS_Time.Controls.Add(this.label9);
            this.groupBoxMountGPS_Time.Controls.Add(this.label8);
            this.groupBoxMountGPS_Time.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountGPS_Time.Location = new System.Drawing.Point(13, 47);
            this.groupBoxMountGPS_Time.Name = "groupBoxMountGPS_Time";
            this.groupBoxMountGPS_Time.Size = new System.Drawing.Size(352, 104);
            this.groupBoxMountGPS_Time.TabIndex = 5;
            this.groupBoxMountGPS_Time.TabStop = false;
            this.groupBoxMountGPS_Time.Text = "Mount GPS and TIME";
            // 
            // textBoxTimeLocal
            // 
            this.textBoxTimeLocal.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxTimeLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimeLocal.ForeColor = System.Drawing.Color.White;
            this.textBoxTimeLocal.Location = new System.Drawing.Point(229, 48);
            this.textBoxTimeLocal.Name = "textBoxTimeLocal";
            this.textBoxTimeLocal.Size = new System.Drawing.Size(75, 21);
            this.textBoxTimeLocal.TabIndex = 19;
            this.textBoxTimeLocal.Text = "HH:MM:SS";
            // 
            // textBoxTimeUTC
            // 
            this.textBoxTimeUTC.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxTimeUTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimeUTC.ForeColor = System.Drawing.Color.White;
            this.textBoxTimeUTC.Location = new System.Drawing.Point(63, 46);
            this.textBoxTimeUTC.Name = "textBoxTimeUTC";
            this.textBoxTimeUTC.Size = new System.Drawing.Size(75, 21);
            this.textBoxTimeUTC.TabIndex = 18;
            this.textBoxTimeUTC.Text = "HH:MM:SS";
            // 
            // checkBoxDayLightSavingsOnOff
            // 
            this.checkBoxDayLightSavingsOnOff.AutoSize = true;
            this.checkBoxDayLightSavingsOnOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDayLightSavingsOnOff.Location = new System.Drawing.Point(206, 73);
            this.checkBoxDayLightSavingsOnOff.Name = "checkBoxDayLightSavingsOnOff";
            this.checkBoxDayLightSavingsOnOff.Size = new System.Drawing.Size(123, 19);
            this.checkBoxDayLightSavingsOnOff.TabIndex = 17;
            this.checkBoxDayLightSavingsOnOff.Text = "Day Light Savings";
            this.checkBoxDayLightSavingsOnOff.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "UTC Offset for Local Time";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.BackColor = System.Drawing.Color.Maroon;
            this.textBoxLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLatitude.ForeColor = System.Drawing.Color.White;
            this.textBoxLatitude.Location = new System.Drawing.Point(63, 20);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(99, 21);
            this.textBoxLatitude.TabIndex = 14;
            this.textBoxLatitude.Text = "DD:MM:SS.SS";
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLongitude.ForeColor = System.Drawing.Color.White;
            this.textBoxLongitude.Location = new System.Drawing.Point(229, 20);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(111, 21);
            this.textBoxLongitude.TabIndex = 13;
            this.textBoxLongitude.Text = "DDD:MM:SS.SS";
            // 
            // textBoxUTC_Offset
            // 
            this.textBoxUTC_Offset.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxUTC_Offset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUTC_Offset.ForeColor = System.Drawing.Color.White;
            this.textBoxUTC_Offset.Location = new System.Drawing.Point(158, 72);
            this.textBoxUTC_Offset.Name = "textBoxUTC_Offset";
            this.textBoxUTC_Offset.Size = new System.Drawing.Size(36, 21);
            this.textBoxUTC_Offset.TabIndex = 12;
            this.textBoxUTC_Offset.Text = "-360";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Local";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "UTC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "R. A.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Altitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Azimuth";
            // 
            // groupBoxMountPointingPosition
            // 
            this.groupBoxMountPointingPosition.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountPointingPosition.Controls.Add(this.labelAzimuth);
            this.groupBoxMountPointingPosition.Controls.Add(this.labelDEC);
            this.groupBoxMountPointingPosition.Controls.Add(this.labelAltitude);
            this.groupBoxMountPointingPosition.Controls.Add(this.labelRA);
            this.groupBoxMountPointingPosition.Controls.Add(this.label5);
            this.groupBoxMountPointingPosition.Controls.Add(this.label4);
            this.groupBoxMountPointingPosition.Controls.Add(this.label6);
            this.groupBoxMountPointingPosition.Controls.Add(this.label7);
            this.groupBoxMountPointingPosition.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountPointingPosition.Location = new System.Drawing.Point(13, 157);
            this.groupBoxMountPointingPosition.Name = "groupBoxMountPointingPosition";
            this.groupBoxMountPointingPosition.Size = new System.Drawing.Size(352, 82);
            this.groupBoxMountPointingPosition.TabIndex = 10;
            this.groupBoxMountPointingPosition.TabStop = false;
            this.groupBoxMountPointingPosition.Text = "Mount Pointing Position";
            // 
            // labelAzimuth
            // 
            this.labelAzimuth.AutoSize = true;
            this.labelAzimuth.BackColor = System.Drawing.Color.DarkRed;
            this.labelAzimuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAzimuth.Location = new System.Drawing.Point(230, 27);
            this.labelAzimuth.Name = "labelAzimuth";
            this.labelAzimuth.Size = new System.Drawing.Size(99, 17);
            this.labelAzimuth.TabIndex = 14;
            this.labelAzimuth.Text = "DDD:MM:SS.SS";
            // 
            // labelDEC
            // 
            this.labelDEC.AutoSize = true;
            this.labelDEC.BackColor = System.Drawing.Color.DarkRed;
            this.labelDEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDEC.Location = new System.Drawing.Point(230, 51);
            this.labelDEC.Name = "labelDEC";
            this.labelDEC.Size = new System.Drawing.Size(90, 17);
            this.labelDEC.TabIndex = 13;
            this.labelDEC.Text = "DD:MM:SS.SS";
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.BackColor = System.Drawing.Color.DarkRed;
            this.labelAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAltitude.Location = new System.Drawing.Point(72, 27);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(90, 17);
            this.labelAltitude.TabIndex = 12;
            this.labelAltitude.Text = "DD:MM:SS.SS";
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.BackColor = System.Drawing.Color.DarkRed;
            this.labelRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRA.Location = new System.Drawing.Point(72, 51);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(90, 17);
            this.labelRA.TabIndex = 12;
            this.labelRA.Text = "HH:MM:SS.SS";
            // 
            // groupBoxSettings_Limits
            // 
            this.groupBoxSettings_Limits.BackColor = System.Drawing.Color.Black;
            this.groupBoxSettings_Limits.Controls.Add(this.textBoxDEC_GuidingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.textBoxRA_GuidingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.label20);
            this.groupBoxSettings_Limits.Controls.Add(this.label19);
            this.groupBoxSettings_Limits.Controls.Add(this.textBoxCustomeTrackingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.label18);
            this.groupBoxSettings_Limits.Controls.Add(this.comboBoxTrackingRateType);
            this.groupBoxSettings_Limits.Controls.Add(this.label12);
            this.groupBoxSettings_Limits.Controls.Add(this.checkBoxMeridianFlipOnOff);
            this.groupBoxSettings_Limits.Controls.Add(this.comboBoxMaxSlewingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.textBoxMeridianFlipDegrees);
            this.groupBoxSettings_Limits.Controls.Add(this.textBoxAltitudeLimitMIN);
            this.groupBoxSettings_Limits.Controls.Add(this.label11);
            this.groupBoxSettings_Limits.Controls.Add(this.label10);
            this.groupBoxSettings_Limits.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxSettings_Limits.Location = new System.Drawing.Point(13, 245);
            this.groupBoxSettings_Limits.Name = "groupBoxSettings_Limits";
            this.groupBoxSettings_Limits.Size = new System.Drawing.Size(353, 164);
            this.groupBoxSettings_Limits.TabIndex = 11;
            this.groupBoxSettings_Limits.TabStop = false;
            this.groupBoxSettings_Limits.Text = "Mount Settings and Limits";
            // 
            // textBoxDEC_GuidingRate
            // 
            this.textBoxDEC_GuidingRate.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxDEC_GuidingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDEC_GuidingRate.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDEC_GuidingRate.Location = new System.Drawing.Point(294, 51);
            this.textBoxDEC_GuidingRate.Name = "textBoxDEC_GuidingRate";
            this.textBoxDEC_GuidingRate.Size = new System.Drawing.Size(37, 21);
            this.textBoxDEC_GuidingRate.TabIndex = 15;
            this.textBoxDEC_GuidingRate.Text = "0.50";
            // 
            // textBoxRA_GuidingRate
            // 
            this.textBoxRA_GuidingRate.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxRA_GuidingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRA_GuidingRate.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRA_GuidingRate.Location = new System.Drawing.Point(294, 24);
            this.textBoxRA_GuidingRate.Name = "textBoxRA_GuidingRate";
            this.textBoxRA_GuidingRate.Size = new System.Drawing.Size(37, 21);
            this.textBoxRA_GuidingRate.TabIndex = 14;
            this.textBoxRA_GuidingRate.Text = "0.50";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(195, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 15);
            this.label20.TabIndex = 13;
            this.label20.Text = "DEC Guide Rate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(204, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "RA Guide Rate";
            // 
            // textBoxCustomeTrackingRate
            // 
            this.textBoxCustomeTrackingRate.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxCustomeTrackingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomeTrackingRate.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxCustomeTrackingRate.Location = new System.Drawing.Point(144, 130);
            this.textBoxCustomeTrackingRate.Name = "textBoxCustomeTrackingRate";
            this.textBoxCustomeTrackingRate.Size = new System.Drawing.Size(51, 21);
            this.textBoxCustomeTrackingRate.TabIndex = 11;
            this.textBoxCustomeTrackingRate.Text = "1.0000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 15);
            this.label18.TabIndex = 10;
            this.label18.Text = "Custom Tracking Rate";
            // 
            // comboBoxTrackingRateType
            // 
            this.comboBoxTrackingRateType.BackColor = System.Drawing.Color.Red;
            this.comboBoxTrackingRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTrackingRateType.ForeColor = System.Drawing.Color.Yellow;
            this.comboBoxTrackingRateType.FormattingEnabled = true;
            this.comboBoxTrackingRateType.ItemHeight = 15;
            this.comboBoxTrackingRateType.Items.AddRange(new object[] {
            "Sidereal",
            "Lunar",
            "Solar",
            "King",
            "Custom"});
            this.comboBoxTrackingRateType.Location = new System.Drawing.Point(121, 101);
            this.comboBoxTrackingRateType.MaxDropDownItems = 5;
            this.comboBoxTrackingRateType.Name = "comboBoxTrackingRateType";
            this.comboBoxTrackingRateType.Size = new System.Drawing.Size(89, 23);
            this.comboBoxTrackingRateType.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tracking Rate";
            // 
            // checkBoxMeridianFlipOnOff
            // 
            this.checkBoxMeridianFlipOnOff.AutoSize = true;
            this.checkBoxMeridianFlipOnOff.Location = new System.Drawing.Point(20, 78);
            this.checkBoxMeridianFlipOnOff.Name = "checkBoxMeridianFlipOnOff";
            this.checkBoxMeridianFlipOnOff.Size = new System.Drawing.Size(98, 19);
            this.checkBoxMeridianFlipOnOff.TabIndex = 7;
            this.checkBoxMeridianFlipOnOff.Text = "Meridian Flip";
            this.checkBoxMeridianFlipOnOff.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaxSlewingRate
            // 
            this.comboBoxMaxSlewingRate.BackColor = System.Drawing.Color.Red;
            this.comboBoxMaxSlewingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaxSlewingRate.ForeColor = System.Drawing.Color.Yellow;
            this.comboBoxMaxSlewingRate.FormattingEnabled = true;
            this.comboBoxMaxSlewingRate.ItemHeight = 15;
            this.comboBoxMaxSlewingRate.Items.AddRange(new object[] {
            "256x",
            "512x",
            "MAX"});
            this.comboBoxMaxSlewingRate.Location = new System.Drawing.Point(121, 24);
            this.comboBoxMaxSlewingRate.MaxDropDownItems = 3;
            this.comboBoxMaxSlewingRate.Name = "comboBoxMaxSlewingRate";
            this.comboBoxMaxSlewingRate.Size = new System.Drawing.Size(63, 23);
            this.comboBoxMaxSlewingRate.TabIndex = 6;
            // 
            // textBoxMeridianFlipDegrees
            // 
            this.textBoxMeridianFlipDegrees.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxMeridianFlipDegrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMeridianFlipDegrees.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxMeridianFlipDegrees.Location = new System.Drawing.Point(122, 76);
            this.textBoxMeridianFlipDegrees.Name = "textBoxMeridianFlipDegrees";
            this.textBoxMeridianFlipDegrees.Size = new System.Drawing.Size(30, 21);
            this.textBoxMeridianFlipDegrees.TabIndex = 5;
            this.textBoxMeridianFlipDegrees.Text = "10";
            // 
            // textBoxAltitudeLimitMIN
            // 
            this.textBoxAltitudeLimitMIN.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxAltitudeLimitMIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAltitudeLimitMIN.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxAltitudeLimitMIN.Location = new System.Drawing.Point(122, 49);
            this.textBoxAltitudeLimitMIN.Name = "textBoxAltitudeLimitMIN";
            this.textBoxAltitudeLimitMIN.Size = new System.Drawing.Size(30, 21);
            this.textBoxAltitudeLimitMIN.TabIndex = 4;
            this.textBoxAltitudeLimitMIN.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Altitude MIN Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "MAX Slewing Rate";
            // 
            // groupBoxMountParking
            // 
            this.groupBoxMountParking.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountParking.Controls.Add(this.buttonUnparkMount);
            this.groupBoxMountParking.Controls.Add(this.buttonParkMount);
            this.groupBoxMountParking.Controls.Add(this.buttonSetParkingPosition);
            this.groupBoxMountParking.Controls.Add(this.textBoxMountParkingAzimuth);
            this.groupBoxMountParking.Controls.Add(this.textBoxMountParkingAltitude);
            this.groupBoxMountParking.Controls.Add(this.label22);
            this.groupBoxMountParking.Controls.Add(this.label21);
            this.groupBoxMountParking.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountParking.Location = new System.Drawing.Point(13, 415);
            this.groupBoxMountParking.Name = "groupBoxMountParking";
            this.groupBoxMountParking.Size = new System.Drawing.Size(353, 98);
            this.groupBoxMountParking.TabIndex = 12;
            this.groupBoxMountParking.TabStop = false;
            this.groupBoxMountParking.Text = "Mount Parking";
            // 
            // buttonUnparkMount
            // 
            this.buttonUnparkMount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUnparkMount.BackColor = System.Drawing.Color.Maroon;
            this.buttonUnparkMount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUnparkMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnparkMount.Location = new System.Drawing.Point(237, 55);
            this.buttonUnparkMount.Name = "buttonUnparkMount";
            this.buttonUnparkMount.Size = new System.Drawing.Size(104, 28);
            this.buttonUnparkMount.TabIndex = 6;
            this.buttonUnparkMount.Text = "Unpark Mount";
            this.buttonUnparkMount.UseVisualStyleBackColor = false;
            // 
            // buttonParkMount
            // 
            this.buttonParkMount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonParkMount.BackColor = System.Drawing.Color.Maroon;
            this.buttonParkMount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonParkMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParkMount.Location = new System.Drawing.Point(138, 55);
            this.buttonParkMount.Name = "buttonParkMount";
            this.buttonParkMount.Size = new System.Drawing.Size(91, 28);
            this.buttonParkMount.TabIndex = 5;
            this.buttonParkMount.Text = "Park Mount";
            this.buttonParkMount.UseVisualStyleBackColor = false;
            // 
            // buttonSetParkingPosition
            // 
            this.buttonSetParkingPosition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSetParkingPosition.BackColor = System.Drawing.Color.Maroon;
            this.buttonSetParkingPosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSetParkingPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetParkingPosition.Location = new System.Drawing.Point(12, 55);
            this.buttonSetParkingPosition.Name = "buttonSetParkingPosition";
            this.buttonSetParkingPosition.Size = new System.Drawing.Size(114, 28);
            this.buttonSetParkingPosition.TabIndex = 4;
            this.buttonSetParkingPosition.Text = "Set Park Position";
            this.buttonSetParkingPosition.UseVisualStyleBackColor = false;
            // 
            // textBoxMountParkingAzimuth
            // 
            this.textBoxMountParkingAzimuth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxMountParkingAzimuth.BackColor = System.Drawing.Color.Red;
            this.textBoxMountParkingAzimuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMountParkingAzimuth.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxMountParkingAzimuth.Location = new System.Drawing.Point(220, 28);
            this.textBoxMountParkingAzimuth.Name = "textBoxMountParkingAzimuth";
            this.textBoxMountParkingAzimuth.Size = new System.Drawing.Size(72, 21);
            this.textBoxMountParkingAzimuth.TabIndex = 3;
            this.textBoxMountParkingAzimuth.Text = "s000.0000";
            // 
            // textBoxMountParkingAltitude
            // 
            this.textBoxMountParkingAltitude.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxMountParkingAltitude.BackColor = System.Drawing.Color.Red;
            this.textBoxMountParkingAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMountParkingAltitude.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxMountParkingAltitude.Location = new System.Drawing.Point(61, 28);
            this.textBoxMountParkingAltitude.Name = "textBoxMountParkingAltitude";
            this.textBoxMountParkingAltitude.Size = new System.Drawing.Size(65, 21);
            this.textBoxMountParkingAltitude.TabIndex = 2;
            this.textBoxMountParkingAltitude.Text = "s00.0000";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(163, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Azimuth";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Altitude";
            // 
            // groupBoxMountZeroPosition
            // 
            this.groupBoxMountZeroPosition.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonSetZeroPosition);
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonGotoZeroPosition);
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonSearchMountZero);
            this.groupBoxMountZeroPosition.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountZeroPosition.Location = new System.Drawing.Point(372, 415);
            this.groupBoxMountZeroPosition.Name = "groupBoxMountZeroPosition";
            this.groupBoxMountZeroPosition.Size = new System.Drawing.Size(269, 98);
            this.groupBoxMountZeroPosition.TabIndex = 13;
            this.groupBoxMountZeroPosition.TabStop = false;
            this.groupBoxMountZeroPosition.Text = "Mount Zero Position";
            // 
            // buttonSetZeroPosition
            // 
            this.buttonSetZeroPosition.BackColor = System.Drawing.Color.Maroon;
            this.buttonSetZeroPosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSetZeroPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetZeroPosition.Location = new System.Drawing.Point(6, 59);
            this.buttonSetZeroPosition.Name = "buttonSetZeroPosition";
            this.buttonSetZeroPosition.Size = new System.Drawing.Size(126, 29);
            this.buttonSetZeroPosition.TabIndex = 2;
            this.buttonSetZeroPosition.Text = "Set Zero Position";
            this.buttonSetZeroPosition.UseVisualStyleBackColor = false;
            // 
            // buttonGotoZeroPosition
            // 
            this.buttonGotoZeroPosition.BackColor = System.Drawing.Color.Maroon;
            this.buttonGotoZeroPosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGotoZeroPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoZeroPosition.Location = new System.Drawing.Point(138, 24);
            this.buttonGotoZeroPosition.Name = "buttonGotoZeroPosition";
            this.buttonGotoZeroPosition.Size = new System.Drawing.Size(121, 29);
            this.buttonGotoZeroPosition.TabIndex = 1;
            this.buttonGotoZeroPosition.Text = "Goto Zero Position";
            this.buttonGotoZeroPosition.UseVisualStyleBackColor = false;
            // 
            // buttonSearchMountZero
            // 
            this.buttonSearchMountZero.BackColor = System.Drawing.Color.Maroon;
            this.buttonSearchMountZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearchMountZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMountZero.Location = new System.Drawing.Point(6, 24);
            this.buttonSearchMountZero.Name = "buttonSearchMountZero";
            this.buttonSearchMountZero.Size = new System.Drawing.Size(126, 29);
            this.buttonSearchMountZero.TabIndex = 0;
            this.buttonSearchMountZero.Text = "Search Mount Zero";
            this.buttonSearchMountZero.UseVisualStyleBackColor = false;
            // 
            // groupBoxMountPad
            // 
            this.groupBoxMountPad.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountPad.Controls.Add(this.label23);
            this.groupBoxMountPad.Controls.Add(this.comboBoxManualMovingRate);
            this.groupBoxMountPad.Controls.Add(this.buttonAllStop);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveDown);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveRight);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveLeft);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveUp);
            this.groupBoxMountPad.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountPad.Location = new System.Drawing.Point(371, 47);
            this.groupBoxMountPad.Name = "groupBoxMountPad";
            this.groupBoxMountPad.Size = new System.Drawing.Size(270, 295);
            this.groupBoxMountPad.TabIndex = 14;
            this.groupBoxMountPad.TabStop = false;
            this.groupBoxMountPad.Text = "Mount Pad";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Manual Moving Rate";
            // 
            // comboBoxManualMovingRate
            // 
            this.comboBoxManualMovingRate.BackColor = System.Drawing.Color.Red;
            this.comboBoxManualMovingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManualMovingRate.ForeColor = System.Drawing.Color.Yellow;
            this.comboBoxManualMovingRate.FormattingEnabled = true;
            this.comboBoxManualMovingRate.Items.AddRange(new object[] {
            "1x",
            "2x",
            "8x",
            "16x",
            "64x",
            "128x",
            "256x",
            "512x",
            "MAX"});
            this.comboBoxManualMovingRate.Location = new System.Drawing.Point(182, 19);
            this.comboBoxManualMovingRate.MaxDropDownItems = 9;
            this.comboBoxManualMovingRate.Name = "comboBoxManualMovingRate";
            this.comboBoxManualMovingRate.Size = new System.Drawing.Size(73, 23);
            this.comboBoxManualMovingRate.TabIndex = 13;
            // 
            // buttonAllStop
            // 
            this.buttonAllStop.BackColor = System.Drawing.Color.Red;
            this.buttonAllStop.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonAllStop.FlatAppearance.BorderSize = 2;
            this.buttonAllStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonAllStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonAllStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllStop.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAllStop.Location = new System.Drawing.Point(101, 129);
            this.buttonAllStop.Name = "buttonAllStop";
            this.buttonAllStop.Size = new System.Drawing.Size(75, 75);
            this.buttonAllStop.TabIndex = 12;
            this.buttonAllStop.Text = "STOP";
            this.buttonAllStop.UseVisualStyleBackColor = false;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.BackColor = System.Drawing.Color.DarkRed;
            this.buttonMoveDown.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMoveDown.FlatAppearance.BorderSize = 2;
            this.buttonMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveDown.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMoveDown.Image = global::iOptron_Mount_Control.Properties.Resources.Arrow_Down_TC;
            this.buttonMoveDown.Location = new System.Drawing.Point(101, 210);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 75);
            this.buttonMoveDown.TabIndex = 3;
            this.buttonMoveDown.UseVisualStyleBackColor = false;
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackColor = System.Drawing.Color.DarkRed;
            this.buttonMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMoveRight.FlatAppearance.BorderSize = 2;
            this.buttonMoveRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonMoveRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveRight.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMoveRight.Image = global::iOptron_Mount_Control.Properties.Resources.Arrow_Right_TC;
            this.buttonMoveRight.Location = new System.Drawing.Point(182, 129);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(75, 75);
            this.buttonMoveRight.TabIndex = 2;
            this.buttonMoveRight.UseVisualStyleBackColor = false;
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackColor = System.Drawing.Color.DarkRed;
            this.buttonMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMoveLeft.FlatAppearance.BorderSize = 2;
            this.buttonMoveLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonMoveLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveLeft.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMoveLeft.Image = global::iOptron_Mount_Control.Properties.Resources.Arrow_Left_TC;
            this.buttonMoveLeft.Location = new System.Drawing.Point(20, 129);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(75, 75);
            this.buttonMoveLeft.TabIndex = 1;
            this.buttonMoveLeft.UseVisualStyleBackColor = false;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMoveUp.FlatAppearance.BorderSize = 2;
            this.buttonMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveUp.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMoveUp.Image = global::iOptron_Mount_Control.Properties.Resources.Arrow_Up_TC;
            this.buttonMoveUp.Location = new System.Drawing.Point(101, 48);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 75);
            this.buttonMoveUp.TabIndex = 0;
            this.buttonMoveUp.UseVisualStyleBackColor = false;
            // 
            // groupBoxMountTracking
            // 
            this.groupBoxMountTracking.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountTracking.Controls.Add(this.buttonTrackingOnOff);
            this.groupBoxMountTracking.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountTracking.Location = new System.Drawing.Point(371, 348);
            this.groupBoxMountTracking.Name = "groupBoxMountTracking";
            this.groupBoxMountTracking.Size = new System.Drawing.Size(270, 61);
            this.groupBoxMountTracking.TabIndex = 16;
            this.groupBoxMountTracking.TabStop = false;
            this.groupBoxMountTracking.Text = "Mount Tracking";
            // 
            // buttonTrackingOnOff
            // 
            this.buttonTrackingOnOff.BackColor = System.Drawing.Color.DarkRed;
            this.buttonTrackingOnOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTrackingOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrackingOnOff.Location = new System.Drawing.Point(139, 24);
            this.buttonTrackingOnOff.Name = "buttonTrackingOnOff";
            this.buttonTrackingOnOff.Size = new System.Drawing.Size(121, 25);
            this.buttonTrackingOnOff.TabIndex = 16;
            this.buttonTrackingOnOff.Text = "Turn Tracking ON";
            this.buttonTrackingOnOff.UseVisualStyleBackColor = false;
            // 
            // ButtonEXIT
            // 
            this.ButtonEXIT.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonEXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEXIT.Location = new System.Drawing.Point(567, 12);
            this.ButtonEXIT.Name = "ButtonEXIT";
            this.ButtonEXIT.Size = new System.Drawing.Size(75, 28);
            this.ButtonEXIT.TabIndex = 17;
            this.ButtonEXIT.Text = "EXIT";
            this.ButtonEXIT.UseVisualStyleBackColor = false;
            this.ButtonEXIT.Click += new System.EventHandler(this.ButtonEXIT_Click);
            // 
            // buttonConnectComPort
            // 
            this.buttonConnectComPort.BackColor = System.Drawing.Color.DarkRed;
            this.buttonConnectComPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonConnectComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectComPort.Location = new System.Drawing.Point(189, 9);
            this.buttonConnectComPort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectComPort.Name = "buttonConnectComPort";
            this.buttonConnectComPort.Size = new System.Drawing.Size(116, 31);
            this.buttonConnectComPort.TabIndex = 2;
            this.buttonConnectComPort.Text = "Connect";
            this.buttonConnectComPort.UseVisualStyleBackColor = false;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExitApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitApp.Location = new System.Drawing.Point(567, 12);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(75, 28);
            this.buttonExitApp.TabIndex = 17;
            this.buttonExitApp.Text = "EXIT";
            this.buttonExitApp.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Maroon;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(63, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "DD:MM:SS.SS";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkRed;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(229, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "DDD:MM:SS.SS";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkRed;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(63, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "HH:MM:SS.S";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(158, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "-360";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iOptron_Mount_Control.Properties.Resources.cem70a_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TEST
            // 
            this.TEST.AutoSize = true;
            this.TEST.BackColor = System.Drawing.Color.Black;
            this.TEST.Location = new System.Drawing.Point(345, 14);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(37, 15);
            this.TEST.TabIndex = 19;
            this.TEST.Text = "TEST";
            // 
            // MainControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(654, 527);
            this.ControlBox = false;
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonEXIT);
            this.Controls.Add(this.groupBoxMountTracking);
            this.Controls.Add(this.groupBoxMountPad);
            this.Controls.Add(this.groupBoxMountZeroPosition);
            this.Controls.Add(this.groupBoxMountParking);
            this.Controls.Add(this.groupBoxSettings_Limits);
            this.Controls.Add(this.ComboBoxComPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxMountPointingPosition);
            this.Controls.Add(this.ButtonCOMPortConnect);
            this.Controls.Add(this.groupBoxMountGPS_Time);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainControlForm";
            this.Text = "iOptron Mount";
            this.groupBoxMountGPS_Time.ResumeLayout(false);
            this.groupBoxMountGPS_Time.PerformLayout();
            this.groupBoxMountPointingPosition.ResumeLayout(false);
            this.groupBoxMountPointingPosition.PerformLayout();
            this.groupBoxSettings_Limits.ResumeLayout(false);
            this.groupBoxSettings_Limits.PerformLayout();
            this.groupBoxMountParking.ResumeLayout(false);
            this.groupBoxMountParking.PerformLayout();
            this.groupBoxMountZeroPosition.ResumeLayout(false);
            this.groupBoxMountPad.ResumeLayout(false);
            this.groupBoxMountPad.PerformLayout();
            this.groupBoxMountTracking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCOMPortConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxMountGPS_Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxMountPointingPosition;
        private System.Windows.Forms.GroupBox groupBoxSettings_Limits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUTC_Offset;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.CheckBox checkBoxDayLightSavingsOnOff;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTimeUTC;
        private System.Windows.Forms.Label labelRA;
        private System.Windows.Forms.Label labelAzimuth;
        private System.Windows.Forms.Label labelDEC;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.TextBox textBoxMeridianFlipDegrees;
        private System.Windows.Forms.TextBox textBoxAltitudeLimitMIN;
        private System.Windows.Forms.ComboBox comboBoxMaxSlewingRate;
        private System.Windows.Forms.CheckBox checkBoxMeridianFlipOnOff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxTrackingRateType;
        private System.Windows.Forms.TextBox textBoxCustomeTrackingRate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDEC_GuidingRate;
        private System.Windows.Forms.TextBox textBoxRA_GuidingRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBoxMountParking;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxMountParkingAltitude;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonUnparkMount;
        private System.Windows.Forms.Button buttonParkMount;
        private System.Windows.Forms.Button buttonSetParkingPosition;
        private System.Windows.Forms.TextBox textBoxMountParkingAzimuth;
        private System.Windows.Forms.GroupBox groupBoxMountZeroPosition;
        private System.Windows.Forms.Button buttonSearchMountZero;
        private System.Windows.Forms.Button buttonGotoZeroPosition;
        private System.Windows.Forms.Button buttonSetZeroPosition;
        private System.Windows.Forms.GroupBox groupBoxMountPad;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonAllStop;
        private System.Windows.Forms.ComboBox comboBoxManualMovingRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBoxMountTracking;
        private System.Windows.Forms.Button buttonTrackingOnOff;
        private System.Windows.Forms.Button ButtonEXIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConnectComPort;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTimeLocal;
        private System.Windows.Forms.Label TEST;
    }
}

