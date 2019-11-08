using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class NacionalidadInvalidaExeption : Exception
    {
        
        public NacionalidadInvalidaExeption (string mensaje) :base(mensaje)
        {
            
        }

        public NacionalidadInvalidaExeption() : this ("La Nacionalidad no se condice con el numero de DNI")
        {
            
        }

    }
}
