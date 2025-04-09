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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DomeComPortComboBox = new System.Windows.Forms.ComboBox();
            this.DomeSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
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
            this.DomeConnectbutton.Location = new System.Drawing.Point(168, 15);
            this.DomeConnectbutton.Name = "DomeConnectbutton";
            this.DomeConnectbutton.Size = new System.Drawing.Size(135, 32);
            this.DomeConnectbutton.TabIndex = 2;
            this.DomeConnectbutton.Text = "Connect to Dome";
            this.DomeConnectbutton.UseVisualStyleBackColor = false;
            this.DomeConnectbutton.Click += new System.EventHandler(this.DomeConnectbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.DomeComPortComboBox);
            this.groupBox1.Controls.Add(this.DomeConnectbutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dome Controller";
            // 
            // DomeComPortComboBox
            // 
            this.DomeComPortComboBox.BackColor = System.Drawing.Color.Black;
            this.DomeComPortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomeComPortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeComPortComboBox.ForeColor = System.Drawing.Color.Yellow;
            this.DomeComPortComboBox.FormattingEnabled = true;
            this.DomeComPortComboBox.Location = new System.Drawing.Point(84, 20);
            this.DomeComPortComboBox.Name = "DomeComPortComboBox";
            this.DomeComPortComboBox.Size = new System.Drawing.Size(68, 24);
            this.DomeComPortComboBox.TabIndex = 3;
            this.DomeComPortComboBox.Text = "COM";
            // 
            // DomeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(492, 172);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DomeController";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort DomeSerialPortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DomeConnectbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DomeComPortComboBox;
        private System.IO.Ports.SerialPort DomeSerialPort;
    }
}