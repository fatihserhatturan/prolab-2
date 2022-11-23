using Prolab2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class MAKAS : NESNE
    {

        public MAKAS(double keskinlik,double dayanıklılık,double seviyepuanı) : base(seviyepuanı, dayanıklılık)
        {
            this.keskinlik = keskinlik;
            this.dayanıklılık = dayanıklılık;
            this.seviyepuanı = seviyepuanı;
        }

        public double keskinlik;
        public double dayanıklılık;
        public double seviyepuan;

        
        public override double durumGuncelle()
        {
            return dayanıklılık;
        }

        public override double etki()
        {
            double etki = keskinlik;


            return etki;
        }
        public override double nesnePuaniGoster()
        {
            return seviyepuanı;
        }
    }
}
