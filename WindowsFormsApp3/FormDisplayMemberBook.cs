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
    public partial class FormDisplayMemberBook : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection conn;
        public FormDisplayMemberBook()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void FormDisplayMemberBook_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Book_Member", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Book_Member");
            dataGridView1.DataSource = dataSet.Tables["Book_Member"];
            conn.Close();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }
    }
}
