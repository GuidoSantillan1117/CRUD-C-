using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco_tripulacion
{
    public static class GenerarRandom
    {
        public static double DoubleAleatorio()
        {
            Random random = new Random();
            return (double)random.NextDouble();

        }

        public static int EnteroAleatorio(int n1,int n2)
        {
            Random random = new Random();
            return random.Next(n1, n2);
        }
    }
}
