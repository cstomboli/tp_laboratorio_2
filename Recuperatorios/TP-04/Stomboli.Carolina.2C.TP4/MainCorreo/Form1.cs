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

        /// <summary>
        /// El constructor inicializa los componentes del Form 
        /// y crea un nuevo Correo.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        /// <summary>
        /// El evento del boton agregar,  utiliza a InformarEstado para ir modificando el estado del paquete en el tiempo,
        /// utiliza al + para agregar el paquete al correo, actualiza estado lo cambia de un estado a otro y si hay un
        /// tracking id repetido captura la excepcion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// El metodo si necesita crea un delegado, si no llama a ActualizarEstados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// El metodo limpia el lst, cambia el paquetes de un estado a otro
        /// y al llamar al Insertar si se produce una excepcion captura la
        /// excepcion y muestra el mensaje correspondiente.
        /// </summary>
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();
            
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

        /// <summary>
        /// El metodo llama a FinEntregas para cerrar los hilos abiertos
        /// al cerrar el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            correo.FinEntregas();
        }

        /// <summary>
        /// El metodo limpia, muestra la informacion de los elementos, llama a guardar y le 
        /// pasa la extension y si no puedo guardar captura la exception y muestra el mensaje
        /// de error correspondiente.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elementos"></param>
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

        /// <summary>
        /// El envento llama a MostrarInformacion, para mostrar dicha informacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// El evento llama a MostrarInformacion, para mostrar dicha informacion del 
        /// elemento que se selecciona y con el mouse pone mostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
