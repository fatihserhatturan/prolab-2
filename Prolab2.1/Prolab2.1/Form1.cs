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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş yaptıktan sonra,Kullanıcı-Bilgisayar veya Bilgisayar-Bilgisayar " +
              "seçeneklerinden birini seciniz" +
              "Ardından gelen ekrandan kart destesinden 5 adet secim yapın ve sonucu bekleyin ");

        }

        private void button1_Click(object sender, EventArgs e) {

            Form2 form2 = new Form2();

            //this.Hide();
            Form1 form1 = new Form1();
            form1.Close();
            form2.Show();

        }
}    }

