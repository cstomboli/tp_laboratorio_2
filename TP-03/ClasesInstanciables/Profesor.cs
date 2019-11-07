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
           
            random = new Random(); // aca le tengo q dar valor
            // Profesor.random.Next(); esto devuelve un int
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            _ramdomClases();
            //clasesDelDia.Enqueue((Universidad.EClases)_ramdomClases()));
            // clasesDelDia.Enqueue(_ramdomClases()); RANDOM CLASES DEVULVE VOID Y ME TIRA ERROR
        }

        private  void _ramdomClases() // Donde va el static de ramdon?
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(clasesDelDia.Count+1));
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()); //Como muestro aca los datos del profesor?                       

            return sb.ToString();
        }

        public static Profesor operator !=(Universidad u, Universidad.EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor lista in g.profesor)//Chan, es el mismo metodo de Universidad
            {                                       // Como lo reutilizo?
                if (!(lista == clase))
                {
                    retorno = lista;
                }                
            }
            return retorno;

        }

        public static bool operator ==(Profesor g, Universidad.EClases a)
        {
            bool retorno = false;

            foreach(Universidad.EClases da in g.clasesDelDia)
            {
                if (da == a)
                {
                    retorno = true;
                }
            }            
            return retorno;
        }

         





        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASES DEL DÍA: {0}\n", this.clasesDelDia);
            return sb.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
