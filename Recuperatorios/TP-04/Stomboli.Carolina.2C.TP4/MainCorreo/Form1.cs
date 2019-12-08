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

namespace MainCorreo
{
    public partial class Form1 : Form
    {
        private Correo correo;

        public Form1()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            
            p.InformarEstado += paq_InformaEstado;
            try
            {
                correo += p;
            }
            catch (TrackingIdRepetidoException error)
            {
                MessageBox.Show(error.Message);
            }
            ActualizarEstados();
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();    ///mmmmmm
            }
            
        }
        
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();
            //lstEstadoEnViaje.ResetText();
            //lstEstadoIngresado.ResetText(); //ver q onda el reset este

            foreach(Paquete lista in correo.Paquete)
            {
                switch(lista.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                       /// lstEstadoIngresado.Text = lista.ToString(); //Version si esto funciona.
                        lstEstadoIngresado.Items.Add(lista);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(lista);
                        //lstEstadoEnViaje.Text = lista.ToString();
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(lista);
                        //lstEstadoEntregado.Text = lista.ToString();
                        PaqueteDAO.Insertar(lista);
                        break;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            correo.FinEntregas();
        }

        private void MostrarInformacion<T>(IMostrar<T> elementos)
        {

            if (elementos != null)
            {
                rtbMostrar.Clear();
                rtbMostrar.Text = elementos.MostrarDatos(elementos);
                rtbMostrar.Text.Guardar( "salida.txt");

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
