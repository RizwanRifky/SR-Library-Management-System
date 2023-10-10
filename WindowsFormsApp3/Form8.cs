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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp3
{
    public partial class frmBookReturn : Form
    {
        SqlConnection c1;
        public frmBookReturn()
        {
            InitializeComponent();
            c1 = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            try
            {
                c1.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Book_Member(BookID,MemberID,B_Date,B_Time,ReturnStatus) VALUES('" + int.Parse(cmbBookID2.Text) + "','" + int.Parse(cmbMemberID2.Text) + "','" + Convert.ToString(dtDate2.Value) + "','" + txtTime2.Text + "','" + txtReturnStatus2.Text + "')", c1);
                com.ExecuteNonQuery();
                MessageBox.Show("Successful!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMainMenu5_Click(object sender, EventArgs e)
        {
            frmLogin h1 = new frmLogin();
            this.Hide();
            h1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDisplayMemberBook formDisplayMemberBook = new FormDisplayMemberBook();
            this.Hide();
            formDisplayMemberBook.ShowDialog(); 
        }
    }
}
