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
    public partial class Form16 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        public Form16()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select tacgiasangtac, NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Chapnhan, Tuchoi, Suadoiit, Suadoinhieu from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) JOIN BAIBAO_TACGIASANGTAC ON BAIBAO_TACGIASANGTAC.BAIBAO_NewsID = BAIBAO.NewsID where (NHAKHOAHOC_ScientistID = '"+res+"' AND DATEDIFF(YEAR, Thoigianthuchien, CURRENT_TIMESTAMP) < 1)", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
