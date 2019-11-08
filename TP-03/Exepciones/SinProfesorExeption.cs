using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class SinProfesorExeption :Exception
    {
        public SinProfesorExeption() :base("No hay Profesor para la clase.")
        {

        }
    }
}
