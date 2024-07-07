using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Barcosproyecto;
namespace Serializacion
{
    public class XmlManager : iArchivos
    {
        List<Barco> listaBarcos;
        public XmlManager(List<Barco> listaB)
        {
            listaBarcos = listaB;
        }
        public List<Barco> Leer(string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Barco>));
                this.listaBarcos = (List<Barco>)des.Deserialize(sw);

            }
            return this.listaBarcos;
        }

        public bool Guardar(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Barco>));
                    ser.Serialize(sw, this.listaBarcos);
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} Error en la escritua del XML, revisar la ruta.");
            }
        } 
    }
}