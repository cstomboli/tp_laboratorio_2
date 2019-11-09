using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Llamada al constructor de la base que recibe un msj.
        /// </summary>
        /// <param name="mensaje"></param>
        public NacionalidadInvalidaException (string mensaje) :base(mensaje)
        {
            
        }

        /// <summary>
        /// Llamada al constructor de la clase y le pasa un mensaje en duro.
        /// </summary>
        public NacionalidadInvalidaException() : this ("La Nacionalidad no se condice con el numero de DNI")
        {
            
        }

    }
}
