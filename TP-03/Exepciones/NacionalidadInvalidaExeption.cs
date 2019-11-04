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

        public NacionalidadInvalidaExeption() : this ("Dni invalido")
        {
            
        }

    }
}
