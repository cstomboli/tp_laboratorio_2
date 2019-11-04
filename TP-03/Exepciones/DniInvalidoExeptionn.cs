using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class DniInvalidoExeptionn : Exception
    {
        public DniInvalidoExeptionn ()
        {

        }

        public DniInvalidoExeptionn(Exception e)
        {

        }

        public DniInvalidoExeptionn(string mensaje)
        {
            mensaje = "Dni Incorrecto";
        }

        public DniInvalidoExeptionn(string mensaje, Exception e)
        {

        }
    }
}
