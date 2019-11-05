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

        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) :base(id, nombre, apellido, dni, nacionalidad)
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) :this(id, nombre,apellido,dni,nacionalidad,claseQueToma)
        {          
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Estado de cuenta: {0}\n", this.estadoCuenta);

            return sb.ToString();
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach()
            {
                if (a==clase && a.estadoCuenta != EEstadoCuenta.Deudor)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        protected override string ParticiparEnClase ()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendFormat("Toma clase de: {0}\n", this.claseQueToma);
            return sb.ToString();
        }

        public override string ToString()
        {
            //Hara publicos los datos del alumno? Asi??
            return MostrarDatos();
        }
    }
}
