namespace iOptron_Mount_Control
{
    partial class Slew2Object
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxObject = new System.Windows.Forms.TextBox();
            this.buttonSearchSIMBAD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RA_Coordinate = new System.Windows.Forms.Label();
            this.DEC_Coordinate = new System.Windows.Forms.Label();
            this.buttonCancelSlew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Object Identifier :";
            // 
            // textboxObject
            // 
            this.textboxObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxObject.BackColor = System.Drawing.Color.Black;
            this.textboxObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxObject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxObject.ForeColor = System.Drawing.Color.Yellow;
            this.textboxObject.Location = new System.Drawing.Point(159, 12);
            this.textboxObject.Name = "textboxObject";
            this.textboxObject.Size = new System.Drawing.Size(204, 23);
            this.textboxObject.TabIndex = 1;
            // 
            // buttonSearchSIMBAD
            // 
            this.buttonSearchSIMBAD.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearchSIMBAD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearchSIMBAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSIMBAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchSIMBAD.Location = new System.Drawing.Point(12, 40);
            this.buttonSearchSIMBAD.Name = "buttonSearchSIMBAD";
            this.buttonSearchSIMBAD.Size = new System.Drawing.Size(351, 54);
            this.buttonSearchSIMBAD.TabIndex = 2;
            this.buttonSearchSIMBAD.Text = "Search SIMBAD";
            this.buttonSearchSIMBAD.UseVisualStyleBackColor = false;
            this.buttonSearchSIMBAD.Click += new System.EventHandler(this.buttonSearchSIMBAD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "RA Coordenate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEC Coordenate :";
            // 
            // RA_Coordinate
            // 
            this.RA_Coordinate.AutoSize = true;
            this.RA_Coordinate.BackColor = System.Drawing.Color.Maroon;
            this.RA_Coordinate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RA_Coordinate.Location = new System.Drawing.Point(135, 107);
            this.RA_Coordinate.MinimumSize = new System.Drawing.Size(130, 0);
            this.RA_Coordinate.Name = "RA_Coordinate";
            this.RA_Coordinate.Size = new System.Drawing.Size(130, 16);
            this.RA_Coordinate.TabIndex = 5;
            // 
            // DEC_Coordinate
            // 
            this.DEC_Coordinate.AutoSize = true;
            this.DEC_Coordinate.BackColor = System.Drawing.Color.Maroon;
            this.DEC_Coordinate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEC_Coordinate.Location = new System.Drawing.Point(135, 133);
            this.DEC_Coordinate.MinimumSize = new System.Drawing.Size(130, 0);
            this.DEC_Coordinate.Name = "DEC_Coordinate";
            this.DEC_Coordinate.Size = new System.Drawing.Size(130, 16);
            this.DEC_Coordinate.TabIndex = 6;
            // 
            // buttonCancelSlew
            // 
            this.buttonCancelSlew.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelSlew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancelSlew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelSlew.Location = new System.Drawing.Point(288, 107);
            this.buttonCancelSlew.Name = "buttonCancelSlew";
            this.buttonCancelSlew.Size = new System.Drawing.Size(75, 42);
            this.buttonCancelSlew.TabIndex = 7;
            this.buttonCancelSlew.Text = "Cancel Slew";
            this.buttonCancelSlew.UseVisualStyleBackColor = false;
            this.buttonCancelSlew.Click += new System.EventHandler(this.buttonCancelSlew_Click);
            // 
            // Slew2Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(375, 160);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelSlew);
            this.Controls.Add(this.DEC_Coordinate);
            this.Controls.Add(this.RA_Coordinate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchSIMBAD);
            this.Controls.Add(this.textboxObject);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Slew2Object";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slew to Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxObject;
        private System.Windows.Forms.Button buttonSearchSIMBAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RA_Coordinate;
        private System.Windows.Forms.Label DEC_Coordinate;
        private System.Windows.Forms.Button buttonCancelSlew;
    }
}