namespace iOptron_Mount_Control
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControlForm));
            this.ComboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCOMPortConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMountGPS_Time = new System.Windows.Forms.GroupBox();
            this.GPS_status = new System.Windows.Forms.Label();
            this.labelLST = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTimeSource = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelTimeUTC = new System.Windows.Forms.Label();
            this.labelTimeLocal = new System.Windows.Forms.Label();
            this.labelUTC_Offset = new System.Windows.Forms.Label();
            this.checkBoxDayLightSavingsOnOff = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.labelDEC_GuidingRate = new System.Windows.Forms.Label();
            this.labelRA_GuidingRate = new System.Windows.Forms.Label();
            this.labelCustomeTrackingRate = new System.Windows.Forms.Label();
            this.labelAltitudeLimitMIN = new System.Windows.Forms.Label();
            this.labelMeridianFlipDegrees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxTrackingRate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxMeridianFlipOnOff = new System.Windows.Forms.CheckBox();
            this.comboBoxMaxSlewingRate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonResetPEC = new System.Windows.Forms.Button();
            this.groupBoxMountParking = new System.Windows.Forms.GroupBox();
            this.labelMountParkingAzimuth = new System.Windows.Forms.Label();
            this.labelMountParkingAltitude = new System.Windows.Forms.Label();
            this.buttonParkMount = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxMountZeroPosition = new System.Windows.Forms.GroupBox();
            this.labelMountZeroPosition = new System.Windows.Forms.Label();
            this.buttonSetNewZeroPosition = new System.Windows.Forms.Button();
            this.buttonGotoZeroPosition = new System.Windows.Forms.Button();
            this.buttonSearchMountZero = new System.Windows.Forms.Button();
            this.groupBoxMountPad = new System.Windows.Forms.GroupBox();
            this.labelMountSlewing = new System.Windows.Forms.Label();
            this.labelPierEAST = new System.Windows.Forms.Label();
            this.labelPierWEST = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxManualMovingRate = new System.Windows.Forms.ComboBox();
            this.buttonAllStop = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.groupBoxMountTracking = new System.Windows.Forms.GroupBox();
            this.DomeCtrlOnOffButton = new System.Windows.Forms.Button();
            this.buttonPeriodicErrorCorrection = new System.Windows.Forms.Button();
            this.buttonTrackingOnOff = new System.Windows.Forms.Button();
            this.ButtonEXIT = new System.Windows.Forms.Button();
            this.buttonConnectComPort = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MountComPort = new System.IO.Ports.SerialPort(this.components);
            this.timerMount = new System.Windows.Forms.Timer(this.components);
            this.buttonSlewToObject = new System.Windows.Forms.Button();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.groupBoxMountGPS_Time.SuspendLayout();
            this.groupBoxMountPointingPosition.SuspendLayout();
            this.groupBoxSettings_Limits.SuspendLayout();
            this.groupBoxMountParking.SuspendLayout();
            this.groupBoxMountZeroPosition.SuspendLayout();
            this.groupBoxMountPad.SuspendLayout();
            this.groupBoxMountTracking.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxComPort
            // 
            this.ComboBoxComPort.BackColor = System.Drawing.Color.Firebrick;
            this.ComboBoxComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxComPort.ForeColor = System.Drawing.Color.Yellow;
            this.ComboBoxComPort.FormattingEnabled = true;
            this.ComboBoxComPort.Location = new System.Drawing.Point(134, 14);
            this.ComboBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxComPort.MaxDropDownItems = 3;
            this.ComboBoxComPort.Name = "ComboBoxComPort";
            this.ComboBoxComPort.Size = new System.Drawing.Size(78, 24);
            this.ComboBoxComPort.TabIndex = 0;
            this.ComboBoxComPort.Text = "COM";
            this.ComboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // ButtonCOMPortConnect
            // 
            this.ButtonCOMPortConnect.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonCOMPortConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonCOMPortConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ButtonCOMPortConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCOMPortConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCOMPortConnect.Location = new System.Drawing.Point(225, 10);
            this.ButtonCOMPortConnect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCOMPortConnect.Name = "ButtonCOMPortConnect";
            this.ButtonCOMPortConnect.Size = new System.Drawing.Size(197, 31);
            this.ButtonCOMPortConnect.TabIndex = 2;
            this.ButtonCOMPortConnect.Text = "Connect";
            this.ButtonCOMPortConnect.UseVisualStyleBackColor = false;
            this.ButtonCOMPortConnect.Click += new System.EventHandler(this.ButtonCOMPortConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude";
            // 
            // groupBoxMountGPS_Time
            // 
            this.groupBoxMountGPS_Time.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountGPS_Time.Controls.Add(this.GPS_status);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelLST);
            this.groupBoxMountGPS_Time.Controls.Add(this.label15);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelTimeSource);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelLongitude);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelLatitude);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelTimeUTC);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelTimeLocal);
            this.groupBoxMountGPS_Time.Controls.Add(this.labelUTC_Offset);
            this.groupBoxMountGPS_Time.Controls.Add(this.checkBoxDayLightSavingsOnOff);
            this.groupBoxMountGPS_Time.Controls.Add(this.label13);
            this.groupBoxMountGPS_Time.Controls.Add(this.label3);
            this.groupBoxMountGPS_Time.Controls.Add(this.label2);
            this.groupBoxMountGPS_Time.Controls.Add(this.label9);
            this.groupBoxMountGPS_Time.Controls.Add(this.label8);
            this.groupBoxMountGPS_Time.Enabled = false;
            this.groupBoxMountGPS_Time.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountGPS_Time.Location = new System.Drawing.Point(13, 47);
            this.groupBoxMountGPS_Time.Name = "groupBoxMountGPS_Time";
            this.groupBoxMountGPS_Time.Size = new System.Drawing.Size(352, 141);
            this.groupBoxMountGPS_Time.TabIndex = 5;
            this.groupBoxMountGPS_Time.TabStop = false;
            this.groupBoxMountGPS_Time.Text = "Mount GPS and TIME";
            // 
            // GPS_status
            // 
            this.GPS_status.AutoSize = true;
            this.GPS_status.Location = new System.Drawing.Point(204, 74);
            this.GPS_status.Name = "GPS_status";
            this.GPS_status.Size = new System.Drawing.Size(69, 15);
            this.GPS_status.TabIndex = 22;
            this.GPS_status.Text = "GPS Status";
            // 
            // labelLST
            // 
            this.labelLST.AutoSize = true;
            this.labelLST.BackColor = System.Drawing.Color.DarkRed;
            this.labelLST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLST.ForeColor = System.Drawing.Color.White;
            this.labelLST.Location = new System.Drawing.Point(91, 72);
            this.labelLST.MinimumSize = new System.Drawing.Size(75, 21);
            this.labelLST.Name = "labelLST";
            this.labelLST.Size = new System.Drawing.Size(75, 21);
            this.labelLST.TabIndex = 21;
            this.labelLST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 74);
            this.label15.MinimumSize = new System.Drawing.Size(68, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "LST";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeSource
            // 
            this.labelTimeSource.AutoSize = true;
            this.labelTimeSource.Location = new System.Drawing.Point(21, 25);
            this.labelTimeSource.Name = "labelTimeSource";
            this.labelTimeSource.Size = new System.Drawing.Size(22, 15);
            this.labelTimeSource.TabIndex = 19;
            this.labelTimeSource.Text = ".....";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.BackColor = System.Drawing.Color.DarkRed;
            this.labelLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLongitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLongitude.ForeColor = System.Drawing.Color.White;
            this.labelLongitude.Location = new System.Drawing.Point(236, 46);
            this.labelLongitude.MinimumSize = new System.Drawing.Size(105, 21);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(105, 21);
            this.labelLongitude.TabIndex = 8;
            this.labelLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLongitude.DoubleClick += new System.EventHandler(this.Set_Latitude_Longitude_Click);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.BackColor = System.Drawing.Color.DarkRed;
            this.labelLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLatitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLatitude.ForeColor = System.Drawing.Color.White;
            this.labelLatitude.Location = new System.Drawing.Point(236, 22);
            this.labelLatitude.MinimumSize = new System.Drawing.Size(105, 21);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(105, 21);
            this.labelLatitude.TabIndex = 8;
            this.labelLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLatitude.DoubleClick += new System.EventHandler(this.Set_Latitude_Longitude_Click);
            // 
            // labelTimeUTC
            // 
            this.labelTimeUTC.AutoSize = true;
            this.labelTimeUTC.BackColor = System.Drawing.Color.DarkRed;
            this.labelTimeUTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimeUTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimeUTC.ForeColor = System.Drawing.Color.White;
            this.labelTimeUTC.Location = new System.Drawing.Point(91, 22);
            this.labelTimeUTC.MinimumSize = new System.Drawing.Size(75, 21);
            this.labelTimeUTC.Name = "labelTimeUTC";
            this.labelTimeUTC.Size = new System.Drawing.Size(75, 21);
            this.labelTimeUTC.TabIndex = 18;
            this.labelTimeUTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTimeUTC.DoubleClick += new System.EventHandler(this.set_Date_Time_Click);
            // 
            // labelTimeLocal
            // 
            this.labelTimeLocal.AutoSize = true;
            this.labelTimeLocal.BackColor = System.Drawing.Color.DarkRed;
            this.labelTimeLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimeLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimeLocal.ForeColor = System.Drawing.Color.White;
            this.labelTimeLocal.Location = new System.Drawing.Point(91, 46);
            this.labelTimeLocal.MinimumSize = new System.Drawing.Size(75, 21);
            this.labelTimeLocal.Name = "labelTimeLocal";
            this.labelTimeLocal.Size = new System.Drawing.Size(75, 21);
            this.labelTimeLocal.TabIndex = 18;
            this.labelTimeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTimeLocal.DoubleClick += new System.EventHandler(this.set_Date_Time_Click);
            // 
            // labelUTC_Offset
            // 
            this.labelUTC_Offset.AutoSize = true;
            this.labelUTC_Offset.BackColor = System.Drawing.Color.DarkRed;
            this.labelUTC_Offset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUTC_Offset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUTC_Offset.Location = new System.Drawing.Point(130, 105);
            this.labelUTC_Offset.MinimumSize = new System.Drawing.Size(35, 21);
            this.labelUTC_Offset.Name = "labelUTC_Offset";
            this.labelUTC_Offset.Size = new System.Drawing.Size(35, 21);
            this.labelUTC_Offset.TabIndex = 18;
            this.labelUTC_Offset.Text = "-360";
            this.labelUTC_Offset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUTC_Offset.DoubleClick += new System.EventHandler(this.UTC_Offset_Click);
            // 
            // checkBoxDayLightSavingsOnOff
            // 
            this.checkBoxDayLightSavingsOnOff.AutoSize = true;
            this.checkBoxDayLightSavingsOnOff.Location = new System.Drawing.Point(183, 106);
            this.checkBoxDayLightSavingsOnOff.Name = "checkBoxDayLightSavingsOnOff";
            this.checkBoxDayLightSavingsOnOff.Size = new System.Drawing.Size(123, 19);
            this.checkBoxDayLightSavingsOnOff.TabIndex = 17;
            this.checkBoxDayLightSavingsOnOff.Text = "Day Light Savings";
            this.checkBoxDayLightSavingsOnOff.UseVisualStyleBackColor = true;
            this.checkBoxDayLightSavingsOnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBoxDayLightSavingsOnOff_MouseDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Local Time Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Local Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "UTC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "R. A.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Altitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 51);
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
            this.groupBoxMountPointingPosition.Location = new System.Drawing.Point(14, 194);
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
            this.labelAzimuth.Location = new System.Drawing.Point(76, 50);
            this.labelAzimuth.MinimumSize = new System.Drawing.Size(90, 2);
            this.labelAzimuth.Name = "labelAzimuth";
            this.labelAzimuth.Size = new System.Drawing.Size(90, 17);
            this.labelAzimuth.TabIndex = 14;
            this.labelAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAzimuth.DoubleClick += new System.EventHandler(this.Goto_ALT_AZ_Position_Click);
            // 
            // labelDEC
            // 
            this.labelDEC.AutoSize = true;
            this.labelDEC.BackColor = System.Drawing.Color.DarkRed;
            this.labelDEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDEC.Location = new System.Drawing.Point(236, 50);
            this.labelDEC.MinimumSize = new System.Drawing.Size(90, 2);
            this.labelDEC.Name = "labelDEC";
            this.labelDEC.Size = new System.Drawing.Size(90, 17);
            this.labelDEC.TabIndex = 13;
            this.labelDEC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDEC.DoubleClick += new System.EventHandler(this.Goto_RA_DEC_Position_Click);
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.BackColor = System.Drawing.Color.DarkRed;
            this.labelAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAltitude.Location = new System.Drawing.Point(76, 27);
            this.labelAltitude.MinimumSize = new System.Drawing.Size(90, 2);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(90, 17);
            this.labelAltitude.TabIndex = 12;
            this.labelAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAltitude.DoubleClick += new System.EventHandler(this.Goto_ALT_AZ_Position_Click);
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.BackColor = System.Drawing.Color.DarkRed;
            this.labelRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRA.Location = new System.Drawing.Point(236, 27);
            this.labelRA.MinimumSize = new System.Drawing.Size(90, 2);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(90, 17);
            this.labelRA.TabIndex = 12;
            this.labelRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRA.DoubleClick += new System.EventHandler(this.Goto_RA_DEC_Position_Click);
            // 
            // groupBoxSettings_Limits
            // 
            this.groupBoxSettings_Limits.BackColor = System.Drawing.Color.Black;
            this.groupBoxSettings_Limits.Controls.Add(this.labelDEC_GuidingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.labelRA_GuidingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.labelCustomeTrackingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.labelAltitudeLimitMIN);
            this.groupBoxSettings_Limits.Controls.Add(this.labelMeridianFlipDegrees);
            this.groupBoxSettings_Limits.Controls.Add(this.label14);
            this.groupBoxSettings_Limits.Controls.Add(this.label20);
            this.groupBoxSettings_Limits.Controls.Add(this.label19);
            this.groupBoxSettings_Limits.Controls.Add(this.label18);
            this.groupBoxSettings_Limits.Controls.Add(this.comboBoxTrackingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.label12);
            this.groupBoxSettings_Limits.Controls.Add(this.checkBoxMeridianFlipOnOff);
            this.groupBoxSettings_Limits.Controls.Add(this.comboBoxMaxSlewingRate);
            this.groupBoxSettings_Limits.Controls.Add(this.label11);
            this.groupBoxSettings_Limits.Controls.Add(this.label10);
            this.groupBoxSettings_Limits.Enabled = false;
            this.groupBoxSettings_Limits.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxSettings_Limits.Location = new System.Drawing.Point(13, 282);
            this.groupBoxSettings_Limits.Name = "groupBoxSettings_Limits";
            this.groupBoxSettings_Limits.Size = new System.Drawing.Size(353, 164);
            this.groupBoxSettings_Limits.TabIndex = 11;
            this.groupBoxSettings_Limits.TabStop = false;
            this.groupBoxSettings_Limits.Text = "Mount Settings and Limits";
            // 
            // labelDEC_GuidingRate
            // 
            this.labelDEC_GuidingRate.AutoSize = true;
            this.labelDEC_GuidingRate.BackColor = System.Drawing.Color.DarkRed;
            this.labelDEC_GuidingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDEC_GuidingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDEC_GuidingRate.Location = new System.Drawing.Point(294, 49);
            this.labelDEC_GuidingRate.MinimumSize = new System.Drawing.Size(37, 21);
            this.labelDEC_GuidingRate.Name = "labelDEC_GuidingRate";
            this.labelDEC_GuidingRate.Size = new System.Drawing.Size(37, 21);
            this.labelDEC_GuidingRate.TabIndex = 21;
            this.labelDEC_GuidingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDEC_GuidingRate.DoubleClick += new System.EventHandler(this.DEC_GuidingRate_Click);
            // 
            // labelRA_GuidingRate
            // 
            this.labelRA_GuidingRate.AutoSize = true;
            this.labelRA_GuidingRate.BackColor = System.Drawing.Color.DarkRed;
            this.labelRA_GuidingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRA_GuidingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRA_GuidingRate.Location = new System.Drawing.Point(294, 24);
            this.labelRA_GuidingRate.MinimumSize = new System.Drawing.Size(37, 21);
            this.labelRA_GuidingRate.Name = "labelRA_GuidingRate";
            this.labelRA_GuidingRate.Size = new System.Drawing.Size(37, 21);
            this.labelRA_GuidingRate.TabIndex = 20;
            this.labelRA_GuidingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRA_GuidingRate.DoubleClick += new System.EventHandler(this.RA_GuidingRate_Click);
            // 
            // labelCustomeTrackingRate
            // 
            this.labelCustomeTrackingRate.AutoSize = true;
            this.labelCustomeTrackingRate.BackColor = System.Drawing.Color.DarkRed;
            this.labelCustomeTrackingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCustomeTrackingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomeTrackingRate.Location = new System.Drawing.Point(138, 132);
            this.labelCustomeTrackingRate.MinimumSize = new System.Drawing.Size(50, 21);
            this.labelCustomeTrackingRate.Name = "labelCustomeTrackingRate";
            this.labelCustomeTrackingRate.Size = new System.Drawing.Size(50, 21);
            this.labelCustomeTrackingRate.TabIndex = 19;
            this.labelCustomeTrackingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCustomeTrackingRate.DoubleClick += new System.EventHandler(this.CustomeTrackingRate_Click);
            // 
            // labelAltitudeLimitMIN
            // 
            this.labelAltitudeLimitMIN.AutoSize = true;
            this.labelAltitudeLimitMIN.BackColor = System.Drawing.Color.DarkRed;
            this.labelAltitudeLimitMIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAltitudeLimitMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAltitudeLimitMIN.Location = new System.Drawing.Point(121, 49);
            this.labelAltitudeLimitMIN.MinimumSize = new System.Drawing.Size(24, 21);
            this.labelAltitudeLimitMIN.Name = "labelAltitudeLimitMIN";
            this.labelAltitudeLimitMIN.Size = new System.Drawing.Size(24, 21);
            this.labelAltitudeLimitMIN.TabIndex = 18;
            this.labelAltitudeLimitMIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAltitudeLimitMIN.DoubleClick += new System.EventHandler(this.AltitudeLimitMIN_Click);
            // 
            // labelMeridianFlipDegrees
            // 
            this.labelMeridianFlipDegrees.AutoSize = true;
            this.labelMeridianFlipDegrees.BackColor = System.Drawing.Color.DarkRed;
            this.labelMeridianFlipDegrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMeridianFlipDegrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMeridianFlipDegrees.Location = new System.Drawing.Point(121, 75);
            this.labelMeridianFlipDegrees.MinimumSize = new System.Drawing.Size(24, 21);
            this.labelMeridianFlipDegrees.Name = "labelMeridianFlipDegrees";
            this.labelMeridianFlipDegrees.Size = new System.Drawing.Size(24, 21);
            this.labelMeridianFlipDegrees.TabIndex = 17;
            this.labelMeridianFlipDegrees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMeridianFlipDegrees.DoubleClick += new System.EventHandler(this.MeridianFlipDegrees_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Degrees Past Meridian";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 15);
            this.label18.TabIndex = 10;
            this.label18.Text = "Custom Tracking Rate";
            // 
            // comboBoxTrackingRate
            // 
            this.comboBoxTrackingRate.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxTrackingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTrackingRate.ForeColor = System.Drawing.Color.Yellow;
            this.comboBoxTrackingRate.FormattingEnabled = true;
            this.comboBoxTrackingRate.ItemHeight = 15;
            this.comboBoxTrackingRate.Items.AddRange(new object[] {
            "Sidereal",
            "Lunar",
            "Solar",
            "King",
            "Custom"});
            this.comboBoxTrackingRate.Location = new System.Drawing.Point(121, 101);
            this.comboBoxTrackingRate.MaxDropDownItems = 5;
            this.comboBoxTrackingRate.Name = "comboBoxTrackingRate";
            this.comboBoxTrackingRate.Size = new System.Drawing.Size(89, 23);
            this.comboBoxTrackingRate.TabIndex = 9;
            this.comboBoxTrackingRate.DropDown += new System.EventHandler(this.ComboBox_StopTimer_DropDown);
            this.comboBoxTrackingRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTrackingRate_SelectedIndexChanged);
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
            this.checkBoxMeridianFlipOnOff.BackColor = System.Drawing.Color.Black;
            this.checkBoxMeridianFlipOnOff.Location = new System.Drawing.Point(20, 76);
            this.checkBoxMeridianFlipOnOff.Name = "checkBoxMeridianFlipOnOff";
            this.checkBoxMeridianFlipOnOff.Size = new System.Drawing.Size(98, 19);
            this.checkBoxMeridianFlipOnOff.TabIndex = 7;
            this.checkBoxMeridianFlipOnOff.Text = "Meridian Flip";
            this.checkBoxMeridianFlipOnOff.UseVisualStyleBackColor = false;
            this.checkBoxMeridianFlipOnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBoxMeridianFlipOnOff_MouseDown);
            // 
            // comboBoxMaxSlewingRate
            // 
            this.comboBoxMaxSlewingRate.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxMaxSlewingRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaxSlewingRate.ForeColor = System.Drawing.Color.Yellow;
            this.comboBoxMaxSlewingRate.FormattingEnabled = true;
            this.comboBoxMaxSlewingRate.ItemHeight = 15;
            this.comboBoxMaxSlewingRate.Items.AddRange(new object[] {
            "256x",
            "512x",
            "MAX"});
            this.comboBoxMaxSlewingRate.Location = new System.Drawing.Point(121, 22);
            this.comboBoxMaxSlewingRate.MaxDropDownItems = 3;
            this.comboBoxMaxSlewingRate.Name = "comboBoxMaxSlewingRate";
            this.comboBoxMaxSlewingRate.Size = new System.Drawing.Size(63, 23);
            this.comboBoxMaxSlewingRate.TabIndex = 6;
            this.comboBoxMaxSlewingRate.DropDown += new System.EventHandler(this.ComboBox_StopTimer_DropDown);
            this.comboBoxMaxSlewingRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMaxSlewingRate_SelectedIndexChanged);
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
            // buttonResetPEC
            // 
            this.buttonResetPEC.BackColor = System.Drawing.Color.Maroon;
            this.buttonResetPEC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonResetPEC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonResetPEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPEC.Location = new System.Drawing.Point(6, 59);
            this.buttonResetPEC.Name = "buttonResetPEC";
            this.buttonResetPEC.Size = new System.Drawing.Size(88, 25);
            this.buttonResetPEC.TabIndex = 22;
            this.buttonResetPEC.Text = "Reset PEC";
            this.buttonResetPEC.UseVisualStyleBackColor = false;
            this.buttonResetPEC.Click += new System.EventHandler(this.ButtonResetPECrecording_Click);
            // 
            // groupBoxMountParking
            // 
            this.groupBoxMountParking.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountParking.Controls.Add(this.labelMountParkingAzimuth);
            this.groupBoxMountParking.Controls.Add(this.labelMountParkingAltitude);
            this.groupBoxMountParking.Controls.Add(this.buttonParkMount);
            this.groupBoxMountParking.Controls.Add(this.label22);
            this.groupBoxMountParking.Controls.Add(this.label21);
            this.groupBoxMountParking.Enabled = false;
            this.groupBoxMountParking.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountParking.Location = new System.Drawing.Point(13, 452);
            this.groupBoxMountParking.Name = "groupBoxMountParking";
            this.groupBoxMountParking.Size = new System.Drawing.Size(353, 98);
            this.groupBoxMountParking.TabIndex = 12;
            this.groupBoxMountParking.TabStop = false;
            this.groupBoxMountParking.Text = "Mount Parking";
            // 
            // labelMountParkingAzimuth
            // 
            this.labelMountParkingAzimuth.AutoSize = true;
            this.labelMountParkingAzimuth.BackColor = System.Drawing.Color.DarkRed;
            this.labelMountParkingAzimuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMountParkingAzimuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMountParkingAzimuth.Location = new System.Drawing.Point(110, 59);
            this.labelMountParkingAzimuth.MinimumSize = new System.Drawing.Size(30, 22);
            this.labelMountParkingAzimuth.Name = "labelMountParkingAzimuth";
            this.labelMountParkingAzimuth.Size = new System.Drawing.Size(30, 22);
            this.labelMountParkingAzimuth.TabIndex = 7;
            this.labelMountParkingAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMountParkingAzimuth.DoubleClick += new System.EventHandler(this.MountParkingAzimuth_Click);
            // 
            // labelMountParkingAltitude
            // 
            this.labelMountParkingAltitude.AutoSize = true;
            this.labelMountParkingAltitude.BackColor = System.Drawing.Color.DarkRed;
            this.labelMountParkingAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMountParkingAltitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMountParkingAltitude.Location = new System.Drawing.Point(110, 23);
            this.labelMountParkingAltitude.MinimumSize = new System.Drawing.Size(30, 22);
            this.labelMountParkingAltitude.Name = "labelMountParkingAltitude";
            this.labelMountParkingAltitude.Size = new System.Drawing.Size(30, 22);
            this.labelMountParkingAltitude.TabIndex = 6;
            this.labelMountParkingAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMountParkingAltitude.DoubleClick += new System.EventHandler(this.MountParkingAltitude_Click);
            // 
            // buttonParkMount
            // 
            this.buttonParkMount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonParkMount.BackColor = System.Drawing.Color.DarkRed;
            this.buttonParkMount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonParkMount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonParkMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParkMount.Location = new System.Drawing.Point(207, 56);
            this.buttonParkMount.Name = "buttonParkMount";
            this.buttonParkMount.Size = new System.Drawing.Size(134, 28);
            this.buttonParkMount.TabIndex = 5;
            this.buttonParkMount.Text = "Park Mount";
            this.buttonParkMount.UseVisualStyleBackColor = false;
            this.buttonParkMount.Click += new System.EventHandler(this.ButtonParkMount_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Parking Azimuth";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Parking Altitude";
            // 
            // groupBoxMountZeroPosition
            // 
            this.groupBoxMountZeroPosition.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountZeroPosition.Controls.Add(this.labelMountZeroPosition);
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonSetNewZeroPosition);
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonGotoZeroPosition);
            this.groupBoxMountZeroPosition.Controls.Add(this.buttonSearchMountZero);
            this.groupBoxMountZeroPosition.Enabled = false;
            this.groupBoxMountZeroPosition.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountZeroPosition.Location = new System.Drawing.Point(372, 452);
            this.groupBoxMountZeroPosition.Name = "groupBoxMountZeroPosition";
            this.groupBoxMountZeroPosition.Size = new System.Drawing.Size(269, 98);
            this.groupBoxMountZeroPosition.TabIndex = 13;
            this.groupBoxMountZeroPosition.TabStop = false;
            this.groupBoxMountZeroPosition.Text = "Mount Zero Position";
            // 
            // labelMountZeroPosition
            // 
            this.labelMountZeroPosition.AutoSize = true;
            this.labelMountZeroPosition.BackColor = System.Drawing.Color.Maroon;
            this.labelMountZeroPosition.Location = new System.Drawing.Point(9, 28);
            this.labelMountZeroPosition.MinimumSize = new System.Drawing.Size(120, 23);
            this.labelMountZeroPosition.Name = "labelMountZeroPosition";
            this.labelMountZeroPosition.Size = new System.Drawing.Size(120, 23);
            this.labelMountZeroPosition.TabIndex = 3;
            this.labelMountZeroPosition.Text = "At ZERO Position";
            this.labelMountZeroPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetNewZeroPosition
            // 
            this.buttonSetNewZeroPosition.BackColor = System.Drawing.Color.Maroon;
            this.buttonSetNewZeroPosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSetNewZeroPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSetNewZeroPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetNewZeroPosition.Location = new System.Drawing.Point(8, 59);
            this.buttonSetNewZeroPosition.Name = "buttonSetNewZeroPosition";
            this.buttonSetNewZeroPosition.Size = new System.Drawing.Size(121, 29);
            this.buttonSetNewZeroPosition.TabIndex = 2;
            this.buttonSetNewZeroPosition.Text = "Set New Zero Pos.";
            this.buttonSetNewZeroPosition.UseVisualStyleBackColor = false;
            this.buttonSetNewZeroPosition.Click += new System.EventHandler(this.ButtonSetNewZeroPosition_Click);
            // 
            // buttonGotoZeroPosition
            // 
            this.buttonGotoZeroPosition.BackColor = System.Drawing.Color.Maroon;
            this.buttonGotoZeroPosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGotoZeroPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonGotoZeroPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGotoZeroPosition.Location = new System.Drawing.Point(138, 24);
            this.buttonGotoZeroPosition.Name = "buttonGotoZeroPosition";
            this.buttonGotoZeroPosition.Size = new System.Drawing.Size(121, 29);
            this.buttonGotoZeroPosition.TabIndex = 1;
            this.buttonGotoZeroPosition.Text = "Goto Zero Position";
            this.buttonGotoZeroPosition.UseVisualStyleBackColor = false;
            this.buttonGotoZeroPosition.Click += new System.EventHandler(this.ButtonGotoZeroPosition_Click);
            // 
            // buttonSearchMountZero
            // 
            this.buttonSearchMountZero.BackColor = System.Drawing.Color.Maroon;
            this.buttonSearchMountZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearchMountZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSearchMountZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMountZero.Location = new System.Drawing.Point(137, 59);
            this.buttonSearchMountZero.Name = "buttonSearchMountZero";
            this.buttonSearchMountZero.Size = new System.Drawing.Size(122, 29);
            this.buttonSearchMountZero.TabIndex = 0;
            this.buttonSearchMountZero.Text = "Search Zero Pos.";
            this.buttonSearchMountZero.UseVisualStyleBackColor = false;
            this.buttonSearchMountZero.Click += new System.EventHandler(this.ButtonSearchMountZero_Click);
            // 
            // groupBoxMountPad
            // 
            this.groupBoxMountPad.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountPad.Controls.Add(this.labelMountSlewing);
            this.groupBoxMountPad.Controls.Add(this.labelPierEAST);
            this.groupBoxMountPad.Controls.Add(this.labelPierWEST);
            this.groupBoxMountPad.Controls.Add(this.label23);
            this.groupBoxMountPad.Controls.Add(this.comboBoxManualMovingRate);
            this.groupBoxMountPad.Controls.Add(this.buttonAllStop);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveDown);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveRight);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveLeft);
            this.groupBoxMountPad.Controls.Add(this.buttonMoveUp);
            this.groupBoxMountPad.Enabled = false;
            this.groupBoxMountPad.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountPad.Location = new System.Drawing.Point(371, 47);
            this.groupBoxMountPad.Name = "groupBoxMountPad";
            this.groupBoxMountPad.Size = new System.Drawing.Size(270, 295);
            this.groupBoxMountPad.TabIndex = 14;
            this.groupBoxMountPad.TabStop = false;
            this.groupBoxMountPad.Text = "Mount Pad";
            // 
            // labelMountSlewing
            // 
            this.labelMountSlewing.AutoSize = true;
            this.labelMountSlewing.BackColor = System.Drawing.Color.Maroon;
            this.labelMountSlewing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMountSlewing.Location = new System.Drawing.Point(6, 247);
            this.labelMountSlewing.MinimumSize = new System.Drawing.Size(70, 17);
            this.labelMountSlewing.Name = "labelMountSlewing";
            this.labelMountSlewing.Size = new System.Drawing.Size(70, 17);
            this.labelMountSlewing.TabIndex = 17;
            this.labelMountSlewing.Text = "Slewing";
            this.labelMountSlewing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPierEAST
            // 
            this.labelPierEAST.AutoSize = true;
            this.labelPierEAST.BackColor = System.Drawing.Color.Maroon;
            this.labelPierEAST.Location = new System.Drawing.Point(194, 270);
            this.labelPierEAST.MinimumSize = new System.Drawing.Size(70, 17);
            this.labelPierEAST.Name = "labelPierEAST";
            this.labelPierEAST.Size = new System.Drawing.Size(70, 17);
            this.labelPierEAST.TabIndex = 16;
            this.labelPierEAST.Text = "Pier EAST";
            this.labelPierEAST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPierWEST
            // 
            this.labelPierWEST.AutoSize = true;
            this.labelPierWEST.BackColor = System.Drawing.Color.Maroon;
            this.labelPierWEST.Location = new System.Drawing.Point(6, 270);
            this.labelPierWEST.MinimumSize = new System.Drawing.Size(70, 17);
            this.labelPierWEST.Name = "labelPierWEST";
            this.labelPierWEST.Size = new System.Drawing.Size(70, 17);
            this.labelPierWEST.TabIndex = 15;
            this.labelPierWEST.Text = "Pier WEST";
            this.labelPierWEST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(66, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Manual Moving Rate";
            // 
            // comboBoxManualMovingRate
            // 
            this.comboBoxManualMovingRate.BackColor = System.Drawing.Color.DarkRed;
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
            this.comboBoxManualMovingRate.Location = new System.Drawing.Point(193, 19);
            this.comboBoxManualMovingRate.MaxDropDownItems = 9;
            this.comboBoxManualMovingRate.Name = "comboBoxManualMovingRate";
            this.comboBoxManualMovingRate.Size = new System.Drawing.Size(64, 23);
            this.comboBoxManualMovingRate.TabIndex = 13;
            this.comboBoxManualMovingRate.DropDown += new System.EventHandler(this.ComboBox_StopTimer_DropDown);
            this.comboBoxManualMovingRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxManualMovingRate_SelectedIndexChanged);
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
            this.buttonAllStop.Click += new System.EventHandler(this.ButtonAllStop_Click);
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
            this.buttonMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveDown_MouseDown);
            this.buttonMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Manual_DEC_MoveSTOP_MouseUp);
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
            this.buttonMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveRight_MouseDown);
            this.buttonMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Manual_RA_MoveSTOP_MouseUp);
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
            this.buttonMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveLeft_MouseDown);
            this.buttonMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Manual_RA_MoveSTOP_MouseUp);
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
            this.buttonMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveUp_MouseDown);
            this.buttonMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Manual_DEC_MoveSTOP_MouseUp);
            // 
            // groupBoxMountTracking
            // 
            this.groupBoxMountTracking.BackColor = System.Drawing.Color.Black;
            this.groupBoxMountTracking.Controls.Add(this.DomeCtrlOnOffButton);
            this.groupBoxMountTracking.Controls.Add(this.buttonResetPEC);
            this.groupBoxMountTracking.Controls.Add(this.buttonPeriodicErrorCorrection);
            this.groupBoxMountTracking.Controls.Add(this.buttonTrackingOnOff);
            this.groupBoxMountTracking.Enabled = false;
            this.groupBoxMountTracking.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxMountTracking.Location = new System.Drawing.Point(371, 348);
            this.groupBoxMountTracking.Name = "groupBoxMountTracking";
            this.groupBoxMountTracking.Size = new System.Drawing.Size(270, 98);
            this.groupBoxMountTracking.TabIndex = 16;
            this.groupBoxMountTracking.TabStop = false;
            this.groupBoxMountTracking.Text = "Mount Tracking";
            // 
            // DomeCtrlOnOffButton
            // 
            this.DomeCtrlOnOffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DomeCtrlOnOffButton.BackColor = System.Drawing.Color.Maroon;
            this.DomeCtrlOnOffButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DomeCtrlOnOffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DomeCtrlOnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomeCtrlOnOffButton.Location = new System.Drawing.Point(139, 59);
            this.DomeCtrlOnOffButton.Name = "DomeCtrlOnOffButton";
            this.DomeCtrlOnOffButton.Size = new System.Drawing.Size(121, 25);
            this.DomeCtrlOnOffButton.TabIndex = 23;
            this.DomeCtrlOnOffButton.Text = "Dome  Controller";
            this.DomeCtrlOnOffButton.UseVisualStyleBackColor = false;
            this.DomeCtrlOnOffButton.Click += new System.EventHandler(this.DomeCtrlOnOff_Click);
            // 
            // buttonPeriodicErrorCorrection
            // 
            this.buttonPeriodicErrorCorrection.BackColor = System.Drawing.Color.Maroon;
            this.buttonPeriodicErrorCorrection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPeriodicErrorCorrection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonPeriodicErrorCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPeriodicErrorCorrection.Location = new System.Drawing.Point(6, 24);
            this.buttonPeriodicErrorCorrection.Name = "buttonPeriodicErrorCorrection";
            this.buttonPeriodicErrorCorrection.Size = new System.Drawing.Size(126, 25);
            this.buttonPeriodicErrorCorrection.TabIndex = 17;
            this.buttonPeriodicErrorCorrection.Text = "PEC Tracking OFF";
            this.buttonPeriodicErrorCorrection.UseVisualStyleBackColor = false;
            this.buttonPeriodicErrorCorrection.Click += new System.EventHandler(this.ButtonPeriodicErrorCorrection_Click);
            // 
            // buttonTrackingOnOff
            // 
            this.buttonTrackingOnOff.BackColor = System.Drawing.Color.Maroon;
            this.buttonTrackingOnOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTrackingOnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonTrackingOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrackingOnOff.Location = new System.Drawing.Point(139, 24);
            this.buttonTrackingOnOff.Name = "buttonTrackingOnOff";
            this.buttonTrackingOnOff.Size = new System.Drawing.Size(121, 25);
            this.buttonTrackingOnOff.TabIndex = 16;
            this.buttonTrackingOnOff.Text = "Tracking OFF";
            this.buttonTrackingOnOff.UseVisualStyleBackColor = false;
            this.buttonTrackingOnOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonTrackingOnOff_MouseClick);
            // 
            // ButtonEXIT
            // 
            this.ButtonEXIT.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonEXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonEXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ButtonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEXIT.Location = new System.Drawing.Point(568, 10);
            this.ButtonEXIT.Name = "ButtonEXIT";
            this.ButtonEXIT.Size = new System.Drawing.Size(74, 31);
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
            // MountComPort
            // 
            this.MountComPort.BaudRate = 115200;
            this.MountComPort.ReadBufferSize = 1024;
            this.MountComPort.ReadTimeout = 1000;
            this.MountComPort.WriteBufferSize = 1024;
            this.MountComPort.WriteTimeout = 1000;
            // 
            // timerMount
            // 
            this.timerMount.Interval = 1000;
            this.timerMount.Tick += new System.EventHandler(this.GetSendMountData);
            // 
            // buttonSlewToObject
            // 
            this.buttonSlewToObject.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSlewToObject.Enabled = false;
            this.buttonSlewToObject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSlewToObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlewToObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlewToObject.Location = new System.Drawing.Point(429, 10);
            this.buttonSlewToObject.Name = "buttonSlewToObject";
            this.buttonSlewToObject.Size = new System.Drawing.Size(133, 31);
            this.buttonSlewToObject.TabIndex = 19;
            this.buttonSlewToObject.Text = "Slew to Object";
            this.buttonSlewToObject.UseVisualStyleBackColor = false;
            this.buttonSlewToObject.Click += new System.EventHandler(this.SlewToObject_Click);
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.Firebrick;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.Yellow;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(48, 14);
            this.ComboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxBaudRate.MaxDropDownItems = 3;
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(78, 24);
            this.ComboBoxBaudRate.TabIndex = 20;
            this.ComboBoxBaudRate.Text = "Baud";
            this.ComboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBaudRate_SelectedIndexChanged);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaudRate.Location = new System.Drawing.Point(51, 17);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(49, 16);
            this.labelBaudRate.TabIndex = 21;
            this.labelBaudRate.Text = "115200";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPort.Location = new System.Drawing.Point(134, 17);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(43, 16);
            this.labelComPort.TabIndex = 22;
            this.labelComPort.Text = "COMx";
            // 
            // MainControlForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(654, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSlewToObject);
            this.Controls.Add(this.ButtonEXIT);
            this.Controls.Add(this.groupBoxMountTracking);
            this.Controls.Add(this.groupBoxMountPad);
            this.Controls.Add(this.groupBoxMountZeroPosition);
            this.Controls.Add(this.groupBoxMountParking);
            this.Controls.Add(this.groupBoxSettings_Limits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxMountPointingPosition);
            this.Controls.Add(this.ButtonCOMPortConnect);
            this.Controls.Add(this.groupBoxMountGPS_Time);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.ComboBoxBaudRate);
            this.Controls.Add(this.ComboBoxComPort);
            this.Controls.Add(this.labelComPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mount Controller";
            this.groupBoxMountGPS_Time.ResumeLayout(false);
            this.groupBoxMountGPS_Time.PerformLayout();
            this.groupBoxMountPointingPosition.ResumeLayout(false);
            this.groupBoxMountPointingPosition.PerformLayout();
            this.groupBoxSettings_Limits.ResumeLayout(false);
            this.groupBoxSettings_Limits.PerformLayout();
            this.groupBoxMountParking.ResumeLayout(false);
            this.groupBoxMountParking.PerformLayout();
            this.groupBoxMountZeroPosition.ResumeLayout(false);
            this.groupBoxMountZeroPosition.PerformLayout();
            this.groupBoxMountPad.ResumeLayout(false);
            this.groupBoxMountPad.PerformLayout();
            this.groupBoxMountTracking.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBoxDayLightSavingsOnOff;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelRA;
        private System.Windows.Forms.Label labelAzimuth;
        private System.Windows.Forms.Label labelDEC;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.ComboBox comboBoxMaxSlewingRate;
        private System.Windows.Forms.CheckBox checkBoxMeridianFlipOnOff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxTrackingRate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBoxMountParking;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonParkMount;
        private System.Windows.Forms.GroupBox groupBoxMountZeroPosition;
        private System.Windows.Forms.Button buttonSearchMountZero;
        private System.Windows.Forms.Button buttonGotoZeroPosition;
        private System.Windows.Forms.Button buttonSetNewZeroPosition;
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
        private System.Windows.Forms.Button buttonConnectComPort;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort MountComPort;
        private System.Windows.Forms.Timer timerMount;
        private System.Windows.Forms.Label labelPierEAST;
        private System.Windows.Forms.Label labelPierWEST;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelMountSlewing;
        private System.Windows.Forms.Label labelMountZeroPosition;
        private System.Windows.Forms.Label labelMountParkingAltitude;
        private System.Windows.Forms.Label labelMountParkingAzimuth;
        private System.Windows.Forms.Label labelMeridianFlipDegrees;
        private System.Windows.Forms.Label labelAltitudeLimitMIN;
        private System.Windows.Forms.Label labelCustomeTrackingRate;
        private System.Windows.Forms.Label labelRA_GuidingRate;
        private System.Windows.Forms.Label labelDEC_GuidingRate;
        private System.Windows.Forms.Label labelUTC_Offset;
        private System.Windows.Forms.Label labelTimeLocal;
        private System.Windows.Forms.Label labelTimeUTC;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelTimeSource;
        private System.Windows.Forms.Button buttonPeriodicErrorCorrection;
        private System.Windows.Forms.Button buttonResetPEC;
        private System.Windows.Forms.Button buttonSlewToObject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelLST;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label GPS_status;
        private System.Windows.Forms.Button DomeCtrlOnOffButton;
    }
}

