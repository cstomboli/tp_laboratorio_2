using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Stomboli.Carolina._2C.TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Caro+", "Stomboli", "34d22577", Persona.ENacionalidad.Argentino);

            Console.WriteLine("Muesta", p.ToString());
            Console.ReadKey();
        }
    }
}
