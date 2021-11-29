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
    public partial class Form2 : Form
    {
        string res;
        public Form2()
        {
            InitializeComponent();
          
        }
        
        public void pass(string qs)
        {
            res = qs;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 thongtinbaibao = new Form6();
            thongtinbaibao.pass(res);
            thongtinbaibao.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 tongsobaibao = new Form9();
            tongsobaibao.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 thongtintacgia = new Form5();
            thongtintacgia.pass(res);
            thongtintacgia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 thongtincactacgia = new Form7();
            thongtincactacgia.pass(res);
            thongtincactacgia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 ketquaphanbien = new Form8();
            ketquaphanbien.pass(res);
            ketquaphanbien.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 danhsachbaibao = new Form10();
            danhsachbaibao.Show();
        }
    }
}
