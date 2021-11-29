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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(NewsID) FROM BAIBAO WHERE(DATEDIFF(YEAR, BAIBAO.ngaygui, CURRENT_TIMESTAMP) <= 5)", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(BAIBAO_NewsID) FROM NGHIENCUU JOIN BAIBAO ON BAIBAO_NewsID = NewsID WHERE(DATEDIFF(YEAR, BAIBAO.ngaygui, CURRENT_TIMESTAMP) < 5); ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(BAIBAO_NewsID) FROM TONGQUAN JOIN BAIBAO ON BAIBAO_NewsID = NewsID WHERE(DATEDIFF(YEAR, BAIBAO.ngaygui, CURRENT_TIMESTAMP) < 5); ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
