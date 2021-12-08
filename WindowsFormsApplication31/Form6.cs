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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sonuc = (Convert.ToDouble(textBox1.Text) * 0.4) + (Convert.ToDouble(textBox2.Text) * 0.6);
                string eto = (sonuc >= 50) ? label3.Text = "GEÇTİ" : label3.Text = "KALDI";
                label4.Text = sonuc.ToString();

                     if (sonuc >= 85 && sonuc <= 100)
                {
                    label5.Text = "AA";
                }
                else if (sonuc >= 70 && sonuc <= 85)
                {
                    label5.Text = "BA";
                }
                else if (sonuc >= 60 && sonuc <= 70)
                {
                    label5.Text = "BB";
                }
                else if (sonuc >= 50 && sonuc <= 60)
                {
                    label5.Text = "CB";
                }
                else if (sonuc >= 40 && sonuc <= 50)
                {
                    label5.Text = "CC";
                }
                else if (sonuc >= 30 && sonuc <= 40)
                {
                    label5.Text = "DC";
                }
                else if (sonuc >= 20 && sonuc <= 30)
                {
                    label5.Text = "DD";
                }
                else if (sonuc < 20)
                {
                    label5.Text = "FF";
                }          
                else
                {
                    
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
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
