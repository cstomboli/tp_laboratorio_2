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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            
            p.InformarEstado += paq_InformaEstado;
            try
            {
                correo += p;
                ActualizarEstados();
            }
            catch (TrackingIdRepetidoException error)
            {
                MessageBox.Show(error.Message, "Paquete repetido", MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            
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

                ActualizarEstados();  
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
                        lstEstadoIngresado.Items.Add(lista);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(lista);                      
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(lista);                       
                        try
                        {
                            PaqueteDAO.Insertar(lista);
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message); 
                        }
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
                
                try
                {
                    rtbMostrar.Text.Guardar("salida.txt");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message); 
                }             
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

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
