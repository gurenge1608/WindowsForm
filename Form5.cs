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
    public partial class Form5 : Form
    {
        string res;
        public Form5()
        {
            InitializeComponent();
            
        }

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from TACGIA where TACGIA.NHAKHOAHOC_ScientistID = '"+res+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public bool checkcolumn(string str)
        {
            SqlCommand cmd = new SqlCommand("select * from TACGIA where TACGIA.NHAKHOAHOC_ScientistID = '" + res + "'", conn);
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
        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                check = 0;
            }
            else { check = 1; }
            SqlCommand cmd = new SqlCommand("UPDATE TACGIA SET TACGIA.Hoten = '"+textBox1.Text+"', TACGIA.Email = '"+textBox2.Text+ "',  TACGIA.Diachi = '" + textBox3.Text + "',  TACGIA.NgheNghiep = '" + textBox4.Text + "',  TACGIA.Coquancongtac = '" + textBox5.Text + "' WHERE TACGIA.NHAKHOAHOC_ScientistID = '" + res +"'" , conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (check == 1) sd.Fill(dt);
            dataGridView2.DataSource = dt;
            BindData();
        }
    }
}
