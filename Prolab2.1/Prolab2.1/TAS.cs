using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class TAS : NESNE


    {
        public TAS(double katılık,double dayanıklılık,double seviyepuanı) : base(dayanıklılık,seviyepuanı)
        {
            this.katılık = katılık;
            this.dayanıklılık = dayanıklılık;
            this.seviyepuanı = seviyepuanı;
        }
        public double katılık;
        public double dayanıklılık;
        public double seviyepuanı;
        
        public override double durumGuncelle()
        {

            return dayanıklılık;
        }
        
        public override double nesnePuaniGoster()
        {
            return seviyepuanı;
        }
        
        public override double etki()
        {
            double etki = katılık;


            return etki;
        }
        
    }
}
