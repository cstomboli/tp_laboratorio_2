using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01
{
    public static class Calculadora
    {
        #region "Metodos"

        /// <summary>
        /// El metodo realiza la operacion solicitada, segun el operador
        /// ingresado.
        /// </summary>
        /// <param name="num1">Primer objeto recibido para realizar la cuenta.</param>
        /// <param name="num2">Segundo objeto recibido para realizar la cuenta.</param>
        /// <param name="operador">Cuenta a realizar, segun el operador ingresado.</param>
        /// <returns>El resultado de la operacion, en tipo double.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno=0;
            switch (ValidarOperador(operador))
            {
                case "-":
                retorno = num1 - num2;
                break;

                case "*":
                retorno = num1 * num2; 
                    break;

                case "/":
                retorno = num1 / num2; 
                break;

                case "+":
                retorno = num1 + num2;
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// El metodo valida que el operador ingresado sea valido.
        /// </summary>
        /// <param name="operador">Para realizar la operacion, segun el mismo.</param>
        /// <returns>Si es invalido +, si no el operador ingresado.</returns>
        private static string ValidarOperador(string operador)
        {
                        
            if(operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }            
                return "+";                    
        }

        #endregion
    }
}
