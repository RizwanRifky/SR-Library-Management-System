using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmSelect : Form
    {
         public frmSelect()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd s1 = new frmAdd();
            this.Hide();
            s1.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmRemove d1 = new frmRemove();
            this.Hide();
            d1.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch f1 = new frmSearch();
            this.Hide();
            f1.ShowDialog();
        }

        private void btnMainMenu3_Click(object sender, EventArgs e)
        {
            frmLogin h1 = new frmLogin();
            this.Hide();
            h1.ShowDialog();
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            frmRegister b1 = new frmRegister();
            this.Hide();
            b1.ShowDialog();
        }
    }
}
