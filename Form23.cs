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
    public partial class Form23 : Form
    {
        string res;

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        public Form23()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select BPBID, Danhchotacgia, Danhchobanbientap, Noidung, Ngaythongbaodentacgia, Cacchitietkhac, Chapnhan, Tuchoi, Suadoiit, Suadoinhieu, BAIBAO_NewsID from BAIPHANBIEN JOIN BAIBAO ON BAIBAO_NewsID = NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void Form23_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        public bool checkcolumn(string str)
        {
            SqlCommand cmd = new SqlCommand("select BPBID, Danhchotacgia, Danhchobanbientap, Noidung, Ngaythongbaodentacgia, Cacchitietkhac, Chapnhan, Tuchoi, Suadoiit, Suadoinhieu, BAIBAO_NewsID from BAIPHANBIEN JOIN BAIBAO ON BAIBAO_NewsID = NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (str == dr[0].ToString())
                {
                    return true;
                }
                else
                {
                    break;
                }
            }
            return false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || (!radioButton5.Checked && !radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!!!!!!!!!!!!!!!!!!!");
            }
            else if (radioButton5.Checked && textBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE T1 SET T1.Chapnhan = 1, T1.Tuchoi = 0, T1.Suadoiit = 0, T1.Suadoinhieu = 0 FROM BAIPHANBIEN as T1 JOIN BAIBAO as T2 ON T1.BAIBAO_NewsID = T2.NewsID WHERE (T2.Phanbien = 1 OR T2.Phanhoiphanbien = 1) AND T1.BPBID = '" + textBox2.Text + "' ", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (checkcolumn(textBox2.Text)) sd.Fill(dt); 
                else
                {
                    MessageBox.Show("Đã nhập sai ID !!!!!!!!!!!");
                }
                dataGridView2.DataSource = dt;
                BindData();
            }
            else if (radioButton6.Checked && textBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE T1 SET T1.Chapnhan = 0, T1.Tuchoi = 1, T1.Suadoiit = 0, T1.Suadoinhieu = 0 FROM BAIPHANBIEN as T1 JOIN BAIBAO as T2 ON T1.BAIBAO_NewsID = T2.NewsID WHERE (T2.Phanbien = 1 OR T2.Phanhoiphanbien = 1) AND T1.BPBID = '" + textBox2.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (checkcolumn(textBox2.Text)) sd.Fill(dt);
                else
                {
                    MessageBox.Show("Đã nhập sai ID !!!!!!!!!!!");
                }
                dataGridView2.DataSource = dt;
                BindData();
            }
            else if (radioButton7.Checked && textBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE T1 SET T1.Chapnhan = 0, T1.Tuchoi = 0, T1.Suadoiit = 1, T1.Suadoinhieu = 0 FROM BAIPHANBIEN as T1 JOIN BAIBAO as T2 ON T1.BAIBAO_NewsID = T2.NewsID WHERE (T2.Phanbien = 1 OR T2.Phanhoiphanbien = 1) AND T1.BPBID = '" + textBox2.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (checkcolumn(textBox2.Text)) sd.Fill(dt);
                else
                {
                    MessageBox.Show("Đã nhập sai ID !!!!!!!!!!!");
                }
                dataGridView2.DataSource = dt;
                BindData();

            }
            else if (radioButton8.Checked && textBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE T1 SET T1.Chapnhan = 0, T1.Tuchoi = 0, T1.Suadoiit = 0, T1.Suadoinhieu = 1 FROM BAIPHANBIEN as T1 JOIN BAIBAO as T2 ON T1.BAIBAO_NewsID = T2.NewsID WHERE (T2.Phanbien = 1 OR T2.Phanhoiphanbien = 1) AND T1.BPBID = '" + textBox2.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (checkcolumn(textBox2.Text)) sd.Fill(dt);
                else
                {
                    MessageBox.Show("Đã nhập sai ID !!!!!!!!!!!");
                }
                dataGridView2.DataSource = dt;
                BindData();

            }
        }
    }
}
