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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random Rnd = new Random();
            label1.Text = Rnd.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(Rnd.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

