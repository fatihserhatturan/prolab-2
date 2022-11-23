using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2._1
{
    internal class Methods
    {
         public static float tasEtkisi_tas(float katılık)
        {

            float etki = katılık;
          

            return etki; ;

        }
        public static float tasEtkisi_kagıt(float katılık,float nüfuz )
        {
            
            float etki = katılık / (8 / 10) * nüfuz;
            

            return etki;
        }

        public static float tasEtkisi_makas(float katılık,float keskinlik)
        {
            float etki = katılık / (2 / 10) * keskinlik;
            


            return etki;
        }

        public static float tasEtkisi_agirTas(float katılık,float sıcaklık)
        {
            float etki = katılık;
            

            return etki;
        }
        public static float tasEtkisi_ozelKagıt(float katılık, float nüfuz,float kalınlık)
        {

            float etki = katılık / (8 / 10) * nüfuz * kalınlık;
            

            return etki;
        }
        public static float tasEtkisi_ustaMakas(float katılık, float keskinlik,float direnç)
        {
            float etki = katılık / (2 / 10) * keskinlik * direnç;
            


            return etki;
        }


        public static float kagıtEtkisi_tas(float nüfuz,float katılık)
        {
            float etki = nüfuz / (2 / 10) * katılık;
            

            return etki;
        }

        public static float kagıtEtkisi_kagıt(float nüfuz)
        {
            float etki = nüfuz;
            
            return etki;
        }

        public static float kagıtEtkisi_makas(float nüfuz,float keskinlik)
        {
            float etki = nüfuz / (8 / 10) * keskinlik;
            

            return etki;
        }
        public static float kagıtEtkisi_agırTas(float nüfuz, float katılık,float sıcaklık)
        {
            float etki = nüfuz / (2 / 10) * katılık * sıcaklık;
            

            return etki;
        }
        public static float kagıtEtkisi_ozelKagıt(float nüfuz,float kalınlık)
        {
            float etki = nüfuz;
            
            return etki;
        }
        public static float kagıtEtkisi_UstaMakas(float nüfuz, float keskinlik,float direnç)
        {
            float etki = nüfuz / (8 / 10) * keskinlik * direnç; 
            

            return etki;
        }


        public static float makasEtkisi_tas(float keskinlik,float katılık)
        {
            float etki = keskinlik / (8 / 10) * katılık;
            

            return etki;
        }

        public static float makasEtkisi_kagıt(float keskinlik,float nüfuz)
        {
            float etki = keskinlik / (2 / 10) * nüfuz;
            
            return etki;

        }

        public static float makasEtkisi_makas(float keskinlik)
        {
            float etki = keskinlik;
            

            return etki;
        }
        public static float makasEtkisi_agırTas(float keskinlik,float katılık,float sıcaklık)
        {
            float etki = keskinlik / (8 / 10) * katılık * sıcaklık;
            

            return etki;
        }
        public static float makasEtkisi_ozelKagıt(float keskinlik,float nüfuz,float kalınlık)
        {
            float etki = keskinlik / (2 / 10) * nüfuz * kalınlık;
            
            return etki;

        }
        public static float makasEtkisi_ustaMakas(float keskinlik,float direnç)
        {
            float etki = keskinlik;
            

            return etki;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="katılık"></param>
        /// <returns></returns>

        public static float agırTasEtkisi_tas(float katılık,float sıcaklık)
        {

            float etki = katılık * sıcaklık;
            

            return etki; ;

        }
        public static float agırTasEtkisi_kagıt(float katılık,float nüfuz,float sıcaklık)
        {

            float etki = katılık * sıcaklık / (8 / 10) * nüfuz;
            

            return etki;
        }

        public static float agırTasEtkisi_makas(float katılık,float keskinlik,float sıcaklık)
        {
            float etki = katılık * sıcaklık / (2 / 10) * keskinlik;
            


            return etki;
        }

        public static float agırTasEtkisi_agirTas(float katılık,float sıcaklık)
        {
            float etki = katılık * sıcaklık;
            

            return etki;
        }
        public static float agırtasEtkisi_ozelKagıt(float katılık,float nüfuz,float kalınlık,float sıcaklık)
        {

            float etki = katılık * sıcaklık / (8 / 10) * nüfuz * kalınlık;
            

            return etki;
        }
        public static float agırTasEtkisi_ustaMakas(float katılık,float keskinlik,float direnç,float sıcaklık)
        {
            float etki = katılık * sıcaklık / (2 / 10) * keskinlik * direnç;
            


            return etki;
        }


        public static float ozelKagıtEtkisi_tas(float nüfuz,float katılık,float kalınlık)
        {
            float etki = nüfuz * kalınlık / (2 / 10) * katılık;
            

            return etki;
        }

        public static float ozelKagıtEtkisi_kagıt(float nüfuz,float kalınlık)
        {
            float etki = nüfuz * kalınlık;
            
            return etki;
        }

        public static float ozelKagıtEtkisi_makas(float nüfuz,float keskinlik,float kalınlık)
        {
            float etki = nüfuz * kalınlık / (8 / 10) * keskinlik;
            

            return etki;
        }
        public static float ozelKagıtEtkisi_agırTas(float nüfuz,float katılık,float sıcaklık,float kalınlık)
        {
            float etki = nüfuz * kalınlık / (2 / 10) * katılık * sıcaklık;
            

            return etki;
        }
        public static float ozelKagıtEtkisi_ozelKagıt(float nüfuz,float kalınlık)
        {
            float etki = nüfuz * kalınlık;
            
            return etki;
        }
        public static float ozelKagıtEtkisi_UstaMakas(float nüfuz,float keskinlik,float direnç,float kalınlık)
        {
            float etki = nüfuz * kalınlık / (8 / 10) * keskinlik * direnç;
            

            return etki;
        }


        public static float ustaMakasEtkisi_tas(float keskinlik,float katılık,float direnç)
        {
            float etki = keskinlik * direnç / (8 / 10) * katılık;
            

            return etki;
        }

        public static float ustaMakasEtkisi_kagıt(float keskinlik,float nüfuz,float direnç)
        {
            float etki = keskinlik * direnç / (2 / 10) * nüfuz;
            
            return etki;

        }

        public static float ustaMakasEtkisi_makas(float keskinlik,float direnç)
        {
            float etki = keskinlik * direnç;
            

            return etki;
        }
        public static float ustaMakasEtkisi_agırTas(float keskinlik,float katılık,float sıcaklık,float direnç)
        {
            float etki = keskinlik * direnç / (8 / 10) * katılık * sıcaklık;
            

            return etki;
        }
        public static float ustaMakasEtkisi_ozelKagıt(float keskinlik,float nüfuz,float kalınlık,float direnç)
        {
            float etki = keskinlik * direnç / (2 / 10) * nüfuz * kalınlık;

            return etki;

        }
        public static float ustaMakasEtkisi_ustaMakas(float keskinlik,float direnç)
        {
            float etki = keskinlik * direnç;
            

            return etki;
        }

        


    }
}
