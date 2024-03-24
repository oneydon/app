namespace ResBookApp
{
    partial class FrmReservation
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
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.cboO = new System.Windows.Forms.ComboBox();
            this.cboDA = new System.Windows.Forms.ComboBox();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.dtpDT = new System.Windows.Forms.DateTimePicker();
            this.txtRN = new System.Windows.Forms.TextBox();
            this.txtHN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(120, 35);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(200, 20);
            this.txtPN.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "PhoneNumber";
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(407, 352);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 29;
            this.btnC.Text = "Cancel";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(166, 352);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 28;
            this.btnS.Text = "Submit";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // cboO
            // 
            this.cboO.FormattingEnabled = true;
            this.cboO.Items.AddRange(new object[] {
            "Birthday",
            "Anniversary",
            "Graduation",
            "Business Meeting"});
            this.cboO.Location = new System.Drawing.Point(120, 254);
            this.cboO.Name = "cboO";
            this.cboO.Size = new System.Drawing.Size(200, 21);
            this.cboO.TabIndex = 27;
            // 
            // cboDA
            // 
            this.cboDA.FormattingEnabled = true;
            this.cboDA.Items.AddRange(new object[] {
            "main dining room",
            "patio",
            "bar area",
            "private dining room"});
            this.cboDA.Location = new System.Drawing.Point(120, 195);
            this.cboDA.Name = "cboDA";
            this.cboDA.Size = new System.Drawing.Size(200, 21);
            this.cboDA.TabIndex = 26;
            // 
            // txtPS
            // 
            this.txtPS.Location = new System.Drawing.Point(120, 149);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(100, 20);
            this.txtPS.TabIndex = 25;
            // 
            // dtpDT
            // 
            this.dtpDT.Location = new System.Drawing.Point(120, 100);
            this.dtpDT.Name = "dtpDT";
            this.dtpDT.Size = new System.Drawing.Size(200, 20);
            this.dtpDT.TabIndex = 24;
            // 
            // txtRN
            // 
            this.txtRN.Location = new System.Drawing.Point(120, 67);
            this.txtRN.Name = "txtRN";
            this.txtRN.Size = new System.Drawing.Size(100, 20);
            this.txtRN.TabIndex = 23;
            // 
            // txtHN
            // 
            this.txtHN.Location = new System.Drawing.Point(120, 2);
            this.txtHN.Name = "txtHN";
            this.txtHN.Size = new System.Drawing.Size(100, 20);
            this.txtHN.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Occasion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "DennyArea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PartySize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "DateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "RestaurantName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "HostName";
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.cboO);
            this.Controls.Add(this.cboDA);
            this.Controls.Add(this.txtPS);
            this.Controls.Add(this.dtpDT);
            this.Controls.Add(this.txtRN);
            this.Controls.Add(this.txtHN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReservation";
            this.Text = "FrmReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.ComboBox cboO;
        private System.Windows.Forms.ComboBox cboDA;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.DateTimePicker dtpDT;
        private System.Windows.Forms.TextBox txtRN;
        private System.Windows.Forms.TextBox txtHN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}