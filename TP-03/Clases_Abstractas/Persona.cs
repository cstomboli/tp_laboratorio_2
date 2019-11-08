using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona 
    {
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;         

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #region Propiedades

        /// <summary>
        /// 
        /// </summary>
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);                  
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
               this.nacionalidad = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get
            {
               return nombre ;
            }
            set
            {   
                this.nombre= ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string stringToDni
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);   
            }           
        }

        #endregion

        #region Métodos

        /// <summary>
        /// 
        /// </summary>
        public Persona ()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;       
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.stringToDni = dni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\r\n", this.Apellido, this.Nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\r\n", this.Nacionalidad);
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
             
            if ((dato > 0 && dato <= 89999999) && (nacionalidad == ENacionalidad.Argentino))
            {
                return dato;
            }
            else if ((dato > 89999999 && dato <= 99999999) && (nacionalidad== ENacionalidad.Extranjero))
            {
                return dato;
            }
            else
            {
                throw new NacionalidadInvalidaExeption();
            }          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {        
            if(int.TryParse(dato, out int dni) &&  dato.Length <= 8) 
            {
               return ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoExeptionn();
            }                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = string.Empty; //yo pondria null

            foreach(char letra in dato)
            {
                if(char.IsLetter(letra))    // && (!char.IsWhiteSpace(letra))
                {
                    retorno= dato;
                }                
            }
            /*
            int cantidad = dato.Length;
            for (int i = 0; dato[i]  != '\0'; i++)
            {
                if ((dato[i] > 'Z' || dato[i] < 'A') && (dato[i] > 'z' || dato[i] < 'a') && dato[i] != ' ')
                {
                    //false
                    //Console.WriteLine("Dato erroneo");
                    dato = null;
                }                
            }
            return dato;
            */
            return retorno;
        }

        #endregion

    }
}
