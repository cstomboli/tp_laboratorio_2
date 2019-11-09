using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class AlumnoRepetidoException :Exception
    {
        /// <summary>
        /// Invoca a la base y le pasa el mensaje en duro.
        /// </summary>
        public AlumnoRepetidoException():base("Alumno repetido.")
        {

        }
    }
}
