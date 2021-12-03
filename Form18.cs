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
    public partial class Form18 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select TOP 3  NewsID, Tomtat, Tieude, Filebaocao, TACGIA_AuthorID, Chapnhan from (((BAIBAO JOIN BAIPHANBIEN ON BAIBAO_NewsID = NewsID) JOIN THUCHIENPHANBIEN ON BPBID =  BAIPHANBIEN_BPBID) JOIN NHAPHANBIEN ON NHAPHANBIEN_PBID = PBID) where NHAKHOAHOC_ScientistID = '"+res+"' AND Chapnhan = 1;", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public Form18()
        {
            InitializeComponent();
        }
    }
}
