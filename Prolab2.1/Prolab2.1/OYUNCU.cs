using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public abstract class OYUNCU
    {
        public OYUNCU(string oyuncuID,string oyuncuadi)
        {
            this.oyuncuID = oyuncuID;
            this.oyuncuadi = oyuncuadi;

        }

        public string oyuncuID;
        public string oyuncuadi;
        

        public abstract void SkorGoster();

        


    }
}
