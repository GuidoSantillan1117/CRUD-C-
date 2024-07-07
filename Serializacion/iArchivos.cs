using Barcosproyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Serializacion
{
    public interface iArchivos
    {
        public bool Guardar(string path);

        public List<Barco> Leer(string path);
    }
}