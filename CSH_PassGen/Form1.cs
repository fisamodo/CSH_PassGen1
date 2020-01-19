using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!checkBox1.Checked && !checkBox1.Checked && !checkBox3.Checked)
            {
                label2.Text = "MOLIMO ODABERITE CHECKBOX";
            }
            if(checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                string slova = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy";
                Random rnd = new Random();
                int size = trackBar1.Value;
                char[] niz = new char[size];
                for(int i = 0; i<size; i++)
                {
                    niz[i] = slova[rnd.Next(slova.Length)];
                }
                string zaporka = String.Join("", niz.Select(p => p.ToString()).ToArray());
                label2.Text = zaporka;
                label4.Visible = true;
                button2.Visible = true;
                
            }
            if(checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                string slovaSimboli = "!#$%&/()=?*_;:<>+-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy";
                Random rnd = new Random();
                int size = trackBar1.Value;
                char[] niz = new char[size];
                for (int i = 0; i < size; i++)
                {
                    niz[i] = slovaSimboli[rnd.Next(slovaSimboli.Length)];
                }
                string zaporka = String.Join("", niz.Select(p => p.ToString()).ToArray());
                label2.Text = zaporka;
                label4.Visible = true;
                button2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
