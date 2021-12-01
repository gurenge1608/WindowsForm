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
    public partial class Form25 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * FROM BAIBAO", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form25_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public Form25()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại bài báo !!!!!!!!!!");
            }
            else if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
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
                MessageBox.Show("Vui lòng chọn loại bài báo !!!!!!!!!!");
            }
            else if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else if (radioButton4.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else if (radioButton4.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else if (radioButton4.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Phanbien = 1 OR Phanhoiphanbien = 1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton5.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Xuatban=1)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton6.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại bài báo !!!!!!!!!!");
            }
            else if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN NGHIENCUU ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN PHANBIENSACH ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("select NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, ngaygui FROM BAIBAO JOIN TONGQUAN ON NewsID = BAIBAO_NewsID WHERE (Dadang = 1 AND DATEDIFF(year, ngaygui, CURRENT_TIMESTAMP) <= 3)", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
