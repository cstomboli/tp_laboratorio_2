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

        #region Metodos

        /// <summary>
        /// Sobreescribe el metodo Equals para chequea que
        /// el tipo que recibe sea Universitario.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si lo es, False si no lo es.</returns>
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
        /// Muestra el Legajo y la cadena del metodo ToString de la base.
        /// </summary>
        /// <returns>Una cadena, con la info.</returns>
        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("LEGAJO NUMERO: {0}\r\n", this.legajo); //No se si lo quiere o no con salto de Linea.
                                                                    //Porque lo muestra con y sin.
            return sb.ToString();
        }

        /// <summary>
        /// Compara si un Universitario es igual al otro, si es del mismo tipo
        /// y si tiene el mismo Dni o Legajo.
        /// </summary>
        /// <param name="pg1">Un universitario.</param>
        /// <param name="pg2">Otro universitario.</param>
        /// <returns>True si son iguales, false si no lo son.</returns>
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
        /// Compara si un Universitario es distinto al otro.
        /// </summary>
        /// <param name="pg1">Un universitario.</param>
        /// <param name="pg2">Otro universitario.</param>
        /// <returns>True si son distintos, false si no lo son.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Metodo abstracto para ser sobrecargado en la clase que herede
        /// de Universitario.
        /// </summary>
        /// <returns>Un string con la leyende que se sobrecargue.</returns>
        protected abstract string ParticiparEnClase();     

        /// <summary>
        /// Contructor por defecto, que llama a su constructor base.
        /// </summary>
        public Universitario() :base()
        {

        }

        /// <summary>
        /// Inicializa el Legajo y le pase a la base los demas atributos.
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

        #endregion

    }
}
