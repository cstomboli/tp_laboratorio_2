﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace EntidadesAbstractas
{
    public class Persona // es abstract
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad; 
        private string nombre;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #region Propiedades

        public string Appelido
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

        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                try
                {
                    this.dni = ValidarDni(this.nacionalidad, value);
                }
                catch (NacionalidadInvalidaExeption e)
                {

                }
                
            }
        }        

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

        public string stringToDni // DICE QUE DEVUELTE STRING, PERO LA FUNCION VALIDAR DNI Q RECIBE STRING DEVUELVE INT
        {
            set
            {
                try
                {
                    this.dni = ValidarDni(this.nacionalidad, value);
                }
                catch (DniInvalidoExeptionn e)
                {

                }
            }           
        }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {^0}\n", this.Nombre);
            sb.AppendFormat("Nombre: {^0}\n", this.Appelido);
            sb.AppendFormat("Nombre: {^0}\n", this.DNI);
            sb.AppendFormat("Nombre: {^0}\n", this.nacionalidad);

            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {          
            try
            {
                if (dato > 0 && dato <= 89999999)
                {
                    nacionalidad = ENacionalidad.Argentino;
                }
                else if (dato > 89999999 && dato <= 99999999)
                {
                    nacionalidad = ENacionalidad.Extranjero;
                }
                else
                {
                    throw new NacionalidadInvalidaExeption();
                }
            }
            catch (NacionalidadInvalidaExeption e)
            {
                //e.Message();
            }
            return dato;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {        
            if(int.TryParse(dato, out dni)) //Si es número correcto retornará true y saldrá
            {
               return ValidarDni(nacionalidad, Convert.ToInt32(dato));
            }
            else
            {
                throw new DniInvalidoExeptionn();
            }                
            //return  ValidarDni(nacionalidad, Convert.ToInt32(dato));  Yo queria hacer esto para reutilizar codigo, pero.            
        }

        private string ValidarNombreApellido(string dato)
        {
            //int cantidad = dato.Length;

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
        }

        #endregion




    }
}
