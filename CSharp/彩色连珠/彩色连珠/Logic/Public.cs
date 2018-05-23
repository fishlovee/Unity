using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 彩色连珠;

namespace Public
{
    static class Public
    {
        static Random random = new Random();
        public static int Random(int nMin,int nMax)
        {
            return random.Next(nMin, nMax);
        }
    }
}
