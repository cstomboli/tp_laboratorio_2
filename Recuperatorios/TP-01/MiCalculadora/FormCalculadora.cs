using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_01;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El evento cierra el Form al apretar el boton cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// El evento escribe en el lebel el numero decimal convertido a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvBinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(labelResultado.Text);
            labelResultado.Text= numero.DecimalBinario(labelResultado.Text);
        }

        /// <summary>
        /// El evento escribe en el lebel el numero binario convertido a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvDecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(labelResultado.Text);
            labelResultado.Text = numero.BinarioDecimal(labelResultado.Text);
        }

        /// <summary>
        /// El evento limpia todos los campos completados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// El evento llama al metodo Operar, el cual realiza la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, operador.Text).ToString();
        }       

        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            operador.Text = string.Empty;
            labelResultado.Text = string.Empty;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1 , num2, operador);
        }
    }
}
