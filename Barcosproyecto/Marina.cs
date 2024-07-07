using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcosproyecto
{
    [Serializable]
    public class Marina : Barco
    {
        public override int Tripulacion
        {
            get { return tripulacion; }
            set
            {
                if (value == 0)
                {
                    Random random = new Random();
                    tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
                }
                else
                {
                    tripulacion = value;
                }
            }
        }
        public Marina()
        {
             
        }
        public Marina(string nombre,int tripulacion) : base(nombre)
        {
            Tripulacion = tripulacion;
        }

        public override void CalcularCosto()
        {
            double costoSolucion = GenerarRandom.DoubleAleatorio(50000, 250000);
            this.costo = (float)costoSolucion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Barco Marina:");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
