using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] adsoyad = new string[5];
        string[] numara = new string[5];
        string[] sınıf = new string[5];
        string[] alan = new string[5];

        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            adsoyad[x] = textBox2.Text;
            numara[x] = textBox3.Text;
            sınıf[x] = textBox4.Text;
            alan[x] = textBox5.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < adsoyad.Length; x++)
            {
                if (adsoyad[x] != null)
                {
                    listBox1.Items.Add(adsoyad[x] +" "+ sınıf[x] +" "+ numara[x] +" "+ alan[x]);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            string umara = textBox3.Text;
            for (int x = 0; x < adsoyad.Length; x++)
            {
                if (numara[x] == umara)
                {
                    kontrol = true;
                    listBox1.Items.Add(adsoyad[x] + " " + sınıf[x] + " " + numara[x] + " " + alan[x]);
                }
            }
            if (!kontrol)
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }
    }
}
