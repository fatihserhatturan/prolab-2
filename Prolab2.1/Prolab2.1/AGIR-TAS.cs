using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prolab2
{
    internal class AGIR_TAS : TAS
    {
        
        public AGIR_TAS(double sıcaklık,double dayanıklılık,double seviyepuanı,double katılık) : base(sıcaklık,dayanıklılık,seviyepuanı)
        {
            this.sıcaklık = sıcaklık;
            this.dayanıklılık = dayanıklılık;
            this.katılık = katılık;
            this.seviyepuanı=seviyepuanı;
        }
        public double katılık;
        public double sıcaklık;
        public double seviyepuanı;
        public double dayanıklılık;

        
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
            double etki = katılık*sıcaklık;


            return etki;
        }
        
    }
}
