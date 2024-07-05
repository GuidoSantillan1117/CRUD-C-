using Barco_tripulacion;

namespace El_Taller
{
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

                    if (pirata1 == pirata2)
                    {
                        return true;
                    }
                }
                else if (barco is Marina && b1 is Marina)
                {
                    Marina m1 = (Marina)(barco);
                    Marina m2 = (Marina)(b1);

                    if (m1 == m2)
                    {
                        return true;
                    }
                }
            }
            return false;


        }

        public Taller IngresarBarco(Barco b1)
        {
            Taller t = new Taller();

            if (!t.EncontrarBarco(b1))
            {
                t.listaBarcos.Add(b1);

            }

            return t;

        }

        public bool Reparar(Taller t)
        {
            bool reparado = false;
            if (t.GetType() == typeof(Taller))
            {
                foreach (Barco b in listaBarcos)
                {
                    if (b.EstadoReparado)
                    {
                        reparado = true;
                        b.CalcularCosto();
                        b.EstadoReparado = true;
                        AccesoDatos data =

                    }
                }
            }
            return reparado;

        }



    }
}