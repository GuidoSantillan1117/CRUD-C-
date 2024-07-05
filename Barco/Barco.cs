using System.Text;

namespace Barco_tripulacion
{
    public abstract class Barco
    {
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        Eoperacion operacion;
        public enum Eoperacion
        {
            Reparar_Mastil,
            Pintar,
            Cambiar_Velas,
            Reparar_Mascaron,
            Repara_Casco,
            Recargar_Cañones

        }
        protected int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Eoperacion Operacion { get => operacion; set => operacion = value; }
        public abstract int Tripulacion { get; set; }

        public Barco()
        {
             
        }

        public Barco(float costo,bool estado,string nombre,int tripulacion,Eoperacion operacion)
        {
            this.operacion = operacion;
            this.costo = costo;
            this.estadoReparado = estado;
            this.nombre = nombre;
            this.tripulacion = tripulacion;
      
        }

        public abstract void CalcularCosto();

        public static bool operator == (Barco a,Barco b)
        {
            bool pudo = false;
            if (a.nombre  == b.nombre) pudo = true;
            return pudo;
        }

        public static bool operator != (Barco a,Barco b) {  return !(a == b); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Costo: {this.costo}");
            if (this.estadoReparado == true) { sb.AppendLine($"Estado reparado: Fue reparado"); }
            else
            {
                sb.AppendLine($"Estado reparado: No fue reparado");
            }
            sb.AppendLine($"Cantidad de tripulacion: {tripulacion}");

            return sb.ToString();


        }
    }
}
