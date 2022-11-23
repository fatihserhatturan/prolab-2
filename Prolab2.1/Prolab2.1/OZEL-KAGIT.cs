using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class OZEL_KAGIT : KAGIT

    {
        public OZEL_KAGIT(double nüfuz,double kalınlık,double dayanıklılık,double seviyepuanı) : base( nüfuz,  dayanıklılık,  seviyepuanı)
        {
            this.kalınlık = kalınlık;
            this.nüfuz = nüfuz;
            this.dayanıklılık = dayanıklılık;
            this.seviyepuanı = seviyepuanı;
        }
        public double nüfuz;
        public double kalınlık;
        public double dayanıklılık;
        public double seviyepuanı;
        
        public override double durumGuncelle()
        {
            return dayanıklılık;
        }
        
        public override double etki()
        {
            double etki = nüfuz*kalınlık;


            return etki;
        }
        public override double nesnePuaniGoster()
        {
            return seviyepuanı;
        }
    }
}
