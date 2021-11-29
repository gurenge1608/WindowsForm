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
    public partial class Form6 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao from BAIBAO JOIN ( NHAKHOAHOC JOIN TACGIA on NHAKHOAHOC_ScientistID = ScientistID) on TACGIA_AuthorID = AuthorID where ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }
            SqlCommand cmd = new SqlCommand("UPDATE BAIBAO SET BAIBAO.Tomtat = '" + textBox1.Text + "', BAIBAO.Tieude = '" + textBox2.Text + "',  BAIBAO.Filebaocao = '" + textBox3.Text + "' WHERE BAIBAO.NewsID = '"+textBox4.Text+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1) sd.Fill(dt);
            dataGridView1.DataSource = dt;
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
