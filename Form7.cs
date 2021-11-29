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
    public partial class Form7 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from TACGIA where TACGIA.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }
            SqlCommand cmd = new SqlCommand("SELECT BAIBAO_NewsID, tacgiasangtac, Phanbien, Phanhoiphanbien, Hoantatphanbien, Xuatban, Dadang" +
            "  FROM BAIBAO_TACGIASANGTAC JOIN BAIBAO ON BAIBAO_NewsID = NewsID WHERE BAIBAO_NewsID = '"+textBox1.Text+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1) sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
