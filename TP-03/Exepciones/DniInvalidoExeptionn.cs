using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones 
{
    public class DniInvalidoExeptionn : Exception //Dudas en esta clase
    {
        public DniInvalidoExeptionn ()
        {

        }

        public DniInvalidoExeptionn(Exception e)
        {

        }

        public DniInvalidoExeptionn(string mensaje)
        {
            
        }

        public DniInvalidoExeptionn(string mensaje, Exception e) : this("Dni con error de formato.")
        {
            

        }
    }
}
