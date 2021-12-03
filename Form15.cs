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
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 SANGTAC_ID, TACGIASANGTAC.Email, TACGIASANGTAC.Diachi, TACGIASANGTAC.Coquancongtac, TACGIASANGTAC.Hoten, COUNT(SANGTAC_ID) AS Soluong FROM (BAIBAO JOIN SANGTAC ON SANGTAC.BAIBAO_NewsID = NewsID) JOIN TACGIASANGTAC ON SANGTAC_ID = SANGTAC_IDREF JOIN BAIPHANBIEN ON SANGTAC.BAIBAO_NewsID = BAIPHANBIEN.BAIBAO_NewsID JOIN THUCHIENPHANBIEN ON BPBID = BAIPHANBIEN_BPBID JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID WHERE NHAPHANBIEN.NHAKHOAHOC_ScientistID = '" + res+ "' GROUP BY SANGTAC_ID, TACGIASANGTAC.Email, TACGIASANGTAC.Diachi, TACGIASANGTAC.Coquancongtac, TACGIASANGTAC.Hoten ORDER BY Soluong DESC ", conn);
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
