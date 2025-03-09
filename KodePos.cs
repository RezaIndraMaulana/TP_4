using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300109
{
    class KodePos
    {
        public enum kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, MargaSari, Sekejati, Kebonwaru, Maleer, Samoja};

        public static int getKodePos(kelurahan Kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287 , 40286 , 40286 , 40286 , 40272 , 40274 , 40273 };
            return kodePos[(int)Kelurahan];
        }
    }
}
