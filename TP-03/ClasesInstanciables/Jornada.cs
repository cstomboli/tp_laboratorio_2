using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                this.alumnos = value;
            }

        }
        public Universidad.EClases Clase
        {
            get
            {
                return clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            Texto texto = new Texto();

            if (texto.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Jornada", jornada.ToString()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Inicializa la lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Iniciliza la clase y el profesor.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            string datos;
            string retorno="";

            Texto texto = new Texto(); 

            if(texto.Leer(AppDomain.CurrentDomain.BaseDirectory+"Jornada", out datos))
            {
                retorno= datos;
            }
            return retorno;         
        }

        /// <summary>
        /// Compara si la Jornada es distina al Alumno es porque el 
        /// alumno no participa de la misma.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si no participa, false si participa.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un alumno a la jornada, si no esta cargado.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            foreach(Alumno lista in j.alumnos)
            {             
                if (lista != a)
                {                    
                    j.Alumnos.Add(a);
                }
            }            
            return j;
        }

        /// <summary>
        /// Compara si la Jornada es igual al Alumno es porque el 
        /// alumno participa de la misma.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si participa, false si no participa.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if(!(a != j.clase)) //Reee reutilice codigo, con amor! ;)
            {
                retorno = true;
            }         
            return retorno;
        }

        /// <summary>
        /// Sobreescribe el metodo, para mostrar la informacion de la Jornada.
        /// </summary>
        /// <returns>Cadena, con dicha informacion.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");            
            sb.AppendFormat("CLASE DE: {0} POR  {1}", this.Clase, this.instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno student in this.Alumnos) 
            {
                sb.AppendFormat("{0}", student.ToString());
            }                    
            return sb.ToString();
        }

#endregion
    }
}
