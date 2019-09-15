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

        public string SetNumero
        {
           set {  numero = ValidarNUmero(value); }
        }        

        public string BinarioDecimal (string binario)
        {
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
             
            return Convert.ToString(num_decimal);
        }

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

        public Numero ()
        {
            this.numero = 0;
        }

        public Numero (double numero)
        {
            this.numero = numero;
        }

        public Numero (string strNumero)
        {
            double.TryParse(strNumero, out numero);           
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return  (n1.numero*n2.numero);
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = (n1.numero / n2.numero);

            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            return retorno;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

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
