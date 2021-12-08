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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi = int.Parse(textBox1.Text);
            if (sayi % 2 == 0)
            {
                label1.Text = "ÇİFT";
            }
            else
            {
                label1.Text = "TEK";
            }
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
