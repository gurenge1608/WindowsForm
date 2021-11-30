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
    public partial class Form14 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        public Form14()
        {
            InitializeComponent();
        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where NHAKHOAHOC_ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Phanbien = 1 OR Phanhoiphanbien = 1))", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton5.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Phanbien = 1 OR Phanhoiphanbien = 1) AND BAIBAO.TACGIA_AuthorID = '"+textBox1.Text+"')", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (radioButton6.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3 AND BAIBAO.TACGIA_AuthorID = '" + textBox1.Text + "')", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND BAIBAO.TACGIA_AuthorID = '" + textBox1.Text + "')", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID tác giả !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
