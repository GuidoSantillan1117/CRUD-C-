using Barco_tripulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml
{
    public interface iArchivos
    {
        public void Serializar(string path, List<Barco> listaBarcos);

        public void Deserializar(string path, List<Barco> listaBarcos);
    }
}
