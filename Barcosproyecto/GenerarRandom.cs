using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcosproyecto
{
    public static class GenerarRandom
    {
        public static double DoubleAleatorio(double n1,double n2)
        {
            Random random = new Random();
            return random.NextDouble() * (n1-n2) + n2;

        }

        public static int EnteroAleatorio(int n1, int n2)
        {
            Random random = new Random();
            return random.Next(n1, n2);
        }
    }
}
