using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador ingresado, si no es valido devuleve +
        /// </summary>
        /// <param name="operador">Recibe el simbolo de la operacion a realizar.</param>
        /// <returns>El simbolo del operador</returns>
        private static string ValidarOperador (string operador)
        {
            if (operador != "-" || operador != "+" || operador != "*" || operador != "/")
            {
                return "+";
            }
            else
            {
                return operador;
            }
        }

        #region MyRegion Con switch

        /*
    string retorno = "+";
    switch (operador)
    {
        case "*":
        retorno = "*";
        break;

        case "-":
        retorno = "-";
        break;

        case "/" :
        retorno = "/";
        break;                
    }
   return retorno;
   */

        #endregion

        /// <summary>
        /// Realiza la operacion, segun el operador ingreado.
        /// </summary>
        /// <param name="numero1">Recibe el primer numero</param>
        /// <param name="numero2">Recibe el segundo numero</param>
        /// <param name="operador">Recibe el simbolo, cuenta a realizar</param>
        /// <returns>Resultado</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno=0;
            
            switch (ValidarOperador(operador))
            {
                case "+":
                retorno = num1 + num2;
                break;
                case "-":
                retorno = num1 - num2;
                break;
                case "*":
                retorno = num1 * num2;
                break;
                case "/":
                retorno = num1 / num2;
                break;
            }          
            return retorno;
        }
    }
}
