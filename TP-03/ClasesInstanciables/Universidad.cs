using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesor;

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
        public List<Profesor> Instructores
        {
            get
            {
                return profesor;
            }
            set
            {
                this.profesor = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return jornada[i];
            }                
            set
            {
                jornada[i] = value;
            }
        }

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #region Metodos

        /// <summary>
        /// Inicializa la lista de: Jornada, alumno y profesor.
        /// </summary>
        public Universidad()
        {
            this.jornada = new List<Jornada>();
            this.alumnos = new List<Alumno>();
            this.profesor = new List<Profesor>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            Xml <Universidad> universidad = new Xml<Universidad>();

            if ( universidad.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Universidad", uni))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {        
            Xml<Universidad> universidad = new Xml<Universidad>();
            Universidad uni = new Universidad();

            universidad.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad", out uni);

            return uni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada esta in uni.Jornadas)
            {
                sb.AppendFormat("{0}", esta.ToString());
                sb.AppendLine("<----------------------------------------->");
            }            
            return sb.ToString();
        }

        /// <summary>
        /// Compara si una universidad es distinta a un alumno
        /// es porque no esta inscripta en la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si no esta inscripto, false si esta inscripto.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Compara si una universidad es distinta a un profesor
        /// es porque no da clase en la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si no da clase, false si da clase.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Compara si una clase y un profesor son distintos.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>Devuelve al profesor que no puede dar la clase.</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor retorno = null;

            foreach (Profesor lista in u.profesor)
            {
                if ((lista != clase))
                {
                    retorno = lista;
                    break;
                }                
            }
            return retorno;
        }


        /// <summary>
        /// Genera una nueva Jornada indicando la clase, el profesor 
        /// y la lista de alumnos.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Una universidad.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor prof = (g == clase);
            Jornada jornada = new Jornada(clase, prof);
            foreach(Alumno este in g.Alumnos)
            {
                if(este==clase)
                {
                    jornada.Alumnos.Add(este);
                }
            }
            g.jornada.Add(jornada);
            return g;
        }

        /// <summary>
        /// Se agrega un alumno a la universidad, si no esta previamente cargado.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>La Universidad.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u==a))
            {
                u.Alumnos.Add(a);                       
            }
            else
            {
                throw (new AlumnoRepetidoException());
            }
            return u;
        }

        /// <summary>
        /// Se agrega un profesor a la universidad, si no esta previamente cargado.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns>La universidad.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!(u == i))
            {
                u.Instructores.Add(i);
            }
            return u;
        }

        /// <summary>
        /// Compara si una universidad es igual a un alumno
        /// es porque esta inscripta en la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si esta inscripto, false si no esta inscripto.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumno in g.Alumnos) 
            {
                if(alumno == a)
                {
                    retorno = true;
                    break;
                }                
            }
            return retorno;
        }

        /// <summary>
        /// Compara si una universidad es igual a un profesor
        /// es porque da clase en la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si da clase, false si no da clase.</returns>
        public static bool operator ==(Universidad g, Profesor a)
        {
            bool retorno = false;

            foreach(Profesor profesor in g.Instructores) 
            {
                if(profesor==a)
                {
                    retorno = true;
                    break;
                }
            }            
            return retorno;
        }

        /// <summary>
        /// Compara si una clase y un profesor son iguales.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>Devuelve al profesor que puede dar la clase.</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor lista in g.profesor)
            {
                if((lista==clase))
                {
                    retorno= lista;
                    break;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobreescribe el metodo, que hace publicos los datos de 
        /// la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion
    }
}
