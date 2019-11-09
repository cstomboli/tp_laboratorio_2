using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Invoca a la base, le pasa el mensaje en duro y la excepcion.
        /// </summary>
        /// <param name="InnerException"></param>
        public ArchivosException(Exception InnerException) :base("Error en el archivo.", InnerException)
        {

        }
    }
}
