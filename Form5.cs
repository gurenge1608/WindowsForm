using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsForm
{
    public partial class Form5 : Form
    {
        string res;
        public Form5()
        {
            InitializeComponent();
            
        }

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I0FK0UC\\TANTRAN;Initial Catalog=TANTRAN;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from TACGIA where TACGIA.NHAKHOAHOC_ScientistID = '"+res+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
