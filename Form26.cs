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
    public partial class Form26 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, TACGIA_AuthorID FROM BAIBAO", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form26_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public Form26()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!!!!!!!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * FROM BAIBAO WHERE TACGIA_AuthorID = '"+textBox1.Text+"' AND Xuatban = 1", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!!!!!!!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * FROM BAIBAO WHERE TACGIA_AuthorID = '" + textBox1.Text + "' AND Dadang = 1", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
