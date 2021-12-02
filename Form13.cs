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
    public partial class Form13 : Form
    {
        string res;

        public void pass(string qs)
        {
            res = qs;
        }
        public Form13()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại bài báo");
            }
            else if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN NGHIENCUU ON NewsID = NGHIENCUU.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN PHANBIENSACH ON NewsID = PHANBIENSACH.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN TONGQUAN ON NewsID = TONGQUAN.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        
        bool isChecked = false;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
       
            if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN NGHIENCUU ON NewsID = NGHIENCUU.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN NGHIENCUU ON NewsID = NGHIENCUU.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN PHANBIENSACH ON NewsID = PHANBIENSACH.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN PHANBIENSACH ON NewsID = PHANBIENSACH.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN TONGQUAN ON NewsID = TONGQUAN.BAIBAO_NewsID where NHAKHOAHOC_ScientistID = '" + res + "'  AND (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN TONGQUAN ON NewsID = TONGQUAN.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại bài báo");
            }
            else if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN NGHIENCUU ON NewsID = NGHIENCUU.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN PHANBIENSACH ON NewsID = PHANBIENSACH.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Dodai, ngaygui from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN TONGQUAN ON NewsID = TONGQUAN.BAIBAO_NewsID where (NHAKHOAHOC_ScientistID = '" + res + "' AND (Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang =1) AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
