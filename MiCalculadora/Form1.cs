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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        
        private void btnLimpiar(object sender, EventArgs e)
        {
            Limpiar();
        } 

        private void ButtonCerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado=Operar(Operador1.Text, Operador2.Text, comboBoxOperador.Text);
            label1.Text=resultado.ToString();
        }

        

        public static double Operar(string numero1,string numero2, string operador)
        {
            Numero numeroAux = new Numero(numero1);
            Numero numeroAux2 = new Numero(numero2);

            double retorno;

            retorno = Calculadora.Operar(numeroAux, numeroAux2, operador);

            return retorno;      
        }

        private void Limpiar ()
        {
            Operador1.Text = "";
            Operador2.Text = "";
            comboBoxOperador.Text = "";
            label1.Text = "";
        }

        private void ConvertirAbinario_Click(object sender, EventArgs e)
        {
            
                Numero num = new Numero(label1.Text);

                label1.Text = num.DecimalBinario(label1.Text);
        }
        /// <summary>
        /// 
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
