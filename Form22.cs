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

    public partial class Form22 : Form
    {
        string res;

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form22()
        {
            InitializeComponent();
        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from BAIBAO", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!!!!!!!!!!!!!!!!!!!");
            }
            else if (radioButton1.Checked && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update BAIBAO SET BAIBAO.Phanbien = 1, BAIBAO.Phanhoiphanbien = 0, BAIBAO.Hoantatphanbien = 0, BAIBAO.Xuatban = 0, BAIBAO.Dadang = 0 WHERE BAIBAO.NewsID = '" + textBox1.Text+"'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                BindData();
            }
            else if (radioButton2.Checked && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update BAIBAO SET BAIBAO.Phanbien = 0, BAIBAO.Phanhoiphanbien = 1, BAIBAO.Hoantatphanbien = 0, BAIBAO.Xuatban = 0, BAIBAO.Dadang = 0 WHERE BAIBAO.NewsID = '" + textBox1.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                BindData();
            }
            else if (radioButton3.Checked && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update BAIBAO SET BAIBAO.Phanbien = 0, BAIBAO.Phanhoiphanbien = 0, BAIBAO.Hoantatphanbien = 1, BAIBAO.Xuatban = 0, BAIBAO.Dadang = 0 WHERE BAIBAO.NewsID = '" + textBox1.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                BindData();

            }
            else if (radioButton4.Checked && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update BAIBAO SET BAIBAO.Phanbien = 0, BAIBAO.Phanhoiphanbien = 0, BAIBAO.Hoantatphanbien = 0, BAIBAO.Xuatban = 1, BAIBAO.Dadang = 0 WHERE BAIBAO.NewsID = '" + textBox1.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                BindData();

            }
            else if (radioButton5.Checked && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update BAIBAO SET BAIBAO.Phanbien = 0, BAIBAO.Phanhoiphanbien = 0, BAIBAO.Hoantatphanbien = 0, BAIBAO.Xuatban = 0, BAIBAO.Dadang = 1 WHERE BAIBAO.NewsID = '" + textBox1.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                BindData();

            }

        }
    }
}
