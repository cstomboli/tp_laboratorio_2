using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #region Metodos 

        /// <summary>
        /// Constructor por defecto que llama a la base.
        /// </summary>
        public Alumno() :base()
        {

        }

        /// <summary>
        /// Inicializa la clase que toma y le pasa a la base los demas parametros
        /// recibidos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Inicializa el estado de cuenta y le pasa al constructor de esta misma clase
        /// los demas parametros recibidos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) :this(id, nombre,apellido,dni,nacionalidad,claseQueToma)
        {            
            this.estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Sobreescribe el metodo Mostrar datos, para mostrar lo que declara.
        /// </summary>
        /// <returns>Una cadena, con dicha informacion.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            string estado = "";
            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                estado = "Cuota al día";
                sb.AppendFormat("ESTADO DE CUENTA: {0}\r\n", estado);
            }
            else
            {
                sb.AppendFormat("ESTADO DE CUENTA: {0}\r\n", this.estadoCuenta);
            }
            sb.AppendLine(ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// El metodo compara si el Alumno es igual a la clase, 
        /// si toma esa clase y no es Deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>True si la toma, false si no lo es. </returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if((!(a!=clase)) && (a.estadoCuenta != EEstadoCuenta.Deudor))
            {
                retorno = true;
            }          
            return retorno;    
        }

        /// <summary>
        /// El metodo compara si el Alumno es distinto a la clase, 
        /// si no toma esa clase 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>True si es distinto, false si no lo es.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if (a.claseQueToma != clase)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Sobreescribe al metodo Participar En Clase, para mostrar la 
        /// clase que el alumno tomaa.
        /// </summary>
        /// <returns>Una cadena con dicha informacion.</returns>
        protected override string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendFormat("TOMA CLASES DE: {0}", this.claseQueToma); //Si no lo tira, poner .ToString()
            return sb.ToString();
        }

        /// <summary>
        /// Sobreescribe al metodo ToString para Mostrar la cadena de Mostrar Datos.
        /// Hace publicos los datos del Alumno.
        /// </summary>
        /// <returns>Una cadena, con dicha informacion.</returns>
        public override string ToString()
        {    
            return MostrarDatos();
        }
        #endregion
    }
}
