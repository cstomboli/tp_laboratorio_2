using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class NacionalidadInvalidaExeption : Exception
    {
        
        public NacionalidadInvalidaExeption (string mensaje) 
        {
            
        }

        public NacionalidadInvalidaExeption() : this ("El Dni no esta entre los parametros establecidos.")
        {
            
        }

    }
}
