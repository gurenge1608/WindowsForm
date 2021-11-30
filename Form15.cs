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
    public partial class Form15 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form15()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 TACGIA_AuthorID,Email, Diachi, Coquancongtac, Hoten, Nghenghiep, COUNT(TACGIA_AuthorID) AS Soluong FROM (BAIBAO JOIN TACGIA ON TACGIA_AuthorID = AuthorID) GROUP BY TACGIA_AuthorID, Email, Diachi, Coquancongtac, Hoten, Nghenghiep ORDER BY Soluong DESC", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
