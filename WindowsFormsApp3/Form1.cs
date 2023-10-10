using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string validUserName = "shimar";
            string validPaaword = "abcd";
            string enteredUserName = txtUserName.Text;
            string enteredPassword = txtPassword.Text; 
            if (enteredUserName == validUserName && enteredPassword == validPaaword) 
            {
                MessageBox.Show("Login Successfully!!!");
                this.Hide();
                frmSelect v1 = new frmSelect();
                v1.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Login Failed. Please chack your UserName and Password");
            }
        }

      
    }
}
