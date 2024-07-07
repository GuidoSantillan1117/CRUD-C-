using Barcosproyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcosproyecto
{
    [Serializable]
    public class Pirata : Barco
    {
        public override int Tripulacion
        {
            get { return tripulacion; }
            set
            {
                if (value == 0)
                {
                    Random random = new Random();
                    tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
                }
                else
                {
                    tripulacion = value;
                }
            }
        }
        public Pirata()
        {

        }
        public Pirata(string nombre,int tripulacion) : base(nombre)
        {
            Tripulacion = tripulacion;
        }

        public override void CalcularCosto()
        {
            Random random = new Random();
            double costoSolucion = GenerarRandom.DoubleAleatorio(20000, 120000);
            this.costo = (float)costoSolucion;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Barco Pirata:");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
