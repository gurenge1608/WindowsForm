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
    public partial class Form12 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select BPBID, Danhchotacgia, Danhchobanbientap, Noidung, Ngaythongbaodentacgia, Cacchitietkhac, BAIBAO_NewsID, PBID FROM BAIPHANBIEN JOIN (THUCHIENPHANBIEN JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) ON BAIPHANBIEN_BPBID = BPBID WHERE NHAKHOAHOC_ScientistID = '"+res+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Form12()
        {
            InitializeComponent();
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }
            for (int i = 0; i < ; i++)
            SqlCommand cmd = new SqlCommand("UPDATE BAIPHANBIEN SET BAIPHANBIEN.Danhchotacgia = '" + textBox1.Text + "', BAIPHANBIEN.Danhchobanbientap = '" + textBox2.Text + "',  BAIPHANBIEN.Noidung = '" + textBox3.Text + "',  BAIPHANBIEN.Cacchitietkhac = '" + textBox4.Text + "' WHERE BAIPHANBIEN.BPBID = '" + textBox5.Text+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1) sd.Fill(dt);
            dataGridView1.DataSource = dt;
            BindData();
        }
    }
}
