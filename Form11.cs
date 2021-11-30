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
    public partial class Form11 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from NHAPHANBIEN where NHAPHANBIEN.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }
            SqlCommand cmd = new SqlCommand("UPDATE NHAPHANBIEN SET NHAPHANBIEN.Emailcoquan = '" + textBox1.Text + "', NHAPHANBIEN.Emailcanhan = '" + textBox2.Text + "',  NHAPHANBIEN.Trinhdo = '" + textBox3.Text + "',  NHAPHANBIEN.Dienthoai = '" + textBox4.Text + "',  NHAPHANBIEN.Coquancongtac = '" + textBox5.Text + "', NHAPHANBIEN.Nghenghiep = '" + textBox6.Text + "', NHAPHANBIEN.Diachi = '" + textBox7.Text + "'  WHERE NHAPHANBIEN.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1) sd.Fill(dt);
            dataGridView1.DataSource = dt;
            BindData();
        }
    }
}
