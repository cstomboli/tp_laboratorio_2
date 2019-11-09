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

        #region Constructores

        /// <summary>
        /// 
        /// </summary>
        public Profesor() : base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        static Profesor()
        {           
            random = new Random(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _ramdomClases();
            _ramdomClases();            
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Carga en la cola, de la clase del dia un numero randon menor del maximo indicado.
        /// </summary>
        private void _ramdomClases() 
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(4));
        }

        /// <summary>
        /// Sobreescribe el metodo.
        /// </summary>
        /// <returns>Cadena con dicha informacion.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos()); 
            sb.AppendLine(ParticiparEnClase());
            
            return sb.ToString();
        }

        /// <summary>
        /// Compara si el profesor es distinto a la clase, es que no da 
        /// dicha clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>True si no la da, false si la da.</returns>
        public static bool operator !=(Profesor u, Universidad.EClases clase)
        {
            return (!(u == clase));
        }

        /// <summary>
        /// Compara si el profesor es igual a la clase, es que da esa clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>True si la da, false si no la da.</returns>
        public static bool operator ==(Profesor g, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach(Universidad.EClases da in g.clasesDelDia)
            {
                if (da == clase)
                {
                    retorno = true;
                }
            }            
            return retorno;
        }

        /// <summary>
        /// Sobreescribe al metodo.
        /// </summary>
        /// <returns>Cadena, con dicha informacion.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendFormat("{0}\r\n", clase.ToString());
            }            
            return sb.ToString();
        }

        /// <summary>
        /// Hace publicos los datos del profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }
        #endregion
    }
}
