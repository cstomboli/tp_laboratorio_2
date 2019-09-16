using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa la Caculadora.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// LLama a limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar(object sender, EventArgs e)
        {
            Limpiar();
        } 

        /// <summary>
        /// Cierra la Calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Toma los datos ingresados y se llama a Operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado=Operar(Operador1.Text, Operador2.Text, comboBoxOperador.Text);
            label1.Text=resultado.ToString();
        }
        
        /// <summary>
        /// Llama a la funcion Calculadora Operar, para realizar la cuenta solicitada.
        /// </summary>
        /// <param name="numero1">Recibe el primer numero</param>
        /// <param name="numero2">Recibe el segundo numero</param>
        /// <param name="operador">Recibe el simbolo, cuenta a realizar</param>
        /// <returns></returns>
        public static double Operar(string numero1,string numero2, string operador)
        {
            Numero numeroAux = new Numero(numero1);
            Numero numeroAux2 = new Numero(numero2);

            double retorno;

            retorno = Calculadora.Operar(numeroAux, numeroAux2, operador);

            return retorno;      
        }

        /// <summary>
        /// Borra todo lo ingerado y el resultado.
        /// </summary>
        private void Limpiar ()
        {
            Operador1.Text = "";
            Operador2.Text = "";
            comboBoxOperador.Text = "";
            label1.Text = "";
        }

        /// <summary>
        /// Llama al medtodo que convierte n numero Decimal a Binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirAbinario_Click(object sender, EventArgs e)
        {
            
                Numero num = new Numero(label1.Text);

                label1.Text = num.DecimalBinario(label1.Text);
        }

        /// <summary>
        /// Llama al medtodo que convierte n numero Binario a Decimal.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirAdecimal_Click(object sender, EventArgs e)
        {
            //Numero.BinarioDecimal(label1.Text);
            Numero num = new Numero(label1.Text);

            label1.Text = num.BinarioDecimal(label1.Text);
        }
    }
}
