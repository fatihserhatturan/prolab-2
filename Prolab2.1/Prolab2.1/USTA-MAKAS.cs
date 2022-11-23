using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class USTA_MAKAS : MAKAS
    {
        public USTA_MAKAS(double direnç,double keskinlik,double dayanıklılık,double seviyepuanı) : base( keskinlik,  dayanıklılık, seviyepuanı)
        {
            this.dayanıklılık=dayanıklılık;
            this.direnç = direnç;
            this.seviyepuanı=seviyepuanı;
            this.keskinlik = keskinlik;

        }

        public double direnç;
        public double dayanıklılık;
        public double seviyepuanı;
        public double keskinlik;

        
        public override double durumGuncelle()
        {
            return dayanıklılık;
        }

        public override double etki()
        {
            double etki = direnç*keskinlik;


            return etki;
        }
        public override double nesnePuaniGoster()
        {
            return seviyepuanı;
        }

    }
}
