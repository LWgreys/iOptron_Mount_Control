namespace iOptron_Mount_Control
{
    partial class FormUserInput2
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
            this._UserEntry2 = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this._UserEntry1 = new System.Windows.Forms.TextBox();
            this.DialogLabel1 = new System.Windows.Forms.Label();
            this.DialogLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _UserEntry2
            // 
            this._UserEntry2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._UserEntry2.BackColor = System.Drawing.Color.Black;
            this._UserEntry2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._UserEntry2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UserEntry2.ForeColor = System.Drawing.Color.Yellow;
            this._UserEntry2.Location = new System.Drawing.Point(119, 54);
            this._UserEntry2.Margin = new System.Windows.Forms.Padding(10);
            this._UserEntry2.MaxLength = 20;
            this._UserEntry2.Name = "_UserEntry2";
            this._UserEntry2.Size = new System.Drawing.Size(96, 22);
            this._UserEntry2.TabIndex = 11;
            this._UserEntry2.WordWrap = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DarkRed;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Yellow;
            this.button_Cancel.Location = new System.Drawing.Point(127, 92);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(10);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(70, 25);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkRed;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.Yellow;
            this.button_OK.Location = new System.Drawing.Point(37, 92);
            this.button_OK.Margin = new System.Windows.Forms.Padding(10);
            this.button_OK.MinimumSize = new System.Drawing.Size(0, 25);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(70, 25);
            this.button_OK.TabIndex = 13;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // _UserEntry1
            // 
            this._UserEntry1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._UserEntry1.BackColor = System.Drawing.Color.Black;
            this._UserEntry1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._UserEntry1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UserEntry1.ForeColor = System.Drawing.Color.Yellow;
            this._UserEntry1.Location = new System.Drawing.Point(119, 19);
            this._UserEntry1.Margin = new System.Windows.Forms.Padding(10);
            this._UserEntry1.MaxLength = 20;
            this._UserEntry1.Name = "_UserEntry1";
            this._UserEntry1.Size = new System.Drawing.Size(96, 22);
            this._UserEntry1.TabIndex = 10;
            this._UserEntry1.WordWrap = false;
            // 
            // DialogLabel1
            // 
            this.DialogLabel1.AutoSize = true;
            this.DialogLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.DialogLabel1.Location = new System.Drawing.Point(14, 21);
            this.DialogLabel1.Name = "DialogLabel1";
            this.DialogLabel1.Size = new System.Drawing.Size(37, 16);
            this.DialogLabel1.TabIndex = 13;
            this.DialogLabel1.Text = "..........";
            this.DialogLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DialogLabel2
            // 
            this.DialogLabel2.AutoSize = true;
            this.DialogLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.DialogLabel2.Location = new System.Drawing.Point(14, 56);
            this.DialogLabel2.Name = "DialogLabel2";
            this.DialogLabel2.Size = new System.Drawing.Size(37, 16);
            this.DialogLabel2.TabIndex = 14;
            this.DialogLabel2.Text = "..........";
            this.DialogLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormUserInput2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(234, 136);
            this.ControlBox = false;
            this.Controls.Add(this.DialogLabel2);
            this.Controls.Add(this.DialogLabel1);
            this.Controls.Add(this._UserEntry1);
            this.Controls.Add(this._UserEntry2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUserInput2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input 2";
            this.Load += new System.EventHandler(this.UserInput2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _UserEntry2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox _UserEntry1;
        private System.Windows.Forms.Label DialogLabel1;
        private System.Windows.Forms.Label DialogLabel2;
    }
}