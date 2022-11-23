using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2._1
{
    public sealed class Singleton
    {
      
        private Singleton() { }

        private static Singleton _instance;
        public double kSkor;
        public double b1Skor;
        public double b2Skor;
        public int hamle;
        public int[] array;
        public int[] array2;
        public int[] array3;
        public char[] charArray;
        public char[] charArray2;
        public string stringArray;
        public string stringArray2;
        public int[] kartListesiK;
        public int[] kartListesiB1;
        public int[] kartListesiB2;
        public dynamic[] kartlistesiK2;
        public dynamic[] kartlistesib1;
        public dynamic[] kartlistesib2;
        public int counter;
        public int[] oyunK;
        public int[] oyunK2;
        public int counter2;
        public int counter3;
        public int[,,] sonuc;
        public dynamic[] oyuncu;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                _instance.array = new int[5];
                _instance.array2 = new int[5];
                _instance.array3 = new int[5];
                _instance.charArray = new char[1000];
                _instance.charArray2 = new char[1000];
                 _instance.stringArray = "";
                 _instance.stringArray2 = "";
                _instance.hamle = 10;
                _instance.kartListesiK = new int[5];
                _instance.kartListesiB1 = new int[5];
                _instance.kartListesiB2 = new int[5];
                _instance.kartlistesiK2 =new dynamic[24];
                _instance.kartlistesib1 = new dynamic[24];
                _instance.kartlistesib2 = new dynamic[24];
                _instance.kSkor= 0;
                _instance.b1Skor = 0;
                _instance.b2Skor = 0;
                _instance.counter = 0;
                _instance.counter2 = 0;
                _instance.oyunK = new int[20];
                _instance.oyunK2 = new int[20];
                _instance.sonuc = new int[36,36,36];
                _instance.counter3 = 0;
                _instance.oyuncu = new dynamic[3];
            }
            return _instance;
        }
         
         
        public void someBusinessLogic()
        {
            // ...
        }
    }

}
