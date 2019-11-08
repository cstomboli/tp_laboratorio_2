using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones 
{
    public class DniInvalidoExeptionn : Exception 
    {
        private static string msj= "Dni con error de formato.";


        public DniInvalidoExeptionn () :this(msj)
        {

        }

        public DniInvalidoExeptionn(Exception e) : this(msj,e)
        {

        }

        public DniInvalidoExeptionn(string mensaje) :base(mensaje)
        {
            
        }

        public DniInvalidoExeptionn(string mensaje, Exception e) : base(mensaje, e)
        {
            

        }
    }
}
