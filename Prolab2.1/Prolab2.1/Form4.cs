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
    public partial class Form4 : Form
    {
        public Form4()
        {

            Singleton singleton = Singleton.GetInstance();
            InitializeComponent();

            if (singleton.b1Skor > singleton.b2Skor)
            {
                label2.Text = singleton.oyuncu[0].oyuncuadi;
                label3.Text=singleton.b1Skor.ToString();
                pictureBox1.Image = Properties.Resources.bilesyar;
            }
            if (singleton.b2Skor > singleton.b1Skor)
            {
                label2.Text = singleton.oyuncu[1].oyuncuadi;
                label3.Text = singleton.b2Skor.ToString();
                pictureBox1.Image = Properties.Resources.bilesyar;
            }
            if(singleton.b1Skor > singleton.kSkor)
            {
                label2.Text = singleton.oyuncu[0].oyuncuadi;
                label3.Text = singleton.b1Skor.ToString();
                pictureBox1.Image = Properties.Resources.bilesyar;
            }
            if (singleton.kSkor > singleton.b1Skor)
            {
                label2.Text = singleton.oyuncu[2].oyuncuadi;
                label3.Text = singleton.kSkor.ToString();
                pictureBox1.Image = Properties.Resources.kullanıcı;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
