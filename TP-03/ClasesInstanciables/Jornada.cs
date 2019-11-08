using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
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
        public Universidad.EClases Clase { get; set; }
        public Profesor Instructor { get; set; }

        public bool Guardar(Jornada jornada)
        {

        }

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public string Leer()
        {

        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

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

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if(!(a != j.clase)) //Reee reutilice codigo, con amor! ;)
            {
                retorno = true;
            }         
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: \r\n");            
            sb.AppendFormat("CLASE DE: {0} POR  {1}\r\n\r\n", this.Clase, this.Instructor);
            sb.AppendLine("ALUMNOS: \r\n");
            foreach (Alumno student in this.Alumnos) 
            {
                sb.AppendFormat("{0}\r\n", student.ToString());
            }                    
            return sb.ToString();
        }
    }
}
