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
    public partial class Form3 : Form
    {
        string res;
        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 capnhatphancongphanbien = new Form21();
            capnhatphancongphanbien.pass(res);
            capnhatphancongphanbien.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form25 capnhatketqua = new Form25();
            capnhatketqua.pass(res);
            capnhatketqua.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 capnhatketqua = new Form23();
            capnhatketqua.pass(res);
            capnhatketqua.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 capnhattrangthaixuly = new Form22();
            capnhattrangthaixuly.pass(res);
            capnhattrangthaixuly.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 capnhattrangthaixuly = new Form24();
            capnhattrangthaixuly.pass(res);
            capnhattrangthaixuly.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form26 capnhattrangthaixuly = new Form26();
            capnhattrangthaixuly.pass(res);
            capnhattrangthaixuly.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form27 capnhattrangthaixuly = new Form27();
            capnhattrangthaixuly.pass(res);
            capnhattrangthaixuly.Show();
        }
    }
}
