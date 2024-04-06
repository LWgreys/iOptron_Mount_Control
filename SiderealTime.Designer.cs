namespace iOptron_Mount_Control
{
    partial class Sidereal_Form
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
            this.button_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.utc_sidereal = new System.Windows.Forms.Label();
            this.local_sidereal = new System.Windows.Forms.Label();
            this.timer_Sidereal = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.BackColor = System.Drawing.Color.Maroon;
            this.button_OK.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_OK.FlatAppearance.BorderSize = 2;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(100, 62);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 30);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "UTC Sidereal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local Sidereal";
            // 
            // utc_sidereal
            // 
            this.utc_sidereal.AutoSize = true;
            this.utc_sidereal.BackColor = System.Drawing.Color.Maroon;
            this.utc_sidereal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.utc_sidereal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utc_sidereal.Location = new System.Drawing.Point(113, 9);
            this.utc_sidereal.MinimumSize = new System.Drawing.Size(150, 2);
            this.utc_sidereal.Name = "utc_sidereal";
            this.utc_sidereal.Size = new System.Drawing.Size(150, 18);
            this.utc_sidereal.TabIndex = 3;
            this.utc_sidereal.Text = "label3";
            // 
            // local_sidereal
            // 
            this.local_sidereal.AutoSize = true;
            this.local_sidereal.BackColor = System.Drawing.Color.Maroon;
            this.local_sidereal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.local_sidereal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.local_sidereal.Location = new System.Drawing.Point(113, 35);
            this.local_sidereal.MinimumSize = new System.Drawing.Size(150, 2);
            this.local_sidereal.Name = "local_sidereal";
            this.local_sidereal.Size = new System.Drawing.Size(150, 18);
            this.local_sidereal.TabIndex = 4;
            this.local_sidereal.Text = "label4";
            // 
            // timer_Sidereal
            // 
            this.timer_Sidereal.Interval = 1000;
            this.timer_Sidereal.Tick += new System.EventHandler(this.readSiderealTime);
            // 
            // Sidereal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(275, 98);
            this.ControlBox = false;
            this.Controls.Add(this.local_sidereal);
            this.Controls.Add(this.utc_sidereal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sidereal_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sidereal Time";
            this.Load += new System.EventHandler(this.Sidereal_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label utc_sidereal;
        private System.Windows.Forms.Label local_sidereal;
        private System.Windows.Forms.Timer timer_Sidereal;
    }
}