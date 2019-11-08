using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Universitario)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("LEGAJO NUMERO: {0}\r\n", this.legajo);

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            
            if(pg1.Equals(pg2) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo)) 
            {
                retorno = true;               
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();     

        /// <summary>
        /// 
        /// </summary>
        public Universitario() :base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo=legajo;
        }
            
    }
}
