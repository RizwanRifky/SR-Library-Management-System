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
    public partial class frmRemove : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection c1;
        
        public frmRemove()
        {
            InitializeComponent();
            c1 = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("select * from Books", c1);
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                   c1.Open();
                   SqlCommand com2 = new SqlCommand("DELETE FROM Books WHERE BookID = '" + (txtBookID2.Text) + "'", c1);
                   com2.ExecuteNonQuery();
                   MessageBox.Show("Deleteded Successfully!!!");
                }
                else
                {
                    MessageBox.Show("Invalid Book ID");
                    txtBookID2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookTable2_Click(object sender, EventArgs e)
        {
            FormDisplayBookTable formDisplayBookTable = new FormDisplayBookTable();
            this.Hide();
            formDisplayBookTable.Show();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            c1.Close();
            frmSelect v1 = new frmSelect();
            this.Hide();
            v1.ShowDialog();
        }
    }
}
