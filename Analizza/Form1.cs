using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Analizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int L;
            int L1 = 0;
            StreamReader sr = new StreamReader(@"./dati.csv");
            int count = 0;
            string check = "SI";
            while (sr.ReadLine() != null)
            {
                L = sr.ReadLine().Length;
                if (count != 0)
                {
                    if (L1 != L)
                    {
                        check = "NO";
                        MessageBox.Show(check, "Sono uguali?");
                        return;
                    }
                }
                L1 = L;
                count++;
            }
            MessageBox.Show(check, "Sono uguali?");
            sr.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int L = 0;
            int L1 = 0;
            StreamReader sr = new StreamReader(@"./dati.csv");
            int count = 0;
            while (sr.ReadLine() != null)
            {
                L1 = sr.ReadLine().Length;
                if (count != 0)
                {
                    if (L1 >= L)
                    {
                        L = L1;
                    }
                }                
                count++;
            }
            L--;
            string m = Convert.ToString(L);
            MessageBox.Show(m, "Dimensione massima:");
            sr.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Location = new System.Drawing.Point(394, 281);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nome = textBox2.Text;
            string azinenda = textBox3.Text;
            int Num1 = int.Parse(textBox4.Text);
            int Num2 = int.Parse(textBox5.Text);
            int Num3 = int.Parse(textBox6.Text);
            int Num4 = int.Parse(textBox7.Text);
            string oggetto = textBox8.Text;
            decimal decimale = decimal.Parse(textBox9.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
