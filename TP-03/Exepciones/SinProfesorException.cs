using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class SinProfesorException :Exception
    {
        /// <summary>
        /// Llamada al constructor de la base y le pasa un mensaje en duro.
        /// </summary>
        public SinProfesorException() :base("No hay Profesor para la clase.")
        {

        }
    }
}
