using System.Text;
using System.Xml.Serialization;


namespace Barcosproyecto
{
    [Serializable]
    [XmlInclude(typeof(Pirata))]
    [XmlInclude(typeof(Marina))]
    public abstract class Barco
    {
        public int id;
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        EOperacion operacion;

        protected int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion Operacion { get => operacion; set => operacion = value; }
        public abstract int Tripulacion { get; set; }
        public int Id { get => id; set => id = value; }

        public Barco()
        {

        }

        public Barco(string nombre)
        {
            this.nombre = nombre;
            this.Operacion = EOperacion.Nada;
            this.costo = 0.0f;
            this.estadoReparado = false;

        }

        public abstract void CalcularCosto();

        public  bool CompararBarcos (Barco a, Barco b)
        {
            bool pudo = false;
            if (a.nombre == b.nombre) pudo = true;
            return pudo;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Nombre: {this.nombre} |");
            sb.AppendLine($" Costo: ${this.costo} |");
            if (this.estadoReparado == true) { sb.AppendLine($" Reparado: SI |"); }
            else
            {
                sb.AppendLine($" Reparado: NO |");
            }
            sb.AppendLine($" Cantidad de tripulacion: {tripulacion} |");

            return sb.ToString();


        }
    }
}
