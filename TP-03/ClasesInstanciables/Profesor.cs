using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia; 
        private static Random random;

        public Profesor()
        {

        }

        static Profesor()
        {
           
            Random random = new Random(); // aca le tengo q dar valor
            // Profesor.random.Next(); esto devuelve un int
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
        }

        private  void _ramdomClases() // Donde va el static de ramdon?
        {          
            random.Next(clasesDelDia.Count);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());                        

            return sb.ToString();
        }

        public static Profesor operator !=(Universidad u, Universidad.EClases clase)
        {
            return !(u == clase);
        }

        public static bool operator ==(Profesor g, Universidad.EClases a)
        {
            bool retorno = false;

            if (g.clasesDelDia is a )
            {
                retorno = true;
            }
            return retorno;
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Da la clase: {0}\n", this.clasesDelDia);
            return sb.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
