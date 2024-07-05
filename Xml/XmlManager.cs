using Barco_tripulacion;
using System.Xml.Serialization;

namespace Xml
{
    public class XmlManager : iArchivos
    {
        public void Deserializar(string path,List<Barco>listaBarcos)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Barco>));
                listaBarcos = (List<Barco>)des.Deserialize(sw);
            }
        }

        public void Serializar(string path, List<Barco> listaBarcos)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Barco>));
                ser.Serialize(sw, listaBarcos);
            }
        }
    }
}
