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
    public partial class Form4 : Form
    {
        string res;

        public void pass(string qs)
        {
            res = qs;
        }

        SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 danhsachcactacgia = new Form15();
            danhsachcactacgia.pass(res);
            danhsachcactacgia.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 capnhatthongtinnhaphanbien = new Form11();
            capnhatthongtinnhaphanbien.pass(res);
            capnhatthongtinnhaphanbien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 capnhatbaiphanbien = new Form12();
            capnhatbaiphanbien.pass(res);
            capnhatbaiphanbien.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 danhsachbaibaodangphanbien = new Form13();
            danhsachbaibaodangphanbien.pass(res);
            danhsachbaibaodangphanbien.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 danhsachbaibaotheotacgia = new Form14();
            danhsachbaibaotheotacgia.pass(res);
            danhsachbaibaotheotacgia.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form16 ketquaphanbien = new Form16();
            ketquaphanbien.pass(res);
            ketquaphanbien.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form17 phanbiennhieunhat = new Form17();
            phanbiennhieunhat.pass(res);
            phanbiennhieunhat.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form18 ketquatotnhat = new Form18();
            ketquatotnhat.pass(res);
            ketquatotnhat.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form19 ketquathapnhat = new Form19();
            ketquathapnhat.pass(res);
            ketquathapnhat.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form20 ketquathapnhat = new Form20();
            ketquathapnhat.pass(res);
            ketquathapnhat.Show();
        }
    }
}
