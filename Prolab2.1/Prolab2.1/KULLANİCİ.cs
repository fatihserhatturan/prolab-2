using Prolab2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    internal class KULLANİCİ : OYUNCU
    {
        public KULLANİCİ(string oyuncuID, string oyuncuadi) : base(oyuncuID, oyuncuadi)
        {
            this.oyuncuID = oyuncuID;
            this.oyuncuadi = oyuncuadi;

        }

       

        public override void SkorGoster()
        {

        }
    }
}
