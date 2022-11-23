using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public abstract class NESNE
    {

        public NESNE(double dayanıklılık,double seviyepuanı)
        {
            this.dayanıklılık = dayanıklılık;
            this.seviyepuanı = seviyepuanı;
        }

        

        public double dayanıklılık;
        public double seviyepuanı;


         public abstract double nesnePuaniGoster();

        public abstract double etki();
        

         public abstract double durumGuncelle();

    }




}
