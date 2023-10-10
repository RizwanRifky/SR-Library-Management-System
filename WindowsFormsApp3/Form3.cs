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
    public partial class frmAdd : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection c1;
        public frmAdd()
        {
            InitializeComponent();
            c1 = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            
            try
            {
                c1.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Books(BookID,Title,NumOfCopies,Author) VALUES('" + int.Parse(TxtBookID.Text)+"','"+ txtBookName.Text + "','"+ int.Parse(txtNOC.Text) +"','"+ txtAuthor.Text + "')", c1);
                com.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            

            
        }

        private void buttonbooktable_Click(object sender, EventArgs e)
        {
            FormDisplayBookTable formDisplayBookTable = new FormDisplayBookTable();
            this.Hide();
            formDisplayBookTable.Show();

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            c1.Close();
            frmSelect v1 = new frmSelect();
            this.Hide();
            v1.ShowDialog();
        }
    }
}
