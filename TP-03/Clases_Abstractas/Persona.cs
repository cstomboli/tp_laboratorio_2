using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad; 
        private string nombre;

        enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #region Propiedades

        public string Appeldio { get; set; }

        public int DNI { get; set; }

        //public ENacionalidad Nacionalidad { get; set; } FALTA CREAR ENacionalidad

        public string Nombre { get; set; }

        public string stringToDni { get; set; }

        #endregion

        #region Métodos

        public Persona ()
        {

        }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido,string dni, ENacionalidad nacionalidad)
        {

        }

        public string ToString()
        {

        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato>0 && dato<=89999999)
            {
                nacionalidad = ENacionalidad.Argentino;
            }
            else if(dato>89999999 && dato<=99999999)
            {
                nacionalidad = ENacionalidad.Extranjero;
            }
            //else   {                exepcion            }

            return dato;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if(int.TryParse(dato, out dni)) //Si es número correcto retornará true y saldrá
            {
                
            }
            return dni;
        }

        private string ValidarNombreApellido(string dato)
        {
            int cantidad = dato.Length;
            
            for(int i=0; i<=cantidad; i++)
            {
                
            }

        }

        #endregion




    }
}
