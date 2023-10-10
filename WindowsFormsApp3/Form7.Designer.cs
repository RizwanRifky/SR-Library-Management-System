namespace WindowsFormsApp3
{
    partial class frmBorrow
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
            this.lblBookID4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblReturnStatus = new System.Windows.Forms.Label();
            this.txtReturnStatus = new System.Windows.Forms.TextBox();
            this.cmbBookID = new System.Windows.Forms.ComboBox();
            this.cmbMemberID = new System.Windows.Forms.ComboBox();
            this.DTdate = new System.Windows.Forms.DateTimePicker();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookID4
            // 
            this.lblBookID4.AutoSize = true;
            this.lblBookID4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBookID4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID4.Location = new System.Drawing.Point(162, 18);
            this.lblBookID4.Name = "lblBookID4";
            this.lblBookID4.Size = new System.Drawing.Size(113, 32);
            this.lblBookID4.TabIndex = 0;
            this.lblBookID4.Text = "Book ID";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Green;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(281, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(208, 61);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(162, 92);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(151, 32);
            this.lblMemberID.TabIndex = 3;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(162, 169);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 32);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(162, 250);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 32);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(448, 250);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 32);
            this.txtTime.TabIndex = 8;
            // 
            // lblReturnStatus
            // 
            this.lblReturnStatus.AutoSize = true;
            this.lblReturnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblReturnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnStatus.Location = new System.Drawing.Point(162, 333);
            this.lblReturnStatus.Name = "lblReturnStatus";
            this.lblReturnStatus.Size = new System.Drawing.Size(187, 32);
            this.lblReturnStatus.TabIndex = 9;
            this.lblReturnStatus.Text = "Return Status";
            // 
            // txtReturnStatus
            // 
            this.txtReturnStatus.Location = new System.Drawing.Point(448, 333);
            this.txtReturnStatus.Multiline = true;
            this.txtReturnStatus.Name = "txtReturnStatus";
            this.txtReturnStatus.Size = new System.Drawing.Size(200, 32);
            this.txtReturnStatus.TabIndex = 10;
            // 
            // cmbBookID
            // 
            this.cmbBookID.FormattingEnabled = true;
            this.cmbBookID.Items.AddRange(new object[] {
            "147",
            "56",
            "80",
            "101"});
            this.cmbBookID.Location = new System.Drawing.Point(448, 12);
            this.cmbBookID.Name = "cmbBookID";
            this.cmbBookID.Size = new System.Drawing.Size(200, 24);
            this.cmbBookID.TabIndex = 11;
            // 
            // cmbMemberID
            // 
            this.cmbMemberID.FormattingEnabled = true;
            this.cmbMemberID.Items.AddRange(new object[] {
            "90",
            "123",
            "789"});
            this.cmbMemberID.Location = new System.Drawing.Point(448, 92);
            this.cmbMemberID.Name = "cmbMemberID";
            this.cmbMemberID.Size = new System.Drawing.Size(200, 24);
            this.cmbMemberID.TabIndex = 12;
            // 
            // DTdate
            // 
            this.DTdate.Location = new System.Drawing.Point(448, 169);
            this.DTdate.Name = "DTdate";
            this.DTdate.Size = new System.Drawing.Size(200, 22);
            this.DTdate.TabIndex = 13;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Green;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(12, 409);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(211, 61);
            this.btnMainMenu.TabIndex = 15;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.DTdate);
            this.Controls.Add(this.cmbMemberID);
            this.Controls.Add(this.cmbBookID);
            this.Controls.Add(this.txtReturnStatus);
            this.Controls.Add(this.lblReturnStatus);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblBookID4);
            this.Name = "frmBorrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookID4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblReturnStatus;
        private System.Windows.Forms.TextBox txtReturnStatus;
        private System.Windows.Forms.ComboBox cmbBookID;
        private System.Windows.Forms.ComboBox cmbMemberID;
        private System.Windows.Forms.DateTimePicker DTdate;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button button1;
    }
}