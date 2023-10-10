namespace WindowsFormsApp3
{
    partial class frmRemove
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
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.lblBookID2 = new System.Windows.Forms.Label();
            this.txtBookID2 = new System.Windows.Forms.TextBox();
            this.btnBookTable2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemove2
            // 
            this.btnRemove2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove2.Location = new System.Drawing.Point(294, 268);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(203, 69);
            this.btnRemove2.TabIndex = 0;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = false;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // lblBookID2
            // 
            this.lblBookID2.AutoSize = true;
            this.lblBookID2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBookID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID2.Location = new System.Drawing.Point(170, 157);
            this.lblBookID2.Name = "lblBookID2";
            this.lblBookID2.Size = new System.Drawing.Size(133, 38);
            this.lblBookID2.TabIndex = 3;
            this.lblBookID2.Text = "Book ID";
            // 
            // txtBookID2
            // 
            this.txtBookID2.Location = new System.Drawing.Point(466, 157);
            this.txtBookID2.Multiline = true;
            this.txtBookID2.Name = "txtBookID2";
            this.txtBookID2.Size = new System.Drawing.Size(181, 37);
            this.txtBookID2.TabIndex = 4;
            // 
            // btnBookTable2
            // 
            this.btnBookTable2.Location = new System.Drawing.Point(658, 32);
            this.btnBookTable2.Name = "btnBookTable2";
            this.btnBookTable2.Size = new System.Drawing.Size(111, 30);
            this.btnBookTable2.TabIndex = 5;
            this.btnBookTable2.Text = "Book Table";
            this.btnBookTable2.UseVisualStyleBackColor = true;
            this.btnBookTable2.Click += new System.EventHandler(this.btnBookTable2_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(52, 373);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(86, 27);
            this.btnBack2.TabIndex = 6;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnBookTable2);
            this.Controls.Add(this.txtBookID2);
            this.Controls.Add(this.lblBookID2);
            this.Controls.Add(this.btnRemove2);
            this.Name = "frmRemove";
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Label lblBookID2;
        private System.Windows.Forms.TextBox txtBookID2;
        private System.Windows.Forms.Button btnBookTable2;
        private System.Windows.Forms.Button btnBack2;
    }
}