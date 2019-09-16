using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Instancia al numero.
        /// </summary>
        public string SetNumero
        {
           set {  numero = ValidarNUmero(value); }
        }        

        /// <summary>
        /// Transforma un numero Binario a Decimal.
        /// </summary>
        /// <param name="binario">El numero binario en tipo string.</param>
        /// <returns>El numero decimal en tipo string.</returns>
        public string BinarioDecimal (string binario)
        {
            #region MyRegion
            /*
            if (binario != "" && binario[0] != '-')
            {
                try
                {
                    return Convert.ToInt64(binario, 2).ToString();
                }
                catch (System.FormatException) //Lanza esta excepción si el texto no está en formato binario
                {
                    return "Valor invalido."; //Si salta la excepción, se devuelve "Valor invalido.".
                }
            }
            return "Valor invalido."; //Si el numero esta vacio o es negativo, devuelve "Valor invalido.".
            */
            #endregion            

            string retorno = "valor invalido";
            int exponente = binario.Length - 1;
            int num_decimal = 0;

            for (int i = 0; i < binario.Length; i++)
            {

                if (int.Parse(binario.Substring(i, 1)) == 1)
                {
                    num_decimal += int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }

            retorno = Convert.ToInt32(num_decimal).ToString();
            return retorno;           
        }

        /// <summary>
        /// Transforma un numero Decimal a Binario.
        /// </summary>
        /// <param name="numero">Recibe un numero del tipo double.</param>
        /// <returns>Un numero binario de tipo string.</returns>
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
                retorno = cadena;
            }
            else if (numero == 0)
            {
                retorno = "0";
            }
            return retorno;    
        }

        /// <summary>
        /// Recibe y retorna el numero en string
        /// </summary>
        /// <param name="numero">Recibe el numero</param>
        /// <returns>El numero en tipo string</returns>
        public string DecimalBinario(string numero)
        {            
            double aux;
            double.TryParse(numero, out aux);
            return  DecimalBinario(aux);
            #region otraForma
            /*
            int.Parse(binario); //Validando la Caja de Texto.
            int dato = Convert.ToInt32(binario); //Leyendo y Almacenando Datos en Variable.
            int datu = dato; //Declaracion de Variable para NO modificar; solo Imprimir.
            List <int> lista1 = new List<int>(); //Declarando Array List para Almacenar los Digitos.

            //Operacion Principal** -- Se divide el numero Decimal entre la Base Guardando los Residuos
            while (dato > 0)
            {
                int residuo = dato % 2; //Obtiendo como Valores 1 o 0.
                dato = dato / 2;//Disminuyendo el numero decimal Terminar el Ciclo.
                lista1.Add(residuo); //Almacenando Valor de 1 o 0 en Array.
            }

            //Impresion de Resultado.**
            string alerta = ""; //Reseteando Impresion.
            for (int i = lista1.Count - 1; i >= 0; i--) //Se declara el For para que imprima de atras para adelante
            {
                alerta += Convert.ToString(lista1[i]); //Imprimiendo y Almacenando Datos en la Label
            }

            //lblAlerta.Visible = false;
            return alerta;*/
            #endregion
        }

        /// <summary>
        /// Le asina el valor 0 a numero.
        /// </summary>
        public Numero ()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Le asigna valor a numero.
        /// </summary>
        /// <param name="numero">El valor a asignar.</param>
        public Numero (double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Transforma el numero que reibe en string a double.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero (string strNumero)
        {
            double.TryParse(strNumero, out numero);           
        }

        /// <summary>
        /// Sobrecarga el operador -
        /// </summary>
        /// <param name="n1">Recibe el primera numero.</param>
        /// <param name="n2">Recibe el segundo numero.</param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Sobrecarga el operador *
        /// </summary>
        /// <param name="n1">Recibe el primera numero.</param>
        /// <param name="n2">Recibe el segundo numero.</param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return  (n1.numero*n2.numero);
        }

        /// <summary>
        /// Sobrecarga el operador /
        /// </summary>
        /// <param name="n1">Recibe el primera numero.</param>
        /// <param name="n2">Recibe el segundo numero.</param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = (n1.numero / n2.numero);

            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga el operador +
        /// </summary>
        /// <param name="n1">Recibe el primera numero.</param>
        /// <param name="n2">Recibe el segundo numero.</param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Transforma un string en double.
        /// </summary>
        /// <param name="StrNumero">Recibe el numero en forma de string.</param>
        /// <returns></returns>
        public double ValidarNUmero (string StrNumero)
        {
            double numero;
            double retorno=0;

            if (double.TryParse(StrNumero, out numero))
            {
                retorno = numero;
            }
            return retorno;
        }
    }
}
