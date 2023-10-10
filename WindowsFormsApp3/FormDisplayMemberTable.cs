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
    public partial class FormDisplayMemberTable : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlConnection conn;
        public FormDisplayMemberTable()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=SRLibrary;Integrated Security=True");
        }

        private void FormDisplayMemberTable_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM L_Member", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "L_Member");
            dataGridView1.DataSource = dataSet.Tables["L_Member"];
            conn.Close();
        }

        private void btnBack6_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }
    }
}
