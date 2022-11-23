using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2._1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            if (singleton.array[0] == 0)
            {
                pictureBox5.Image = Properties.Resources.taş;
            }

            if (singleton.array[0] == 1)
            {
                pictureBox5.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[0] == 2)
            {
                pictureBox5.Image = Properties.Resources.Makas;
            }
            if(singleton.array[0] == -1)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            //////////////////////////////////////////////////////////
            if (singleton.array[1] == 0)
            {
                pictureBox4.Image = Properties.Resources.taş;
            }

            if (singleton.array[1] == 1)
            {
                pictureBox4.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox4.Image = Properties.Resources.Makas;
            }
            if (singleton.array[1] == -1)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            /////////////////////////////////////////////////////////
            if (singleton.array[2] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }

            if (singleton.array[2] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array[2] == -1)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            ////////////////////////////////////////////////////////
            if (singleton.array[3] == 0)
            {
                pictureBox2.Image = Properties.Resources.taş;
            }

            if (singleton.array[3] == 1)
            {
                pictureBox2.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox2.Image = Properties.Resources.Makas;
            }
            if (singleton.array[3] == -1)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            //////////////////////////////////////////////////////
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
            if (singleton.array[4] == -1)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }




            label1.Text = singleton.stringArray;

         


        }
        Singleton singleton = Singleton.GetInstance();
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            //this.Hide();
            Form4 form4 = new Form4();
            form5.Close();
            form4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < singleton.stringArray.Length; i++)
            {
                label4.Text += singleton.stringArray[i];
            }

        }
        int i = 1;
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (singleton.array[0] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }

            if (singleton.array[0] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }

            if (singleton.array[0] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }


            int sayi=0;
            
            singleton.kartListesiK[0] = sayi;
            
            
            
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (singleton.array[1] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }

            if (singleton.array[1] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }

            int sayi = 0;
            singleton.kartListesiK[1] = sayi;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (singleton.array[2] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }

            if (singleton.array[2] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }

            int sayi = 0;
            singleton.kartListesiK[2] = sayi;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (singleton.array[3] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }

            if (singleton.array[3] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }
            int sayi = 0;
            singleton.kartListesiK[3] = sayi;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (singleton.array[4] == 0)
            {
                pictureBox9.Image = Properties.Resources.taş;
            }

            if (singleton.array[4] == 1)
            {
                pictureBox9.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[4] == 2)
            {
                pictureBox9.Image = Properties.Resources.Makas;
            }

            int sayi = 0;
            singleton.kartListesiK[4] = sayi;
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

      





        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (singleton.array[0] == 6)
            {
                button3.Visible = false;
            }
            singleton.oyunK[singleton.counter] = 0;
            singleton.oyunK2[singleton.counter] = singleton.array[0];
            singleton.counter++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (singleton.array[1] == 6)
            {
                button4.Visible = false;
            }
            singleton.oyunK[singleton.counter] = 1;
            singleton.oyunK2[singleton.counter] = singleton.array[1];
            singleton.counter++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (singleton.array[2] == 6)
            {
                button5.Visible = false;
            }
            singleton.oyunK[singleton.counter] = 2;
            singleton.oyunK2[singleton.counter] = singleton.array[2];
            singleton.counter++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (singleton.array[3] == 6)
            {
                button6.Visible = false;
            }
            singleton.oyunK[singleton.counter] = 3;
            singleton.oyunK2[singleton.counter] = singleton.array[3];
            singleton.counter++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (singleton.array[4] == 6)
            {
                button7.Visible = false;
            }
            singleton.oyunK[singleton.counter] = 4;
            singleton.oyunK2[singleton.counter] = singleton.array[4];
            singleton.counter++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        label4.Text = i.ToString();
        i++;

        int sayi;
        int sayi2;
        int sayi3;
        int sayi4;
        int sayi5;
        double sayi6;
        double sayi7;
        double etki1;
        double etki2;

        // int counter = 0;

        lend:

            Random random = new Random();
           
            sayi = random.Next(0, 5);
           // sayi2 = singleton.oyunK[singleton.counter2];
            /////////////////////////////////////////////////////////////////////
            if (singleton.counter3 > 0)
            {

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
                        if (singleton.array2[(singleton.counter3) - i] == sayi)
                        {
                            goto lend;
                        }
                    }
                }
            }
            /////////////////////////////////////////////////////////////////////
            if (singleton.array2[sayi] == 6)
            {
                goto lend;
            }
            /*if (singleton.array[sayi2] == 6)
            {
                MessageBox.Show(" Elenmiş bir kart seçtiniz lütfen destenizi kontrol edin ");
                singleton.oyunK2[singleton.counter2] = 
                singleton.counter--;
                goto lend;
            }*/

           /* if (singleton.counter2 > 4) { sayi = singleton.counter2 % 5; }
        else { sayi = singleton.counter2; }*/


        

        sayi2 = singleton.oyunK[singleton.counter2];
        sayi3 = singleton.kartListesiK[sayi2];
        sayi4 = singleton.kartListesiB1[sayi];
        sayi5 = singleton.oyunK2[singleton.counter2];

        label13.Text = singleton.kartlistesiK2[sayi3].dayanıklılık.ToString();
        label14.Text = singleton.kartlistesiK2[sayi3].seviyepuanı.ToString();

        label17.Text = singleton.kartlistesib1[sayi4].dayanıklılık.ToString();
        label18.Text = singleton.kartlistesib1[sayi4].seviyepuanı.ToString();


            //label3.Text = sayi3.ToString();
            //label7.Text = sayi4.ToString();

            /////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////
            





           ///////////////////////////////////////////////////



            /////////////////////////////////////////////////////////////////////////////////////////////
            if (singleton.array[sayi5] == 0)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].daynıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));
                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
            }
            if (singleton.array[sayi5] == 1)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
            }
            if (singleton.array[sayi5] == 2)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();
                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;



                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
            }
            if (singleton.array2[sayi5] == 3)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki2;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi4].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();
                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;


                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;

                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
            }
            if (singleton.array[sayi5] == 4)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib2[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib2[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));


                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();
                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
            }
            if (singleton.array[sayi5] == 5)
            {
                if (singleton.array2[sayi] == 0)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;

                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;



                }
                if (singleton.array2[sayi] == 1)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 2)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 3)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.8) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.8) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;


                }
                if (singleton.array2[sayi] == 4)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - (etki1 / ((0.2) * etki2));
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - (etki2 / ((0.2) * etki1));

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2;


                }
                if (singleton.array2[sayi] == 5)
                {
                    etki1 = singleton.kartlistesiK2[sayi4].etki();
                    etki2 = singleton.kartlistesib1[sayi5].etki();

                    singleton.kartlistesiK2[sayi4].seviyepuanı = etki1 * 2;
                    singleton.kartlistesib1[sayi5].seviyepuanı = etki2 * 2;

                    sayi6 = singleton.kartlistesiK2[sayi4].durumGuncelle() - etki1;
                    sayi7 = singleton.kartlistesib1[sayi5].durumGuncelle() - etki2;

                    singleton.kartlistesiK2[sayi4].dayanıklılık = sayi6;
                    singleton.kartlistesib1[sayi5].dayanıklılık = sayi7;


                }
            }





            /////////////////////////////////////////////////////////////////////////////////////////
            if (singleton.kartlistesiK2[sayi4].dayanıklılık < 0)
            {
                singleton.array[sayi] = 6;
            }
            if (singleton.kartlistesib1[sayi5].dayanıklılık < 0)
            {
                singleton.array2[sayi2] = 6;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////

            if (singleton.kartlistesiK2[sayi3].seviyepuanı > 30){
            if (singleton.array[sayi2] == 0)
            {
                singleton.array[sayi2] = 3;
            }
            if (singleton.array[sayi2] == 1)
            {
                singleton.array[sayi2] = 4;
            }
            if (singleton.array[sayi2] == 2)
            {
                singleton.array[sayi2] = 5;
            }
        }
        if (singleton.kartlistesib1[sayi4].seviyepuanı> 30)
        {
            if (singleton.array2[sayi] == 0)
            {
                singleton.array2[sayi] = 3;
            }
            if (singleton.array2[sayi] == 1)
            {
                singleton.array2[sayi] =4;
            }
            if (singleton.array2[sayi] == 2)
            {
                singleton.array2[sayi] = 5;
            }
        }


            int counter1 = 0;
            int counter2 = 5;
            int counter3 = 10;
            int counter4 = 15;
            int counter5 = 18;
            int counter6 = 21;

            for (int i = 0; i < 5; i++)
            {
                if (singleton.array[i] == 0)
                {
                    singleton.kartListesiK[i] = counter1;
                    counter1++;
                }
                if (singleton.array[i] == 1)
                {
                    singleton.kartListesiK[i] = counter2;
                    counter2++;
                }
                if (singleton.array[i] == 2)
                {
                    singleton.kartListesiK[i] = counter3;
                    counter3++;
                }
                if (singleton.array[i] == 3)
                {
                    singleton.kartListesiK[i] = counter4;
                    counter4++;
                }
                if (singleton.array[i] == 4)
                {
                    singleton.kartListesiK[i] = counter5;
                    counter5++;
                }
                if (singleton.array[i] == 5)
                {
                    singleton.kartListesiK[i] = counter6;
                    counter6++;
                }
            }
            ////////////////////////////////////////////////////////////
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

            if (singleton.array[0] == 0)
            {
                pictureBox5.Image = Properties.Resources.taş;
            }

            if (singleton.array[0] == 1)
            {
                pictureBox5.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[0] == 2)
            {
                pictureBox5.Image = Properties.Resources.Makas;
            }
            if (singleton.array[0] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[0] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[0] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[0] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            //////////////////////////////////////////////////////////
            if (singleton.array[1] == 0)
            {
                pictureBox4.Image = Properties.Resources.taş;
            }

            if (singleton.array[1] == 1)
            {
                pictureBox4.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[1] == 2)
            {
                pictureBox4.Image = Properties.Resources.Makas;
            }
            if (singleton.array[1] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[1] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[1] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[1] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            /////////////////////////////////////////////////////////
            if (singleton.array[2] == 0)
            {
                pictureBox1.Image = Properties.Resources.taş;
            }

            if (singleton.array[2] == 1)
            {
                pictureBox1.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[2] == 2)
            {
                pictureBox1.Image = Properties.Resources.Makas;
            }
            if (singleton.array[2] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[2] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[2] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[2] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            ////////////////////////////////////////////////////////
            if (singleton.array[3] == 0)
            {
                pictureBox2.Image = Properties.Resources.taş;
            }

            if (singleton.array[3] == 1)
            {
                pictureBox2.Image = Properties.Resources.Kağıt;
            }
            if (singleton.array[3] == 2)
            {
                pictureBox2.Image = Properties.Resources.Makas;
            }
            if (singleton.array[3] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[3] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[3] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[3] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }
            //////////////////////////////////////////////////////
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
            if (singleton.array[4] == 6)
            {
                pictureBox5.Image = Properties.Resources.boş;
            }
            if (singleton.array[4] == 3)
            {
                pictureBox5.Image = Properties.Resources.agırtaş;
            }
            if (singleton.array[4] == 4)
            {
                pictureBox5.Image = Properties.Resources.özel_kağıt;
            }
            if (singleton.array[4] == 5)
            {
                pictureBox5.Image = Properties.Resources.usta_makas;
            }

            ///////////////////////////////////////////////////////////
            int toplam = 0;
            int toplam2 = 0;
            for (int i = 0; i < 5; i++)
            {

                toplam = singleton.array[i] + toplam;
                toplam2 = singleton.array2[i] + toplam2;

            }

            if (toplam == 30 || toplam2 == 30)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array[i] < 6)
                    {
                        singleton.kSkor = singleton.kartlistesiK2[i].dayanıklılık + singleton.kSkor;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array2[i] < 6)
                    {
                        singleton.b1Skor = singleton.kartlistesib1[i].dayanıklılık + singleton.b1Skor;
                    }
                }

                Form5 form5 = new Form5();
                Form4 form4 = new Form4();
                form5.Close();
                form4.Show();

            }
            if (singleton.counter2 == singleton.hamle)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array[i] < 6)
                    {
                        singleton.kSkor = singleton.kartlistesiK2[i].dayanıklılık + singleton.kSkor;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (singleton.array2[i] < 6)
                    {
                        singleton.b1Skor = singleton.kartlistesib1[i].dayanıklılık + singleton.b1Skor;
                    }
                }


                Form6 form6 = new Form6();
                Form4 form4 = new Form4();
                form6.Close();
                form4.Show();
            }

            //////////////////////////////////////////////////////////
            singleton.counter2++;
        
    }
    }
}
