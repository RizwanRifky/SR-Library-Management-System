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
    public partial class FormDisplayBookTable : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection conn;
        public FormDisplayBookTable()
        {
            InitializeComponent();
            conn =new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDisplayBookTable_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Books", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Books");
            dataGridView1.DataSource = dataSet.Tables["Books"];
            conn.Close();
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            frmSelect frmSelect = new frmSelect();
            this.Hide();
            frmSelect.ShowDialog();
        }
    }
}
