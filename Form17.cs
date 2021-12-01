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
    public partial class Form17 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 3 YEAR(thoigianthuchien) AS NamThuchien, COUNT(YEAR(thoigianthuchien)) AS Soluong FROM (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where NHAKHOAHOC_ScientistID = '"+res+"' GROUP BY YEAR(thoigianthuchien) ORDER BY Soluong DESC;", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
