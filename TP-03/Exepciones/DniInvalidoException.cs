using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones 
{
    public class DniInvalidoException : Exception 
    {
        private static string msj= "Dni con error de formato.";

        #region Metodos

        /// <summary>
        /// Llamada al constructor de la clase que recibe un msj.
        /// </summary>
        public DniInvalidoException () :this(msj)
        {

        }

        /// <summary>
        /// Llamada al constructor de la clase que recibe un msj y una excepcion.
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) : this(msj,e)
        {

        }

        /// <summary>
        /// Llamada al constructor de la base que recibe un msj. 
        /// </summary>
        /// <param name="mensaje"></param>
        public DniInvalidoException(string mensaje) :base(mensaje)
        {
            
        }

        /// <summary>
        /// Llamada al constructor de la base que recibe un msj y una excepcion. 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string mensaje, Exception e) : base(mensaje, e)
        {
            

        }

        #endregion
    }
}
