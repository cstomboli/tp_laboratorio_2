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
        /// 
        /// </summary>
        private void _ramdomClases() 
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(4));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos()); 
            sb.AppendLine(ParticiparEnClase());
            
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor u, Universidad.EClases clase)
        {
            return (!(u == clase));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendFormat("{0}\r\n", clase);
            }            
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }
        #endregion
    }
}
