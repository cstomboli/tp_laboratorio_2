using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {
        /// <summary>
        /// El metodo controla la Excepcion de si hay un tracking id repetido.
        /// </summary>
        /// <param name="mensaje">El mensaje a mostrar.</param>
        public TrackingIdRepetidoException (string mensaje) :this(mensaje, null)
        {

        }

        /// <summary>
        /// El metodo controla y pasa la Excepcion a la base
        /// de si hay un tracking id repetido.
        /// </summary>
        /// <param name="mensaje">El mensaje a mostrar.</param>
        /// <param name="inner">La excepcion que recibe.</param>
        public TrackingIdRepetidoException(string mensaje, Exception inner):base(mensaje, inner)
        {

        } 
    }
}
