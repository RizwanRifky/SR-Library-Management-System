namespace WindowsFormsApp3
{
    partial class frmAdd
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
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.TxtBookID = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.buttonbooktable = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNOC = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtNOC = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(328, 354);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(166, 58);
            this.btnAdd2.TabIndex = 0;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Cyan;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(164, 58);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(124, 38);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "BookID";
            // 
            // TxtBookID
            // 
            this.TxtBookID.Location = new System.Drawing.Point(461, 57);
            this.TxtBookID.Multiline = true;
            this.TxtBookID.Name = "TxtBookID";
            this.TxtBookID.Size = new System.Drawing.Size(157, 39);
            this.TxtBookID.TabIndex = 2;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Cyan;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(164, 131);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(179, 38);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "BookName";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(461, 131);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(157, 37);
            this.txtBookName.TabIndex = 4;
            // 
            // buttonbooktable
            // 
            this.buttonbooktable.Location = new System.Drawing.Point(667, 29);
            this.buttonbooktable.Name = "buttonbooktable";
            this.buttonbooktable.Size = new System.Drawing.Size(127, 36);
            this.buttonbooktable.TabIndex = 5;
            this.buttonbooktable.Text = "Book Table";
            this.buttonbooktable.UseVisualStyleBackColor = true;
            this.buttonbooktable.Click += new System.EventHandler(this.buttonbooktable_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(36, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNOC
            // 
            this.lblNOC.AutoSize = true;
            this.lblNOC.BackColor = System.Drawing.Color.Cyan;
            this.lblNOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOC.Location = new System.Drawing.Point(164, 203);
            this.lblNOC.Name = "lblNOC";
            this.lblNOC.Size = new System.Drawing.Size(214, 38);
            this.lblNOC.TabIndex = 7;
            this.lblNOC.Text = "No.Of Copies";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Cyan;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(164, 271);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(113, 38);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author";
            // 
            // txtNOC
            // 
            this.txtNOC.Location = new System.Drawing.Point(461, 203);
            this.txtNOC.Multiline = true;
            this.txtNOC.Name = "txtNOC";
            this.txtNOC.Size = new System.Drawing.Size(157, 37);
            this.txtNOC.TabIndex = 9;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(461, 271);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(157, 37);
            this.txtAuthor.TabIndex = 10;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtNOC);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblNOC);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonbooktable);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.TxtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.btnAdd2);
            this.Name = "frmAdd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox TxtBookID;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button buttonbooktable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNOC;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtNOC;
        private System.Windows.Forms.TextBox txtAuthor;
    }
}