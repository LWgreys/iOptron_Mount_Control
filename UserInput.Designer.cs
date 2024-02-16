namespace iOptron_Mount_Control
{
    partial class formUserInput
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
            this._UserEntry = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this._EntryDialog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _UserEntry
            // 
            this._UserEntry.BackColor = System.Drawing.Color.Black;
            this._UserEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._UserEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UserEntry.ForeColor = System.Drawing.Color.Yellow;
            this._UserEntry.Location = new System.Drawing.Point(19, 54);
            this._UserEntry.Margin = new System.Windows.Forms.Padding(10);
            this._UserEntry.MaxLength = 20;
            this._UserEntry.Name = "_UserEntry";
            this._UserEntry.Size = new System.Drawing.Size(160, 22);
            this._UserEntry.TabIndex = 5;
            this._UserEntry.WordWrap = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DarkRed;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Yellow;
            this.button_Cancel.Location = new System.Drawing.Point(109, 89);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(10);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(70, 25);
            this.button_Cancel.TabIndex = 7;
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
            this.button_OK.Location = new System.Drawing.Point(19, 89);
            this.button_OK.Margin = new System.Windows.Forms.Padding(10);
            this.button_OK.MinimumSize = new System.Drawing.Size(0, 25);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(70, 25);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // _EntryDialog
            // 
            this._EntryDialog.AutoSize = true;
            this._EntryDialog.BackColor = System.Drawing.Color.DarkRed;
            this._EntryDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._EntryDialog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._EntryDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._EntryDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._EntryDialog.ForeColor = System.Drawing.Color.Yellow;
            this._EntryDialog.Location = new System.Drawing.Point(19, 19);
            this._EntryDialog.Margin = new System.Windows.Forms.Padding(10);
            this._EntryDialog.MinimumSize = new System.Drawing.Size(160, 25);
            this._EntryDialog.Name = "_EntryDialog";
            this._EntryDialog.Size = new System.Drawing.Size(160, 25);
            this._EntryDialog.TabIndex = 4;
            this._EntryDialog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(199, 136);
            this.ControlBox = false;
            this.Controls.Add(this._UserEntry);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this._EntryDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "formUserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input";
            this.Load += new System.EventHandler(this.formUserInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _UserEntry;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label _EntryDialog;
    }
}