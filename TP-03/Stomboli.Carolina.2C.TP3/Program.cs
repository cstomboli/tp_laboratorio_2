using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Exepciones;

namespace Stomboli.Carolina._2C.TP3
{
    class Program
    {
        static void Main(string[] args)
        {         

            //Division operadores = new Division(10, 0);
            try
            {
                //UnaExepcion una = new UnaExepcion("Mi excepcion",e);
                Persona p = new Persona("Caro+", "Stomboli", "342257", Persona.ENacionalidad.Argentino);
                Console.WriteLine(p.ToString());

            }
            catch (NacionalidadInvalidaExeption e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.Message);
                Exception excepcionInterna = e.InnerException;

                while (!(excepcionInterna is null))
                {
                    sb.AppendLine(excepcionInterna.Message);
                    excepcionInterna = excepcionInterna.InnerException;
                }
                Console.WriteLine(sb);
            }
            Console.ReadKey();
        }
    }
}
