namespace iOptron_Mount_Control
{
    partial class DomeController
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
            this.label1 = new System.Windows.Forms.Label();
            this.DomeConnectbutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DomeComPortComboBox = new System.Windows.Forms.ComboBox();
            this.DomeCOMPort = new System.IO.Ports.SerialPort(this.components);
            this.ShutterOpenCloseButton = new System.Windows.Forms.Button();
            this.DomeAzimith = new System.Windows.Forms.Label();
            this.AllStopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.incDegreesCCWbutton = new System.Windows.Forms.Button();
            this.DegreesToInc = new System.Windows.Forms.ComboBox();
            this.incDegreesCWbutton = new System.Windows.Forms.Button();
            this.groupDomeControler = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRainSensor = new System.Windows.Forms.Button();
            this.buttonWeatherSW = new System.Windows.Forms.Button();
            this.buttonParkDome = new System.Windows.Forms.Button();
            this.buttonHomeDome = new System.Windows.Forms.Button();
            this.SyncDome_button = new System.Windows.Forms.Button();
            this.timerDome = new System.Windows.Forms.Timer(this.components);
            this.labelDomeCOM = new System.Windows.Forms.Label();
            this.groupDomeControler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // DomeConnectbutton
            // 
            this.DomeConnectbutton.BackColor = System.Drawing.Color.DarkRed;
            this.DomeConnectbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DomeConnectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomeConnectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeConnectbutton.Location = new System.Drawing.Point(156, 12);
            this.DomeConnectbutton.Name = "DomeConnectbutton";
            this.DomeConnectbutton.Size = new System.Drawing.Size(135, 32);
            this.DomeConnectbutton.TabIndex = 2;
            this.DomeConnectbutton.Text = "Connect to Dome";
            this.DomeConnectbutton.UseVisualStyleBackColor = false;
            this.DomeConnectbutton.Click += new System.EventHandler(this.DomeConnectbutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(298, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(135, 32);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.DomeControllerExitButton);
            // 
            // DomeComPortComboBox
            // 
            this.DomeComPortComboBox.BackColor = System.Drawing.Color.Black;
            this.DomeComPortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomeComPortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeComPortComboBox.ForeColor = System.Drawing.Color.Yellow;
            this.DomeComPortComboBox.FormattingEnabled = true;
            this.DomeComPortComboBox.Location = new System.Drawing.Point(82, 17);
            this.DomeComPortComboBox.Name = "DomeComPortComboBox";
            this.DomeComPortComboBox.Size = new System.Drawing.Size(68, 24);
            this.DomeComPortComboBox.TabIndex = 3;
            this.DomeComPortComboBox.Text = "COM";
            this.DomeComPortComboBox.SelectedIndexChanged += new System.EventHandler(this.DomeComPortComboBox_SelectedIndexChanged);
            // 
            // DomeCOMPort
            // 
            this.DomeCOMPort.BaudRate = 115200;
            this.DomeCOMPort.ReadBufferSize = 1024;
            this.DomeCOMPort.ReadTimeout = 5000;
            this.DomeCOMPort.WriteBufferSize = 1024;
            this.DomeCOMPort.WriteTimeout = 2500;
            // 
            // ShutterOpenCloseButton
            // 
            this.ShutterOpenCloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.ShutterOpenCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShutterOpenCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutterOpenCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutterOpenCloseButton.Location = new System.Drawing.Point(6, 20);
            this.ShutterOpenCloseButton.Name = "ShutterOpenCloseButton";
            this.ShutterOpenCloseButton.Size = new System.Drawing.Size(124, 32);
            this.ShutterOpenCloseButton.TabIndex = 5;
            this.ShutterOpenCloseButton.Text = "Open Shutter";
            this.ShutterOpenCloseButton.UseVisualStyleBackColor = false;
            this.ShutterOpenCloseButton.Click += new System.EventHandler(this.ShutterOpenCloseButton_Click);
            // 
            // DomeAzimith
            // 
            this.DomeAzimith.BackColor = System.Drawing.Color.Black;
            this.DomeAzimith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DomeAzimith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomeAzimith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeAzimith.Location = new System.Drawing.Point(138, 20);
            this.DomeAzimith.MinimumSize = new System.Drawing.Size(2, 32);
            this.DomeAzimith.Name = "DomeAzimith";
            this.DomeAzimith.Size = new System.Drawing.Size(144, 32);
            this.DomeAzimith.TabIndex = 6;
            this.DomeAzimith.Text = "Dome Azimith  000.0°";
            this.DomeAzimith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DomeAzimith.DoubleClick += new System.EventHandler(this.GotoDomeAzimith_DoubleClick);
            // 
            // AllStopButton
            // 
            this.AllStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllStopButton.BackColor = System.Drawing.Color.Red;
            this.AllStopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStopButton.Location = new System.Drawing.Point(290, 20);
            this.AllStopButton.Name = "AllStopButton";
            this.AllStopButton.Size = new System.Drawing.Size(124, 32);
            this.AllStopButton.TabIndex = 7;
            this.AllStopButton.Text = "ALL STOP";
            this.AllStopButton.UseVisualStyleBackColor = false;
            this.AllStopButton.Click += new System.EventHandler(this.AllStopButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Maroon;
            this.progressBar1.ForeColor = System.Drawing.Color.OrangeRed;
            this.progressBar1.Location = new System.Drawing.Point(6, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // incDegreesCCWbutton
            // 
            this.incDegreesCCWbutton.BackColor = System.Drawing.Color.Maroon;
            this.incDegreesCCWbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.incDegreesCCWbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incDegreesCCWbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDegreesCCWbutton.Location = new System.Drawing.Point(22, 58);
            this.incDegreesCCWbutton.Name = "incDegreesCCWbutton";
            this.incDegreesCCWbutton.Size = new System.Drawing.Size(107, 32);
            this.incDegreesCCWbutton.TabIndex = 9;
            this.incDegreesCCWbutton.Text = "Rotate CCW";
            this.incDegreesCCWbutton.UseVisualStyleBackColor = false;
            this.incDegreesCCWbutton.Click += new System.EventHandler(this.incDegreesCCWbutton_Click);
            // 
            // DegreesToInc
            // 
            this.DegreesToInc.BackColor = System.Drawing.Color.Black;
            this.DegreesToInc.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreesToInc.ForeColor = System.Drawing.Color.Yellow;
            this.DegreesToInc.FormattingEnabled = true;
            this.DegreesToInc.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "30",
            "45",
            "90",
            "120",
            "180"});
            this.DegreesToInc.Location = new System.Drawing.Point(217, 63);
            this.DegreesToInc.Name = "DegreesToInc";
            this.DegreesToInc.Size = new System.Drawing.Size(54, 24);
            this.DegreesToInc.TabIndex = 10;
            this.DegreesToInc.SelectedIndexChanged += new System.EventHandler(this.DegreesToInc_SelectedIndexChanged);
            // 
            // incDegreesCWbutton
            // 
            this.incDegreesCWbutton.BackColor = System.Drawing.Color.Maroon;
            this.incDegreesCWbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.incDegreesCWbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incDegreesCWbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDegreesCWbutton.Location = new System.Drawing.Point(290, 58);
            this.incDegreesCWbutton.Name = "incDegreesCWbutton";
            this.incDegreesCWbutton.Size = new System.Drawing.Size(107, 32);
            this.incDegreesCWbutton.TabIndex = 11;
            this.incDegreesCWbutton.Text = "Rotate CW";
            this.incDegreesCWbutton.UseVisualStyleBackColor = false;
            this.incDegreesCWbutton.Click += new System.EventHandler(this.incDegreesCWbutton_Click);
            // 
            // groupDomeControler
            // 
            this.groupDomeControler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDomeControler.BackColor = System.Drawing.Color.Black;
            this.groupDomeControler.Controls.Add(this.label2);
            this.groupDomeControler.Controls.Add(this.button1);
            this.groupDomeControler.Controls.Add(this.buttonRainSensor);
            this.groupDomeControler.Controls.Add(this.buttonWeatherSW);
            this.groupDomeControler.Controls.Add(this.buttonParkDome);
            this.groupDomeControler.Controls.Add(this.buttonHomeDome);
            this.groupDomeControler.Controls.Add(this.SyncDome_button);
            this.groupDomeControler.Controls.Add(this.progressBar1);
            this.groupDomeControler.Controls.Add(this.incDegreesCWbutton);
            this.groupDomeControler.Controls.Add(this.DomeAzimith);
            this.groupDomeControler.Controls.Add(this.DegreesToInc);
            this.groupDomeControler.Controls.Add(this.ShutterOpenCloseButton);
            this.groupDomeControler.Controls.Add(this.incDegreesCCWbutton);
            this.groupDomeControler.Controls.Add(this.AllStopButton);
            this.groupDomeControler.ForeColor = System.Drawing.Color.Yellow;
            this.groupDomeControler.Location = new System.Drawing.Point(12, 54);
            this.groupDomeControler.Name = "groupDomeControler";
            this.groupDomeControler.Size = new System.Drawing.Size(420, 215);
            this.groupDomeControler.TabIndex = 12;
            this.groupDomeControler.TabStop = false;
            this.groupDomeControler.Text = "Dome Controller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Increment °";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set Park Position";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonRainSensor
            // 
            this.buttonRainSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRainSensor.BackColor = System.Drawing.Color.Black;
            this.buttonRainSensor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRainSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRainSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRainSensor.Location = new System.Drawing.Point(6, 151);
            this.buttonRainSensor.Name = "buttonRainSensor";
            this.buttonRainSensor.Size = new System.Drawing.Size(124, 32);
            this.buttonRainSensor.TabIndex = 16;
            this.buttonRainSensor.Text = "Rain Sensor";
            this.buttonRainSensor.UseVisualStyleBackColor = false;
            // 
            // buttonWeatherSW
            // 
            this.buttonWeatherSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeatherSW.BackColor = System.Drawing.Color.Black;
            this.buttonWeatherSW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonWeatherSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeatherSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeatherSW.Location = new System.Drawing.Point(290, 151);
            this.buttonWeatherSW.Name = "buttonWeatherSW";
            this.buttonWeatherSW.Size = new System.Drawing.Size(124, 32);
            this.buttonWeatherSW.TabIndex = 15;
            this.buttonWeatherSW.Text = "Weather SW OFF";
            this.buttonWeatherSW.UseVisualStyleBackColor = false;
            // 
            // buttonParkDome
            // 
            this.buttonParkDome.BackColor = System.Drawing.Color.DarkRed;
            this.buttonParkDome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonParkDome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParkDome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParkDome.Location = new System.Drawing.Point(148, 96);
            this.buttonParkDome.Name = "buttonParkDome";
            this.buttonParkDome.Size = new System.Drawing.Size(123, 32);
            this.buttonParkDome.TabIndex = 14;
            this.buttonParkDome.Text = "Park Dome";
            this.buttonParkDome.UseVisualStyleBackColor = false;
            this.buttonParkDome.Click += new System.EventHandler(this.buttonParkDome_Click);
            // 
            // buttonHomeDome
            // 
            this.buttonHomeDome.BackColor = System.Drawing.Color.DarkRed;
            this.buttonHomeDome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHomeDome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeDome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeDome.Location = new System.Drawing.Point(6, 96);
            this.buttonHomeDome.Name = "buttonHomeDome";
            this.buttonHomeDome.Size = new System.Drawing.Size(124, 32);
            this.buttonHomeDome.TabIndex = 13;
            this.buttonHomeDome.Text = "Home Dome";
            this.buttonHomeDome.UseVisualStyleBackColor = false;
            this.buttonHomeDome.Click += new System.EventHandler(this.buttonHomeDome_Click);
            // 
            // SyncDome_button
            // 
            this.SyncDome_button.BackColor = System.Drawing.Color.DarkRed;
            this.SyncDome_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SyncDome_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncDome_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncDome_button.Location = new System.Drawing.Point(290, 96);
            this.SyncDome_button.Name = "SyncDome_button";
            this.SyncDome_button.Size = new System.Drawing.Size(124, 32);
            this.SyncDome_button.TabIndex = 12;
            this.SyncDome_button.Text = "Sync Dome";
            this.SyncDome_button.UseVisualStyleBackColor = false;
            this.SyncDome_button.Click += new System.EventHandler(this.SyncDome_button_Click);
            // 
            // timerDome
            // 
            this.timerDome.Interval = 1000;
            this.timerDome.Tick += new System.EventHandler(this.timerDome_Tick);
            // 
            // labelDomeCOM
            // 
            this.labelDomeCOM.AutoSize = true;
            this.labelDomeCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomeCOM.Location = new System.Drawing.Point(82, 20);
            this.labelDomeCOM.Name = "labelDomeCOM";
            this.labelDomeCOM.Size = new System.Drawing.Size(43, 16);
            this.labelDomeCOM.TabIndex = 13;
            this.labelDomeCOM.Text = "COMx";
            // 
            // DomeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.ControlBox = false;
            this.Controls.Add(this.labelDomeCOM);
            this.Controls.Add(this.groupDomeControler);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DomeComPortComboBox);
            this.Controls.Add(this.DomeConnectbutton);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DomeController";
            this.Text = "Dome Controller";
            this.groupDomeControler.ResumeLayout(false);
            this.groupDomeControler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DomeConnectbutton;
        private System.Windows.Forms.ComboBox DomeComPortComboBox;
        private System.IO.Ports.SerialPort DomeCOMPort;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ShutterOpenCloseButton;
        private System.Windows.Forms.Label DomeAzimith;
        private System.Windows.Forms.Button AllStopButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button incDegreesCCWbutton;
        private System.Windows.Forms.ComboBox DegreesToInc;
        private System.Windows.Forms.Button incDegreesCWbutton;
        private System.Windows.Forms.GroupBox groupDomeControler;
        private System.Windows.Forms.Button SyncDome_button;
        private System.Windows.Forms.Button buttonParkDome;
        private System.Windows.Forms.Button buttonHomeDome;
        private System.Windows.Forms.Timer timerDome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonWeatherSW;
        private System.Windows.Forms.Button buttonRainSensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDomeCOM;
    }
}