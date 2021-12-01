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
    public partial class Form20 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT 1.0*SUM(Trungbinh)/5 AS TRUNGBINH FROM(SELECT COUNT(YEAR(thoigianthuchien)) AS Trungbinh FROM(((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID = BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where NHAKHOAHOC_ScientistID = '"+res+"' AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) <= 5 AND(Hoantatphanbien = 1 OR Xuatban = 1 OR Dadang = 1)  GROUP BY(YEAR(thoigianthuchien))) as counts", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public Form20()
        {
            InitializeComponent();
        }
    }
}
