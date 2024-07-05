using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco_tripulacion
{
    public class Taller
    {
        List<Barco> listaBarcos;
        public List<Barco> ListaBarcos { get => listaBarcos; set => listaBarcos = value; }
        public Taller()
        {
            ListaBarcos = new List<Barco>();
        }

        public bool EncontrarBarco(Barco b1)
        {
            bool encontro;
            foreach (Barco barco in listaBarcos)
            {
                if (barco is Pirata && b1 is Pirata)
                {
                    Pirata pirata1 = (Pirata)(barco);
                    Pirata pirata2 = (Pirata)(b1);

                    if (pirata1 == pirata2)
                    {
                        encontro = true;
                    }
                }
            }
            return encontro;

        }

        public Taller IngresarBarco()
        {

        }

        public bool Reparar()
        {

        }



    }
}
