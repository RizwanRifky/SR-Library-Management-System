namespace WindowsFormsApp3
{
    partial class frmSearch
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
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.lblBookName3 = new System.Windows.Forms.Label();
            this.txtBookName3 = new System.Windows.Forms.TextBox();
            this.btnBookTable3 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.Location = new System.Drawing.Point(303, 244);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(188, 58);
            this.btnSearch2.TabIndex = 0;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // lblBookName3
            // 
            this.lblBookName3.AutoSize = true;
            this.lblBookName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBookName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName3.Location = new System.Drawing.Point(173, 136);
            this.lblBookName3.Name = "lblBookName3";
            this.lblBookName3.Size = new System.Drawing.Size(188, 38);
            this.lblBookName3.TabIndex = 3;
            this.lblBookName3.Text = "Book Name";
            // 
            // txtBookName3
            // 
            this.txtBookName3.Location = new System.Drawing.Point(471, 136);
            this.txtBookName3.Multiline = true;
            this.txtBookName3.Name = "txtBookName3";
            this.txtBookName3.Size = new System.Drawing.Size(217, 38);
            this.txtBookName3.TabIndex = 4;
            // 
            // btnBookTable3
            // 
            this.btnBookTable3.Location = new System.Drawing.Point(635, 24);
            this.btnBookTable3.Name = "btnBookTable3";
            this.btnBookTable3.Size = new System.Drawing.Size(142, 23);
            this.btnBookTable3.TabIndex = 5;
            this.btnBookTable3.Text = "Book Table";
            this.btnBookTable3.UseVisualStyleBackColor = true;
            this.btnBookTable3.Click += new System.EventHandler(this.btnBookTable3_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(67, 369);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(86, 41);
            this.btnBack2.TabIndex = 6;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnBookTable3);
            this.Controls.Add(this.txtBookName3);
            this.Controls.Add(this.lblBookName3);
            this.Controls.Add(this.btnSearch2);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label lblBookName3;
        private System.Windows.Forms.TextBox txtBookName3;
        private System.Windows.Forms.Button btnBookTable3;
        private System.Windows.Forms.Button btnBack2;
    }
}