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

        public Jornada(Universidad.EClases clase, Profesor instructor)
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
                //if (!(j == a))
                if (!(lista == a))
                {                    
                    j.Alumnos.Add(a); //asi?
                }
            }            
            return j;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumno in j.alumnos )
            {
                if(alumno==a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.Alumnos);
            sb.AppendFormat("Apellido: {0}\n", this.Clase);
            sb.AppendFormat("Dni: {0}\n", this.Instructor);

            return sb.ToString();
        }
    }
}
