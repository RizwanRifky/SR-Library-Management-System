using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmSearch : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection c1;
        public frmSearch()
        {
            InitializeComponent();
            c1 = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            try 
            {
                c1.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Books WHERE Title='" + txtBookName3.Text + "'", c1);
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    SqlCommand com2 = new SqlCommand("SELECT Title FROM Books WHERE Title='" + txtBookName3.Text + "'", c1);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("The book Is available");
                }
                else
                {
                    MessageBox.Show("Sorry The book Is Currently Unavailable ");
                    txtBookName3.Clear();
                }
                c1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            c1.Close();
            frmSelect v1 = new frmSelect();
            this.Hide();
            v1.ShowDialog();

        }

        private void btnBookTable3_Click(object sender, EventArgs e)
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
