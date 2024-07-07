using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barcosproyecto;

namespace Barcosproyecto
{
    [Serializable]
    public class Taller
    {
        List<Barco> listaBarcos;
        public List<Barco> ListaBarcos { get => listaBarcos; set => listaBarcos = value; }
        public Taller()
        {
            listaBarcos = new List<Barco>();
        }

        public bool EncontrarBarco(Barco b1)
        {
            foreach (Barco barco in listaBarcos)
            {
                if (barco is Pirata && b1 is Pirata)
                {
                    Pirata pirata1 = (Pirata)(barco);
                    Pirata pirata2 = (Pirata)(b1);

                    if (barco.CompararBarcos(pirata1,pirata2))
                    {
                        return true;
                    }
                }
                else if (barco is Marina && b1 is Marina)
                {
                    Marina m1 = (Marina)(barco);
                    Marina m2 = (Marina)(b1);

                    if (barco.CompararBarcos(m1, m2))
                    {
                        return true;
                    }
                }
            }
            return false;


        }

        public Taller IngresarBarco(Barco b1)
        {

            if (!this.EncontrarBarco(b1))
            {
                this.listaBarcos.Add(b1);

            }

            return this;

        }

        public bool Reparar(Taller t)
        {
            bool reparado = false;
            if (t.GetType() == typeof(Taller))
            {
                foreach (Barco b1 in t.listaBarcos)
                {
                    if (!b1.EstadoReparado && b1.Operacion != EOperacion.Nada)
                    {
                        b1.CalcularCosto();
                        {
                            reparado = true;
                            AccesoDatos.ActualizarEstadoCosto(b1);
                            b1.EstadoReparado = true;

                        }

                    }

                }
            }
            return reparado;

        }



    }
}

