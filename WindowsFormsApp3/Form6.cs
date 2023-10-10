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
    public partial class frmRegister : Form
    {
        SqlConnection c1;
        public frmRegister()
        {
            InitializeComponent();
            c1 = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                c1.Open();
                SqlCommand com = new SqlCommand("INSERT INTO L_Member(MemberID,M_Name,M_Phone_NO,[M_Phone_NO 2],M_Address) VALUES('" + int.Parse(txtMemberID.Text) + "','" + txtName.Text + "','" + txtContactNo.Text + "','" + txtContactNum.Text + "','" + txtAddress.Text + "')", c1);
                com.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

      

        private void btnBorrow2_Click(object sender, EventArgs e)
        {
            frmBorrow l1 = new frmBorrow();
            this.Hide();
            l1.ShowDialog();
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            frmBookReturn k1 = new frmBookReturn();
            this.Hide();
            k1.ShowDialog();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRLibraryDataSet.L_Member' table. You can move, or remove it, as needed.
            this.l_MemberTableAdapter.Fill(this.sRLibraryDataSet.L_Member);

        }

        private void buttonMemberTable_Click(object sender, EventArgs e)
        {
            FormDisplayMemberTable formDisplayMemberTable = new FormDisplayMemberTable();
            this.Hide();
            formDisplayMemberTable.ShowDialog();
        }

        private void btnBack7_Click(object sender, EventArgs e)
        {
            c1.Close();
            frmSelect v1 = new frmSelect();
            this.Hide();
            v1.ShowDialog();
        }
    }
}
