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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=KEN;Initial Catalog=HCSDL2;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username='"+txtUser.Text+"' and password='"+txtPass.Text+"'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i=0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("you are log in as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Form2 tacgia = new Form2();
                            tacgia.Show();
                            this.Hide();
                            
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            Form3 banbientap = new Form3();
                            banbientap.Show();
                            this.Hide();

                        }
                        else
                        {
                            Form4 nhaphanbien = new Form4();
                            nhaphanbien.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
