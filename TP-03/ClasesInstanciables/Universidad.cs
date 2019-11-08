using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

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

        public Universidad()
        {
            this.jornada = new List<Jornada>();
            this.alumnos = new List<Alumno>();
            this.profesor = new List<Profesor>();

        }

        public bool Guardar(Universidad uni)
        {

        }

        public Universidad Leer()
        {

        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada esta in uni.Jornadas)
            {
                sb.AppendFormat("{0}\r\n", esta.ToString());
                sb.AppendLine("<----------------------------------------->");
            }            
            return sb.ToString();
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
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

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u==a))
            {
                u.Alumnos.Add(a);                       
            }
            else
            {
                throw (new AlumnoRepetidoExeption());
            }
            return u;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!(u == i))
            {
                u.Instructores.Add(i);
            }
            return u;
        }

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
                    throw new SinProfesorExeption();
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        
    }
}
