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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 sf = new Form3();
            this.Hide();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 sf = new Form1();
            this.Hide();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 sf = new Form4();
            this.Hide();
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 sf = new Form6();
            this.Hide();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 sf = new Form7();      
            sf.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 sf = new Form8();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 sf = new Form9();
            sf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 sf = new Form10();
            sf.Show();
        }
    }
}
