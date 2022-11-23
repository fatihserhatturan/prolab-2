using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2._1
{
    public partial class Form2 : Form
    {


       

        

        public Form2()
        {
            InitializeComponent();
            
            //label4.Text=tAS.dayanıklılık.ToString();
            int sayi;
            int sayi2;


            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {

                sayi = random.Next(0, 3);
                singleton.array2[i] = sayi;
            }
            for (int a = 0; a < 5; a++)
            {

                sayi2 = random.Next(0, 3);
                singleton.array3[a] = sayi2;

            }
            //////////////////////////////////////////////////////////
            int counter1 = 0;
            int counter2 = 5;
            int counter3 = 10;

            for (int i = 0; i < 5; i++)
            {
                if (singleton.array2[i] == 0)
                {
                    singleton.kartListesiB1[i] = counter1;
                    counter1++;
                }
                if (singleton.array2[i] == 1)
                {
                    singleton.kartListesiB1[i] = counter2;
                    counter2++;
                }
                if (singleton.array2[i] == 2)
                {
                    singleton.kartListesiB1[i] = counter3;
                    counter3++;
                }

            }

            /////////////////////////////////////////////////////////////

            int counter21 = 0;
            int counter22 = 5;
            int counter23 = 10;

            for (int i = 0; i < 5; i++)
            {
                if (singleton.array3[i] == 0)
                {
                    singleton.kartListesiB2[i] = counter21;
                    counter21++;
                }
                if (singleton.array3[i] == 1)
                {
                    singleton.kartListesiB2[i] = counter22;
                    counter22++;
                }
                if (singleton.array3[i] == 2)
                {
                    singleton.kartListesiB2[i] = counter23;
                    counter23++;
                }

            }

            


            TAS tas1 = new TAS(20,20,0);
            TAS tas2 = new TAS(20,20,0);
            TAS tas3 = new TAS(20,20,0);
            TAS tas4 = new TAS(20,20,0);
            TAS tas5 = new TAS(20,20,0);

            KAGIT kagıt1 = new KAGIT(10,30,0);
            KAGIT kagıt2 = new KAGIT(10,30,0);
            KAGIT kagıt3 = new KAGIT(10,30,0);
            KAGIT kagıt4 = new KAGIT(10,30,0);
            KAGIT kagıt5 = new KAGIT(10,30,0);

            MAKAS makas1 = new MAKAS(30,10,0);
            MAKAS makas2 = new MAKAS(30,10,0);
            MAKAS makas3 = new MAKAS(30,10,0);
            MAKAS makas4 = new MAKAS(30,10,0);
            MAKAS makas5 = new MAKAS(30,10,0);

            USTA_MAKAS ustaMakas1 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas2 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas3 = new USTA_MAKAS(15, 20, 20, 0);

            OZEL_KAGIT ozelKagıt1 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt2 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt3 = new OZEL_KAGIT(25, 20, 20, 0);

            AGIR_TAS agırTas1 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas2 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas3 = new AGIR_TAS(35, 20, 20, 0);

            singleton.kartlistesiK2[0] = tas1;
            singleton.kartlistesiK2[1] = tas2;
            singleton.kartlistesiK2[2] = tas3;
            singleton.kartlistesiK2[3] = tas4;
            singleton.kartlistesiK2[4] = tas5;
            singleton.kartlistesiK2[5] = kagıt1;
            singleton.kartlistesiK2[6] = kagıt2;
            singleton.kartlistesiK2[7] = kagıt3;
            singleton.kartlistesiK2[8] = kagıt4;
            singleton.kartlistesiK2[9] = kagıt5;
            singleton.kartlistesiK2[10] = makas1;
            singleton.kartlistesiK2[11] = makas2;
            singleton.kartlistesiK2[12] = makas3;
            singleton.kartlistesiK2[13] = makas4;
            singleton.kartlistesiK2[14] = makas5; 
            singleton.kartlistesiK2[15] = agırTas1;
            singleton.kartlistesiK2[16] = agırTas2;
            singleton.kartlistesiK2[17] = agırTas3;
            singleton.kartlistesiK2[18] = ozelKagıt1;
            singleton.kartlistesiK2[19] = ozelKagıt2;
            singleton.kartlistesiK2[20] = ozelKagıt3;
            singleton.kartlistesiK2[21] = ustaMakas1;
            singleton.kartlistesiK2[22] = ustaMakas2;
            singleton.kartlistesiK2[23] = ustaMakas3;
            ////////////////////////////////////////////////


            TAS tas6 = new TAS(20, 20, 0);
            TAS tas7 = new TAS(20, 20, 0);
            TAS tas8 = new TAS(20, 20, 0);
            TAS tas9 = new TAS(20, 20, 0);
            TAS tas10 = new TAS(20, 20, 0);

            KAGIT kagıt6 = new KAGIT(10, 30, 0);
            KAGIT kagıt7 = new KAGIT(10, 30, 0);
            KAGIT kagıt8 = new KAGIT(10, 30, 0);
            KAGIT kagıt9 = new KAGIT(10, 30, 0);
            KAGIT kagıt10 = new KAGIT(10, 30, 0);

            MAKAS makas6 = new MAKAS(30, 10, 0);
            MAKAS makas7 = new MAKAS(30, 10, 0);
            MAKAS makas8 = new MAKAS(30, 10, 0);
            MAKAS makas9 = new MAKAS(30, 10, 0);
            MAKAS makas10 = new MAKAS(30, 10, 0);

            USTA_MAKAS ustaMakas4 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas5 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas6 = new USTA_MAKAS(15, 20, 20, 0);

            OZEL_KAGIT ozelKagıt4 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt5 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt6 = new OZEL_KAGIT(25, 20, 20, 0);

            AGIR_TAS agırTas4 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas5 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas6 = new AGIR_TAS(35, 20, 20, 0);

            singleton.kartlistesib1[0] = tas6;
            singleton.kartlistesib1[1] = tas7;
            singleton.kartlistesib1[2] = tas8;
            singleton.kartlistesib1[3] = tas9;
            singleton.kartlistesib1[4] = tas10;
            singleton.kartlistesib1[5] = kagıt6;
            singleton.kartlistesib1[6] = kagıt7;
            singleton.kartlistesib1[7] = kagıt8;
            singleton.kartlistesib1[8] = kagıt9;
            singleton.kartlistesib1[9] = kagıt10;
            singleton.kartlistesib1[10] = makas6;
            singleton.kartlistesib1[11] = makas7;
            singleton.kartlistesib1[12] = makas8;
            singleton.kartlistesib1[13] = makas9;
            singleton.kartlistesib1[14] = makas10;
            singleton.kartlistesib1[15] = agırTas4;
            singleton.kartlistesib1[16] = agırTas5;
            singleton.kartlistesib1[17] = agırTas6;
            singleton.kartlistesib1[18] = ozelKagıt4;
            singleton.kartlistesib1[19] = ozelKagıt5;
            singleton.kartlistesib1[20] = ozelKagıt6;
            singleton.kartlistesib1[21] = ustaMakas4;
            singleton.kartlistesib1[22] = ustaMakas5;
            singleton.kartlistesib1[23] = ustaMakas6;
            /////////////////////////////////////////////

            TAS tas11 = new TAS(20, 20, 0);
            TAS tas12= new TAS(20, 20, 0);
            TAS tas13= new TAS(20, 20, 0);
            TAS tas14= new TAS(20, 20, 0);
            TAS tas15 = new TAS(20, 20, 0);

            KAGIT kagıt11 = new KAGIT(10, 30, 0);
            KAGIT kagıt12 = new KAGIT(10, 30, 0);
            KAGIT kagıt13 = new KAGIT(10, 30, 0);
            KAGIT kagıt14 = new KAGIT(10, 30, 0);
            KAGIT kagıt15 = new KAGIT(10, 30, 0);

            MAKAS makas11 = new MAKAS(30, 10, 0);
            MAKAS makas12 = new MAKAS(30, 10, 0);
            MAKAS makas13 = new MAKAS(30, 10, 0);
            MAKAS makas14 = new MAKAS(30, 10, 0);
            MAKAS makas15 = new MAKAS(30, 10, 0);

            USTA_MAKAS ustaMakas7 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas8 = new USTA_MAKAS(15, 20, 20, 0);
            USTA_MAKAS ustaMakas9 = new USTA_MAKAS(15, 20, 20, 0);

            OZEL_KAGIT ozelKagıt7 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt8 = new OZEL_KAGIT(25, 20, 20, 0);
            OZEL_KAGIT ozelKagıt9 = new OZEL_KAGIT(25, 20, 20, 0);

            AGIR_TAS agırTas7 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas8 = new AGIR_TAS(35, 20, 20, 0);
            AGIR_TAS agırTas9 = new AGIR_TAS(35, 20, 20, 0);

            singleton.kartlistesib2[0] = tas11;
            singleton.kartlistesib2[1] = tas12;
            singleton.kartlistesib2[2] = tas13;
            singleton.kartlistesib2[3] = tas14;
            singleton.kartlistesib2[4] = tas15;
            singleton.kartlistesib2[5] = kagıt11;
            singleton.kartlistesib2[6] = kagıt12;
            singleton.kartlistesib2[7] = kagıt13;
            singleton.kartlistesib2[8] = kagıt14;
            singleton.kartlistesib2[9] = kagıt15;
            singleton.kartlistesib2[10] = makas11;
            singleton.kartlistesib2[11] = makas12;
            singleton.kartlistesib2[12] = makas13;
            singleton.kartlistesib2[13] = makas14;
            singleton.kartlistesib2[14] = makas15;
            singleton.kartlistesib2[15] = agırTas7;
            singleton.kartlistesib2[16] = agırTas8;
            singleton.kartlistesib2[17] = agırTas9;
            singleton.kartlistesib2[18] = ozelKagıt7;
            singleton.kartlistesib2[19] = ozelKagıt8;
            singleton.kartlistesib2[20] = ozelKagıt9;
            singleton.kartlistesib2[21] = ustaMakas7;
            singleton.kartlistesib2[22] = ustaMakas8;
            singleton.kartlistesib2[23] = ustaMakas9;
            ////////////////////////////////////////////
            BILGISAYAR bilgisayar1 = new BILGISAYAR("10112205484","bilgisayar1");
            BILGISAYAR bilgisayar2 = new BILGISAYAR("10112205485", "bilgisayar2");
            
            singleton.oyuncu[0]=bilgisayar1;
            singleton.oyuncu[1] = bilgisayar2;
            //label4.Text = singleton.kartlistesib2[12].dayanıklılık.ToString();


        }


        Singleton singleton = Singleton.GetInstance();

        


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            //this.Hide();
            Form3 form3 = new Form3();
            form2.Close();
            form3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            //this.Hide();
            Form6 form6 = new Form6();
            form2.Close();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            singleton.hamle = sayi;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
