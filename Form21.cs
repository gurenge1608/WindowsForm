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
    public partial class Form21 : Form
    {
        string res;

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select BAIPHANBIEN_BPBID, Ngayphancong, Tennguoiphanbien, Banbientap_BBTID from (PHANCONGPHANBIEN JOIN BANBIENTAP ON BANBIENTAP_BBTID = BBTID) where BANBIENTAP.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public bool checkcolumn(string str)
        {
            SqlCommand cmd = new SqlCommand("select BAIPHANBIEN_BPBID, Ngayphancong, Tennguoiphanbien, Banbientap_BBTID FROM (PHANCONGPHANBIEN JOIN BANBIENTAP ON BANBIENTAP_BBTID = BBTID) WHERE BANBIENTAP.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
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
        private void Form21_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }

            SqlCommand cmd = new SqlCommand("UPDATE PHANCONGPHANBIEN SET PHANCONGPHANBIEN.Ngayphancong = '" + textBox1.Text + "', PHANCONGPHANBIEN.Tennguoiphanbien = '" + textBox2.Text + "' WHERE PHANCONGPHANBIEN.BAIPHANBIEN_BPBID = '" + textBox3.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1 && checkcolumn(textBox3.Text)) { sd.Fill(dt); }
            else
            {
                MessageBox.Show("ID không hợp lệ !!!!!!!!!!!!!!!!!!");
            }
            dataGridView1.DataSource = dt;
            BindData();
        }
    }
}
