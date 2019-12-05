using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01
{
    public class Numero
    {
        private double numero;

        public string SetNumero 
        {  
            set
            {
                numero = ValidarNumero(value);
            }
        }

        #region "Metodos"

        /// <summary>
        /// El metodo rrecibe un numero binario y lo transforma de decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>El numero decimal en tipo string.</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invàlido";
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            int numero = 0;
            int i;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    numero += (int)Math.Pow(2, i);
                }
                else if (array[i] != '1' && array[i] != '0')
                {
                    return retorno;
                }
            }
            retorno = Convert.ToString(numero);
            return retorno;           
        }

        /// <summary>
        /// El metodo rrecibe un numero decimal y lo transforma a binario, 
        /// mediante la llamada al mismo metodo que recibe un double, y gracias a esto
        /// retorna lo que corresponde..
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero binario en tipo string.</returns>
        public string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double aux);
            return DecimalBinario(aux);

        }

        /// <summary>
        /// El metodo rrecibe un numero decimal y lo transforma a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero binario en tipo string.</returns>
        public string DecimalBinario(double numero)
        {            
            string retorno = "Valor invalido";

            if (numero > 0)
            {
                String cadena = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                retorno= cadena;
            }
            else if (numero == 0)
            {
               retorno = "0";
            }
            return retorno;            
        }

        /// <summary>
        /// El metodo valida que lo ingresado sea un numero valido.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Si es valido, el numero en tipo double, si no 0.</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out double numero))
            {
                retorno = numero;
            }
            return retorno;
        }

        #endregion

        #region "Constructores"
        /// <summary>
        /// El metodo inicia en numero en 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// El metodo carga el valor del numero que recibe, al atributo numero.
        /// </summary>
        /// <param name="numero">El valor de tipo double.</param>
        public Numero(double numero) 
        {
            this.numero = numero;
        }

        /// <summary>
        /// El metodo convierte el numero recibido a double.
        /// </summary>
        /// <param name="strNumero">El valor de tipo string.</param>
        public Numero(string strNumero) 
        {
            double.TryParse(strNumero, out numero);
        }

        #endregion

        #region "Sobre Carga de Operadores"

        /// <summary>
        /// El metodo realiza una resta.
        /// </summary>
        /// <param name="n1">Primer objeto recibido para realizar la cuenta.</param>
        /// <param name="n2">Segundo objeto recibido para realizar la cuenta.</param>
        /// <returns>El resultado en tipo double.</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// El metodo realiza una suma.
        /// </summary>
        /// <param name="n1">Primer objeto recibido para realizar la cuenta.</param>
        /// <param name="n2">Segundo objeto recibido para realizar la cuenta.</param>
        /// <returns>El resultado en tipo double.</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// El metodo realiza una division.
        /// </summary>
        /// <param name="n1">Primer objeto recibido para realizar la cuenta.</param>
        /// <param name="n2">Segundo objeto recibido para realizar la cuenta.</param>
        /// <returns>El resultado en tipo double.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero==0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// El metodo realiza una multiplicacion.
        /// </summary>
        /// <param name="n1">Primer objeto recibido para realizar la cuenta.</param>
        /// <param name="n2">Segundo objeto recibido para realizar la cuenta.</param>
        /// <returns>El resultado en tipo double.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero ;
        }

        #endregion
    }
}
