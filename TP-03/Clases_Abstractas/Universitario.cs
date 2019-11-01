using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public bool Equals(object obj)
        {

        }

        protected string MostrarDatos() //* es protected?
        {

        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            /*
            foreach (Llamada call in c.listaDeLlamadas)
            {
                if (llamada == call)
                {
                    retorno = true;
                    break;
                }
            }
            */
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase()
        {

        }

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(nombre, apellido, dni, nacionalidad)
        {

        }

    }
}
