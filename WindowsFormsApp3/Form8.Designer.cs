namespace WindowsFormsApp3
{
    partial class frmBookReturn
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
            this.lblBookID5 = new System.Windows.Forms.Label();
            this.lblMemberID3 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblReturnStatus2 = new System.Windows.Forms.Label();
            this.cmbBookID2 = new System.Windows.Forms.ComboBox();
            this.cmbMemberID2 = new System.Windows.Forms.ComboBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.txtReturnStatus2 = new System.Windows.Forms.TextBox();
            this.btnOK3 = new System.Windows.Forms.Button();
            this.dtDate2 = new System.Windows.Forms.DateTimePicker();
            this.btnMainMenu5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookID5
            // 
            this.lblBookID5.AutoSize = true;
            this.lblBookID5.BackColor = System.Drawing.Color.White;
            this.lblBookID5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID5.Location = new System.Drawing.Point(159, 9);
            this.lblBookID5.Name = "lblBookID5";
            this.lblBookID5.Size = new System.Drawing.Size(121, 36);
            this.lblBookID5.TabIndex = 0;
            this.lblBookID5.Text = "Book ID";
            // 
            // lblMemberID3
            // 
            this.lblMemberID3.AutoSize = true;
            this.lblMemberID3.BackColor = System.Drawing.Color.White;
            this.lblMemberID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID3.Location = new System.Drawing.Point(159, 78);
            this.lblMemberID3.Name = "lblMemberID3";
            this.lblMemberID3.Size = new System.Drawing.Size(159, 36);
            this.lblMemberID3.TabIndex = 1;
            this.lblMemberID3.Text = "Member ID";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.BackColor = System.Drawing.Color.White;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(159, 147);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(76, 36);
            this.lblDate2.TabIndex = 2;
            this.lblDate2.Text = "Date";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.Color.White;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(159, 216);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(79, 36);
            this.lblTime2.TabIndex = 3;
            this.lblTime2.Text = "Time";
            // 
            // lblReturnStatus2
            // 
            this.lblReturnStatus2.AutoSize = true;
            this.lblReturnStatus2.BackColor = System.Drawing.Color.White;
            this.lblReturnStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnStatus2.Location = new System.Drawing.Point(159, 290);
            this.lblReturnStatus2.Name = "lblReturnStatus2";
            this.lblReturnStatus2.Size = new System.Drawing.Size(197, 36);
            this.lblReturnStatus2.TabIndex = 4;
            this.lblReturnStatus2.Text = "Return Status";
            // 
            // cmbBookID2
            // 
            this.cmbBookID2.FormattingEnabled = true;
            this.cmbBookID2.Items.AddRange(new object[] {
            "56",
            "80",
            "101",
            "147"});
            this.cmbBookID2.Location = new System.Drawing.Point(472, 21);
            this.cmbBookID2.Name = "cmbBookID2";
            this.cmbBookID2.Size = new System.Drawing.Size(229, 24);
            this.cmbBookID2.TabIndex = 5;
            // 
            // cmbMemberID2
            // 
            this.cmbMemberID2.FormattingEnabled = true;
            this.cmbMemberID2.Items.AddRange(new object[] {
            "90",
            "123",
            "789"});
            this.cmbMemberID2.Location = new System.Drawing.Point(472, 91);
            this.cmbMemberID2.Name = "cmbMemberID2";
            this.cmbMemberID2.Size = new System.Drawing.Size(229, 24);
            this.cmbMemberID2.TabIndex = 6;
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(472, 208);
            this.txtTime2.Multiline = true;
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(229, 50);
            this.txtTime2.TabIndex = 8;
            // 
            // txtReturnStatus2
            // 
            this.txtReturnStatus2.Location = new System.Drawing.Point(472, 280);
            this.txtReturnStatus2.Multiline = true;
            this.txtReturnStatus2.Name = "txtReturnStatus2";
            this.txtReturnStatus2.Size = new System.Drawing.Size(229, 50);
            this.txtReturnStatus2.TabIndex = 9;
            // 
            // btnOK3
            // 
            this.btnOK3.BackColor = System.Drawing.Color.White;
            this.btnOK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK3.Location = new System.Drawing.Point(375, 376);
            this.btnOK3.Name = "btnOK3";
            this.btnOK3.Size = new System.Drawing.Size(100, 62);
            this.btnOK3.TabIndex = 10;
            this.btnOK3.Text = "OK";
            this.btnOK3.UseVisualStyleBackColor = false;
            this.btnOK3.Click += new System.EventHandler(this.btnOK3_Click);
            // 
            // dtDate2
            // 
            this.dtDate2.Location = new System.Drawing.Point(472, 158);
            this.dtDate2.Name = "dtDate2";
            this.dtDate2.Size = new System.Drawing.Size(229, 22);
            this.dtDate2.TabIndex = 11;
            // 
            // btnMainMenu5
            // 
            this.btnMainMenu5.BackColor = System.Drawing.Color.White;
            this.btnMainMenu5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu5.Location = new System.Drawing.Point(12, 376);
            this.btnMainMenu5.Name = "btnMainMenu5";
            this.btnMainMenu5.Size = new System.Drawing.Size(315, 62);
            this.btnMainMenu5.TabIndex = 12;
            this.btnMainMenu5.Text = "Main Menu";
            this.btnMainMenu5.UseVisualStyleBackColor = false;
            this.btnMainMenu5.Click += new System.EventHandler(this.btnMainMenu5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMainMenu5);
            this.Controls.Add(this.dtDate2);
            this.Controls.Add(this.btnOK3);
            this.Controls.Add(this.txtReturnStatus2);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.cmbMemberID2);
            this.Controls.Add(this.cmbBookID2);
            this.Controls.Add(this.lblReturnStatus2);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblMemberID3);
            this.Controls.Add(this.lblBookID5);
            this.Name = "frmBookReturn";
            this.Text = "Book Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookID5;
        private System.Windows.Forms.Label lblMemberID3;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblReturnStatus2;
        private System.Windows.Forms.ComboBox cmbBookID2;
        private System.Windows.Forms.ComboBox cmbMemberID2;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.TextBox txtReturnStatus2;
        private System.Windows.Forms.Button btnOK3;
        private System.Windows.Forms.DateTimePicker dtDate2;
        private System.Windows.Forms.Button btnMainMenu5;
        private System.Windows.Forms.Button button1;
    }
}