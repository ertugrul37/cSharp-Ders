using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           label5.Text=((int.Parse(textBox3.Text)*0.3+ int.Parse(textBox4.Text)*0.5+ int.Parse(textBox5.Text)*0.2)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 df = new Form2();
            df.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            this.Hide();
            sf.Show();
        }
    }
}
