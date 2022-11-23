using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2._1
{
    
    public partial class Form6 : Form
    {
        public Form6()
        {
           
            InitializeComponent();
            
            
            //label5.Text = mAKAS.seviyepuanı.ToString();

            if (singleton.array2[0] == 0)
            {
                pictureBox5.Image = Properties.Resources.taş;
            }
            if (singleton.array2[0] == 1)
            {
                pictureBox5.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[0] == 2)
            {
                pictureBox5.Image = Properties.Resources.Makas;
            }
            ////////////////////////////////////////////////////
            if (singleton.array2[1] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }
            if (singleton.array2[1] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[1] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            ////////////////////////////////////////////////////
            if (singleton.array2[2] == 0)
            {
                pictureBox2.Image = Properties.Resources.taş;
            }
            if (singleton.array2[2] == 1)
            {
                pictureBox2.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[2] == 2)
            {
                pictureBox2.Image = Properties.Resources.Makas;
            }
            ///////////////////////////////////////////////////
            if (singleton.array2[3] == 0)
            {
                pictureBox3.Image = Properties.Resources.taş;
            }
            if (singleton.array2[3] == 1)
            {
                pictureBox3.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[3] == 2)
            {
                pictureBox3.Image = Properties.Resources.Makas;
            }
            //////////////////////////////////////////////////
            if (singleton.array2[4] == 0)
            {
                pictureBox4.Image = Properties.Resources.taş;
            }
            if (singleton.array2[4] == 1)
            {
                pictureBox4.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[4] == 2)
            {
                pictureBox4.Image = Properties.Resources.Makas;
            }
            ////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            //////////////////////////////////////////////////
            if (singleton.array3[0] == 0)
            {
                pictureBox11.Image = Properties.Resources.taş;
            }
            if (singleton.array3[0] == 1)
            {
                pictureBox11.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[0] == 2)
            {
                pictureBox11.Image = Properties.Resources.Makas;
            }
            ////////////////////////////////////////////////////
            if (singleton.array3[1] == 0)
            {
                pictureBox12.Image = Properties.Resources.taş;
            }
            if (singleton.array3[1] == 1)
            {
                pictureBox12.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[1] == 2)
            {
                pictureBox12.Image = Properties.Resources.Makas;
            }
            ////////////////////////////////////////////////////
            if (singleton.array3[2] == 0)
            {
                pictureBox13.Image = Properties.Resources.taş;
            }
            if (singleton.array3[2] == 1)
            {
                pictureBox13.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[2] == 2)
            {
                pictureBox13.Image = Properties.Resources.Makas;
            }
            ///////////////////////////////////////////////////
            if (singleton.array3[3] == 0)
            {
                pictureBox14.Image = Properties.Resources.taş;
            }
            if (singleton.array3[3] == 1)
            {
                pictureBox14.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[3] == 2)
            {
                pictureBox14.Image = Properties.Resources.Makas;
            }
            ///////////////////////////////////////////////////
            if (singleton.array3[4] == 0)
            {
                pictureBox15.Image = Properties.Resources.taş;
            }
            if (singleton.array3[4] == 1)
            {
                pictureBox15.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[4] == 2)
            {
                pictureBox15.Image = Properties.Resources.Makas;
            }
            
        }
        Singleton singleton = Singleton.GetInstance();
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            
            //this.Hide();
            Form4 form4 = new Form4();
            form6.Close();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            int sayi2;
            int sayi4;
            int sayi5;
            int sayi8=0;
            int sayi9;
            double sayi6;
            double sayi7;
            double etki1;
            double etki2;

            lend:

            Random random = new Random();
            sayi = random.Next(0, 5);
            sayi2 = random.Next(0, 5);
            ///////////////////////////////////////////////////////////////////
            if (singleton.counter > 0) { 
            
                for (int i = 0; i < 5; i++)
                {

                    if (singleton.counter2 > 4)
                    {

                        if (singleton.array2[(singleton.counter2 % 4) - i] == sayi)
                        {
                            goto lend;
                        }
                    }
                    else
                    {
                        if (singleton.array2[(singleton.counter) - i] == sayi)
                        {
                            goto lend;
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            if (singleton.counter > 0) { 
            
                for (int i = 0; i < 5; i++)
                {

                    if (singleton.counter2 > 4)
                    {

                        if (singleton.array3[(singleton.counter2 % 4) - i] == sayi)
                        {
                            goto lend;
                        }
                    }
                    else
                    {
                        if (singleton.array3[(singleton.counter) - i] == sayi)
                        {
                            goto lend;
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////
            if (singleton.array2[sayi] == 6)
            {
                goto lend;
            }
            if (singleton.array3[sayi2] == 6)
            {
                goto lend;
            }

            sayi4 = singleton.kartListesiB1[sayi];
            sayi5 = singleton.kartListesiB2[sayi2];


            /*
            if (singleton.counter2 > 4) { sayi = singleton.counter2 % 5; }
            else { sayi = singleton.counter2; }
            if (singleton.counter2 > 4) { sayi2 = singleton.counter2 % 5; }
            else { sayi2 = singleton.counter2; }
            */

            //////////////////////////////////////////////////////////////
            if (singleton.array2[sayi] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }
            if (singleton.array2[sayi] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[sayi] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[sayi] == 3)
            {
                pictureBox9.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[sayi] == 4)
            {
                pictureBox9.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[sayi] == 5)
            {
                pictureBox9.Image = Properties.Resources.usta_makas;
            }
            
            //////////////////////////////////////////////////////////////
            if (singleton.array3[sayi2] == 0)
            {
                pictureBox8.Image = Properties.Resources.taş;
            }
            if (singleton.array3[sayi2] == 1)
            {
                pictureBox8.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[sayi2] == 2)
            {
                pictureBox8.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[sayi2] == 3)
            {
                pictureBox8.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[sayi2] == 4)
            {
                pictureBox8.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[sayi2] == 5)
            {
                pictureBox8.Image = Properties.Resources.usta_makas;
            }
          

            ///////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////
            label17.Text = singleton.kartlistesib1[sayi4].dayanıklılık.ToString();
            label9.Text = singleton.kartlistesib1[sayi5].dayanıklılık.ToString();
            label21.Text = singleton.counter2.ToString();
            label18.Text = singleton.kartlistesib1[sayi4].seviyepuanı.ToString();
            label10.Text = singleton.kartlistesib1[sayi5].seviyepuanı.ToString();
            ///////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////
                if (singleton.array2[sayi] == 0)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                 

                    }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                   
                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();
                        
                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].daynıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                
                }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));
                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


               
                }
                }
                if (singleton.array2[sayi] == 1)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


            
                }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


             
                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


              
                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


              
                }
                }
                if (singleton.array2[sayi] == 2)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                 
                }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


           
                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();
                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;


               
                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                    
                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                   
                    }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


               
                }
                }
                if (singleton.array2[sayi] == 3)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib2[sayi4].durumGuncelle() - etki2;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi4].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


              
                }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                
                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                 
                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();
                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;


                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;

                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                
                }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                }
                if (singleton.array2[sayi] == 4)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();
                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                }
                if (singleton.array2[sayi] == 5)
                {
                    if (singleton.array3[sayi2] == 0)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;

                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                  
                }
                    if (singleton.array3[sayi2] == 1)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 2)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;

               
                }
                    if (singleton.array3[sayi2] == 3)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2 ;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2;


                }
                    if (singleton.array3[sayi2] == 4)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1 ;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2 ;


                }
                    if (singleton.array3[sayi2] == 5)
                    {
                        etki1 = singleton.kartlistesib1[sayi4].etki();
                        etki2 = singleton.kartlistesib2[sayi5].etki();

                        singleton.kartlistesib1[sayi4].seviyepuanı = etki1*2 ;
                        singleton.kartlistesib2[sayi5].seviyepuanı = etki2*2 ;

                        sayi6 = singleton.kartlistesib1[sayi4].durumGuncelle() - etki1;
                        sayi7 = singleton.kartlistesib2[sayi5].durumGuncelle() - etki2;

                        singleton.kartlistesib1[sayi4].dayanıklılık = sayi6;
                        singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;


                }
                }

             

                /////////////////////////////////////////////////////////////
                if (singleton.kartlistesib1[sayi4].dayanıklılık < 0)
                {
                    singleton.array2[sayi] = 6;
                }
                if (singleton.kartlistesib2[sayi5].dayanıklılık < 0)
                {
                    singleton.array3[sayi2] = 6;
                }

                ////////////////////////////////////////////////////////////
            if (singleton.kartlistesib1[sayi4].seviyepuanı > 30)
            {
                if (singleton.array2[sayi] == 0)
                {
                    singleton.array2[sayi] = 3;
                }
                if (singleton.array2[sayi] == 1)
                {
                    singleton.array2[sayi] = 4;
                }
                if (singleton.array2[sayi] == 2)
                {
                    singleton.array2[sayi] = 5;
                }
            }
            if (singleton.kartlistesib1[sayi5].seviyepuanı > 30)
            {
                if (singleton.array3[sayi2] == 0)
                {
                    singleton.array3[sayi2] = 3;
                }
                if (singleton.array3[sayi2] == 1)
                {
                    singleton.array3[sayi2] = 4;
                }
                if (singleton.array3[sayi2] == 2)
                {
                    singleton.array3[sayi2] = 5;
                }
            }
            ///////////////////////////////////////////////////////////
            int counter10 = 0;
            int counter12 = 5;
            int counter13 = 10;
            int counter7 = 15;
            int counter8 = 18;
            int counter9 = 21;

            for (int i = 0; i < 5; i++)
            {
                if (singleton.array2[i] == 0)
                {
                    singleton.kartListesiB1[i] = counter10;
                    counter10++;
                }
                if (singleton.array2[i] == 1)
                {
                    singleton.kartListesiB1[i] = counter12;
                    counter12++;
                }
                if (singleton.array2[i] == 2)
                {
                    singleton.kartListesiB1[i] = counter13;
                    counter13++;
                }
                if (singleton.array2[i] == 3)
                {
                    singleton.kartListesiB1[i] = counter7;
                    counter7++;
                }
                if (singleton.array2[i] == 4)
                {
                    singleton.kartListesiB1[i] = counter8;
                    counter8++;
                }
                if (singleton.array2[i] == 5)
                {
                    singleton.kartListesiB1[i] = counter9;
                    counter9++;
                }

            }


            //////////////////////////////////////////////////////////
            int counter14 = 0;
            int counter15 = 5;
            int counter16 = 10;
            int counter17 = 15;
            int counter18 = 18;
            int counter19 = 21;

            for (int i = 0; i < 5; i++)
            {
                if (singleton.array3[i] == 0)
                {
                    singleton.kartListesiB2[i] = counter14;
                    counter14++;
                }
                if (singleton.array3[i] == 1)
                {
                    singleton.kartListesiB2[i] = counter15;
                    counter15++;
                }
                if (singleton.array3[i] == 2)
                {
                    singleton.kartListesiB2[i] = counter16;
                    counter16++;
                }
                if (singleton.array3[i] == 3)
                {
                    singleton.kartListesiB2[i] = counter17;
                    counter17++;
                }
                if (singleton.array3[i] == 4)
                {
                    singleton.kartListesiB2[i] = counter18;
                    counter18++;
                }
                if (singleton.array3[i] == 5)
                {
                    singleton.kartListesiB2[i] = counter19;
                    counter19++;
                }

            }

            /////////////////////////////////////////////////////////
            int toplam = 0;
                 int toplam2 = 0;   
                for(int i = 0; i < 5; i++)
                {

                toplam = singleton.array2[i] + toplam;
                toplam2 = singleton.array3[i] + toplam2;

                }

            if (toplam == 30 || toplam2 == 30)
            {
                for(int i = 0; i < 5; i++)
                {
                    if(singleton.array2[i] < 6)
                    {
                        singleton.b1Skor = singleton.kartlistesib1[i].dayanıklılık + singleton.b1Skor;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array3[i] < 6)
                    {
                        singleton.b2Skor = singleton.kartlistesib2[i].dayanıklılık + singleton.b2Skor;
                    }
                }

                Form6 form6 = new Form6();
                Form4 form4 = new Form4();
                form6.Close();
                form4.Show();

            }


                


           
            if (singleton.counter2 == singleton.hamle)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array2[i] < 6)
                    {
                        singleton.b1Skor = singleton.kartlistesib1[i].dayanıklılık + singleton.b1Skor;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array3[i] < 6)
                    {
                        singleton.b2Skor = singleton.kartlistesib2[i].dayanıklılık + singleton.b2Skor;
                    }
                }


                Form6 form6 = new Form6();
                Form4 form4 = new Form4();
                form6.Close();
                form4.Show();
            }

            ///////////////////////////////////////////////////

            if (singleton.array2[0] == 0)
            {
                pictureBox5.Image = Properties.Resources.taş;
            }
            if (singleton.array2[0] == 1)
            {
                pictureBox5.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[0] == 2)
            {
                pictureBox5.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array2[0] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            ////////////////////////////////////////////////////
            if (singleton.array2[1] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }
            if (singleton.array2[1] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[1] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[1] == 3)
            {
                pictureBox1.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[1] == 4)
            {
                pictureBox1.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[1] == 5)
            {
                pictureBox1.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array2[1] == 6)
            {
                pictureBox1.Image = Properties.Resources.boş;
            }
            ////////////////////////////////////////////////////
            if (singleton.array2[2] == 0)
            {
                pictureBox2.Image = Properties.Resources.taş;
            }
            if (singleton.array2[2] == 1)
            {
                pictureBox2.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[2] == 2)
            {
                pictureBox2.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[2] == 3)
            {
                pictureBox2.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[2] == 4)
            {
                pictureBox2.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[2] == 5)
            {
                pictureBox2.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array2[2] == 6)
            {
                pictureBox2.Image = Properties.Resources.boş;
            }
            ///////////////////////////////////////////////////
            if (singleton.array2[3] == 0)
            {
                pictureBox3.Image = Properties.Resources.taş;
            }
            if (singleton.array2[3] == 1)
            {
                pictureBox3.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[3] == 2)
            {
                pictureBox3.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[3] == 3)
            {
                pictureBox3.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[3] == 4)
            {
                pictureBox3.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[3] == 5)
            {
                pictureBox3.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array2[3] == 6)
            {
                pictureBox3.Image = Properties.Resources.boş;
            }
            //////////////////////////////////////////////////
            if (singleton.array2[4] == 0)
            {
                pictureBox4.Image = Properties.Resources.taş;
            }
            if (singleton.array2[4] == 1)
            {
                pictureBox4.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array2[4] == 2)
            {
                pictureBox4.Image = Properties.Resources.Makas;
            }
            if (singleton.array2[4] == 3)
            {
                pictureBox4.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array2[4] == 4)
            {
                pictureBox4.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array2[4] == 5)
            {
                pictureBox4.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array2[4] == 6)
            {
                pictureBox4.Image = Properties.Resources.boş;
            }
            ////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            //////////////////////////////////////////////////
            if (singleton.array3[0] == 0)
            {
                pictureBox11.Image = Properties.Resources.taş;
            }
            if (singleton.array3[0] == 1)
            {
                pictureBox11.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[0] == 2)
            {
                pictureBox11.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[0] == 3)
            {
                pictureBox11.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[0] == 4)
            {
                pictureBox11.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[0] == 5)
            {
                pictureBox11.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array3[0] == 6)
            {
                pictureBox11.Image = Properties.Resources.boş;
            }
            ////////////////////////////////////////////////////
            if (singleton.array3[1] == 0)
            {
                pictureBox12.Image = Properties.Resources.taş;
            }
            if (singleton.array3[1] == 1)
            {
                pictureBox12.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[1] == 2)
            {
                pictureBox12.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[1] == 3)
            {
                pictureBox12.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[1] == 4)
            {
                pictureBox12.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array3[1] == 5)
            {
                pictureBox12.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[1] == 6)
            {
                pictureBox12.Image = Properties.Resources.boş;
            }
            ////////////////////////////////////////////////////
            if (singleton.array3[2] == 0)
            {
                pictureBox13.Image = Properties.Resources.taş;
            }
            if (singleton.array3[2] == 1)
            {
                pictureBox13.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[2] == 2)
            {
                pictureBox13.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[2] == 3)
            {
                pictureBox13.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[2] == 4)
            {
                pictureBox13.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[2] == 5)
            {
                pictureBox13.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array3[2] == 6)
            {
                pictureBox13.Image = Properties.Resources.boş;
            }
            ///////////////////////////////////////////////////
            if (singleton.array3[3] == 0)
            {
                pictureBox14.Image = Properties.Resources.taş;
            }
            if (singleton.array3[3] == 1)
            {
                pictureBox14.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[3] == 2)
            {
                pictureBox14.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[3] == 3)
            {
                pictureBox14.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[3] == 4)
            {
                pictureBox14.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[3] == 5)
            {
                pictureBox14.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array3[3] == 6)
            {
                pictureBox14.Image = Properties.Resources.boş;
            }
            ///////////////////////////////////////////////////
            if (singleton.array3[4] == 0)
            {
                pictureBox15.Image = Properties.Resources.taş;
            }
            if (singleton.array3[4] == 1)
            {
                pictureBox15.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array3[4] == 2)
            {
                pictureBox15.Image = Properties.Resources.Makas;
            }
            if (singleton.array3[4] == 3)
            {
                pictureBox15.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array3[4] == 4)
            {
                pictureBox15.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array3[4] == 5)
            {
                pictureBox15.Image = Properties.Resources.usta_makas;
            }
            if (singleton.array3[4] == 6)
            {
                pictureBox15.Image = Properties.Resources.boş;
            }

            singleton.counter2++;
        }
    }
}
