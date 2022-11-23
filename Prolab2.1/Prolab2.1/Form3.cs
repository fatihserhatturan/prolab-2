using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prolab2._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            //hakan <3 <3 <3
            KULLANİCİ kullanici = new KULLANİCİ(textBox1.Text,textBox2.Text);
            singleton.oyuncu[2]=kullanici;

        }

        int s=0;

        Singleton singleton=Singleton.GetInstance();
        
     
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            
            Form5 form5 = new Form5();
            form3.Close();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singleton.array[s++] = 0;
            if (singleton.array[0] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }
            if (singleton.array[0] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[0] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array[1] == 0)
            {
                pictureBox8.Image = Properties.Resources.taş;
            }
            if (singleton.array[1] == 1)
            {
                pictureBox8.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox8.Image = Properties.Resources.Makas;
            }
            if (singleton.array[2] == 0)
            {
                pictureBox7.Image = Properties.Resources.taş;
            }
            if (singleton.array[2] == 1)
            {
                pictureBox7.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox7.Image = Properties.Resources.Makas;
            }
            if (singleton.array[3] == 0)
            {
                pictureBox6.Image = Properties.Resources.taş;
            }
            if (singleton.array[3] == 1)
            {
                pictureBox6.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox6.Image = Properties.Resources.Makas;
            }
            if (singleton.array[4] == 0)
            {
                pictureBox3.Image = Properties.Resources.taş;
            }
            if (singleton.array[4] == 1)
            {
                pictureBox3.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[4] == 2)
            {
                pictureBox3.Image = Properties.Resources.Makas;
            }
            label5.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            singleton.array[s++]=1; if (singleton.array[0] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }
            if (singleton.array[0] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[0] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array[1] == 0)
            {
                pictureBox8.Image = Properties.Resources.taş;
            }
            if (singleton.array[1] == 1)
            {
                pictureBox8.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox8.Image = Properties.Resources.Makas;
            }
            if (singleton.array[2] == 0)
            {
                pictureBox7.Image = Properties.Resources.taş;
            }
            if (singleton.array[2] == 1)
            {
                pictureBox7.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox7.Image = Properties.Resources.Makas;
            }
            if (singleton.array[3] == 0)
            {
                pictureBox6.Image = Properties.Resources.taş;
            }
            if (singleton.array[3] == 1)
            {
                pictureBox6.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox6.Image = Properties.Resources.Makas;
            }
            if (singleton.array[4] == 0)
            {
                pictureBox3.Image = Properties.Resources.taş;
            }
            if (singleton.array[4] == 1)
            {
                pictureBox3.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[4] == 2)
            {
                pictureBox3.Image = Properties.Resources.Makas;
            }
            label5.Text = s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            singleton.array[s++]=2; if (singleton.array[0] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }
            if (singleton.array[0] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[0] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array[1] == 0)
            {
                pictureBox8.Image = Properties.Resources.taş;
            }
            if (singleton.array[1] == 1)
            {
                pictureBox8.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox8.Image = Properties.Resources.Makas;
            }
            if (singleton.array[2] == 0)
            {
                pictureBox7.Image = Properties.Resources.taş;
            }
            if (singleton.array[2] == 1)
            {
                pictureBox7.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox7.Image = Properties.Resources.Makas;
            }
            if (singleton.array[3] == 0)
            {
                pictureBox6.Image = Properties.Resources.taş;
            }
            if (singleton.array[3] == 1)
            {
                pictureBox6.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox6.Image = Properties.Resources.Makas;
            }
            if (singleton.array[4] == 0)
            {
                pictureBox3.Image = Properties.Resources.taş;
            }
            if (singleton.array[4] == 1)
            {
                pictureBox3.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[4] == 2)
            {
                pictureBox3.Image = Properties.Resources.Makas;
            }
            label5.Text = s.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            singleton.stringArray = textBox1.Text;
            singleton.oyuncu[2].oyuncuadi = textBox1.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            singleton.stringArray2= textBox2.Text;

            singleton.oyuncu[2].oyuncuID = textBox2.Text;

        }
    }
}
