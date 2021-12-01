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
    public partial class Form27 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form27()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(NewsID) as soluong FROM BAIBAO WHERE BAIBAO.Phanbien = 1; ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(NewsID) as soluong FROM BAIBAO WHERE BAIBAO.Phanhoiphanbien = 1; ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(NewsID) as soluong FROM BAIBAO WHERE BAIBAO.Xuatban = 1; ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }
    }
}
