using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco_tripulacion
{
    public class Pirata : Barco
    {
        public override int Tripulacion
        {
        get { return tripulacion; }
        set { 
                 if (value < 0)
                 { 
                    Random random = new Random();
                    value = GenerarRandom.EnteroAleatorio(10, 30);
                }
                else
                {
                    value = tripulacion;
                }
             }
        }
        public Pirata()
        {
            
        }
        public Pirata(float costo, bool estado, string nombre, int tripulacion,Eoperacion operacion ) : base(costo,estado,nombre,tripulacion,operacion)
        {
             
        }

        public override void CalcularCosto()
        {
            Random random = new Random();
            this.Costo = GenerarRandom.EnteroAleatorio(1200, 2000);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del barco Pirata:");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
