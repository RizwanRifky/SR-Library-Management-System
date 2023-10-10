namespace WindowsFormsApp3
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBorrow2 = new System.Windows.Forms.Button();
            this.btnBookReturn = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.buttonMemberTable = new System.Windows.Forms.Button();
            this.lMemberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sRLibraryDataSet = new WindowsFormsApp3.SRLibraryDataSet();
            this.lMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l_MemberTableAdapter = new WindowsFormsApp3.SRLibraryDataSetTableAdapters.L_MemberTableAdapter();
            this.lMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblContactNo2 = new System.Windows.Forms.Label();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.btnBack7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(348, 411);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 64);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.Color.Green;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(166, 44);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(159, 36);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(593, 42);
            this.txtMemberID.Multiline = true;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(221, 38);
            this.txtMemberID.TabIndex = 2;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Green;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(166, 196);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(164, 36);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(593, 344);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 36);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Green;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(166, 344);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(126, 36);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Green;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(166, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 36);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(593, 118);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 36);
            this.txtName.TabIndex = 9;
            // 
            // btnBorrow2
            // 
            this.btnBorrow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow2.Location = new System.Drawing.Point(23, 411);
            this.btnBorrow2.Name = "btnBorrow2";
            this.btnBorrow2.Size = new System.Drawing.Size(220, 64);
            this.btnBorrow2.TabIndex = 10;
            this.btnBorrow2.Text = "Borrow";
            this.btnBorrow2.UseVisualStyleBackColor = false;
            this.btnBorrow2.Click += new System.EventHandler(this.btnBorrow2_Click);
            // 
            // btnBookReturn
            // 
            this.btnBookReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBookReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReturn.Location = new System.Drawing.Point(668, 411);
            this.btnBookReturn.Name = "btnBookReturn";
            this.btnBookReturn.Size = new System.Drawing.Size(255, 64);
            this.btnBookReturn.TabIndex = 11;
            this.btnBookReturn.Text = "Book Return";
            this.btnBookReturn.UseVisualStyleBackColor = false;
            this.btnBookReturn.Click += new System.EventHandler(this.btnBookReturn_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(593, 196);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(221, 36);
            this.txtContactNo.TabIndex = 12;
            // 
            // buttonMemberTable
            // 
            this.buttonMemberTable.Location = new System.Drawing.Point(2, 2);
            this.buttonMemberTable.Name = "buttonMemberTable";
            this.buttonMemberTable.Size = new System.Drawing.Size(114, 36);
            this.buttonMemberTable.TabIndex = 13;
            this.buttonMemberTable.Text = "Member Table";
            this.buttonMemberTable.UseVisualStyleBackColor = true;
            this.buttonMemberTable.Click += new System.EventHandler(this.buttonMemberTable_Click);
            // 
            // lMemberBindingSource2
            // 
            this.lMemberBindingSource2.DataMember = "L_Member";
            this.lMemberBindingSource2.DataSource = this.sRLibraryDataSet;
            // 
            // sRLibraryDataSet
            // 
            this.sRLibraryDataSet.DataSetName = "SRLibraryDataSet";
            this.sRLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lMemberBindingSource
            // 
            this.lMemberBindingSource.DataMember = "L_Member";
            this.lMemberBindingSource.DataSource = this.sRLibraryDataSet;
            // 
            // l_MemberTableAdapter
            // 
            this.l_MemberTableAdapter.ClearBeforeFill = true;
            // 
            // lMemberBindingSource1
            // 
            this.lMemberBindingSource1.DataMember = "L_Member";
            this.lMemberBindingSource1.DataSource = this.sRLibraryDataSet;
            // 
            // lblContactNo2
            // 
            this.lblContactNo2.AutoSize = true;
            this.lblContactNo2.BackColor = System.Drawing.Color.Green;
            this.lblContactNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo2.Location = new System.Drawing.Point(166, 267);
            this.lblContactNo2.Name = "lblContactNo2";
            this.lblContactNo2.Size = new System.Drawing.Size(189, 36);
            this.lblContactNo2.TabIndex = 14;
            this.lblContactNo2.Text = "Contact No 2";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(593, 267);
            this.txtContactNum.Multiline = true;
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(221, 36);
            this.txtContactNum.TabIndex = 15;
            // 
            // btnBack7
            // 
            this.btnBack7.Location = new System.Drawing.Point(840, 12);
            this.btnBack7.Name = "btnBack7";
            this.btnBack7.Size = new System.Drawing.Size(120, 36);
            this.btnBack7.TabIndex = 16;
            this.btnBack7.Text = "Back";
            this.btnBack7.UseVisualStyleBackColor = true;
            this.btnBack7.Click += new System.EventHandler(this.btnBack7_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(966, 501);
            this.Controls.Add(this.btnBack7);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.lblContactNo2);
            this.Controls.Add(this.buttonMemberTable);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.btnBookReturn);
            this.Controls.Add(this.btnBorrow2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMemberBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBorrow2;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button buttonMemberTable;
        private SRLibraryDataSet sRLibraryDataSet;
        private System.Windows.Forms.BindingSource lMemberBindingSource;
        private SRLibraryDataSetTableAdapters.L_MemberTableAdapter l_MemberTableAdapter;
        private System.Windows.Forms.BindingSource lMemberBindingSource1;
        private System.Windows.Forms.BindingSource lMemberBindingSource2;
        private System.Windows.Forms.Label lblContactNo2;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Button btnBack7;
    }
}