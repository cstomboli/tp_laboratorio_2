using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Jornada> Jornadas { get; set; }
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

        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
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
            return !(u == clase);
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {          
            if (!(g==clase))
            {
               // g.botella.Add(b);                               
            }
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u==a))
            {
               // u.Add();        Nunca se como agregar!                      
            }
            return u;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!(u == i))
            {
               // g.botella.Add(b);
            }
            return u;
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumno in g.Alumnos) // Aca tendria q ir lista de alumnos!
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

            foreach(Profesor profesor in g.Instructores) //Lista de Instructores??
            {
                if(profesor==a)
                {
                    retorno = true;
                }
            }            
            return retorno;
        }

        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor lista in g.profesor)//Chan
            {
                if(lista==clase)
                {
                    retorno= lista;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }
}
