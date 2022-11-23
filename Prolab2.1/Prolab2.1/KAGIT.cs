using Prolab2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class KAGIT : NESNE
    {

        public KAGIT(double nüfuz, double dayanıklılık, double seviyepuanı) : base(seviyepuanı, dayanıklılık)
        {
            this.nüfuz = nüfuz;
            this.dayanıklılık = dayanıklılık;
            this.seviyepuanı = seviyepuanı;
        }

        public double nüfuz;
        public double dayanıklılık;
        public double seviyepuanı;
        public override double durumGuncelle()
        {
            return dayanıklılık;
        }

        public override double etki()
        {

            double etki = nüfuz;


            return etki;
        }

        public override double nesnePuaniGoster()
        {
            return seviyepuanı;
        }

    }
}

