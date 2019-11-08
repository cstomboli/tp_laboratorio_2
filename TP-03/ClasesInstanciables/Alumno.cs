using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
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

        /// <summary>
        /// 
        /// </summary>
        public Alumno() :base()
        {

        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendFormat("TOMA CLASES DE: {0}\r\n", this.claseQueToma); //Si no lo tira, poner .ToString()
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
    }
}
