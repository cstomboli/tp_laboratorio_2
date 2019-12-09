using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    #pragma warning disable CS0660,CS0661
    public class Paquete : IMostrar<Paquete> 
    {

        public delegate void DelegadoEstado(object sender, EventArgs estado);
        public event DelegadoEstado InformarEstado;
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #region "Propiedades"
        public string DireccionEntrega 
        { 
            get
            {
                return direccionEntrega;
            }  
            set
            {
                direccionEntrega = value;
            }
        }
        public EEstado Estado 
        { 
            get
            {
                return estado;
            }    
            set
            {
                estado = value;
            }        
        }
        public string TrackingID 
        { 
            get
            {
                return trackingID;
            }
            set
            {
                trackingID = value;
            }        
        }
        #endregion

        #region "Metodos"

        /// <summary>
        /// El metodo cambia el estado del paquete.
        /// </summary>
        public void MockCicloDeVida()
        {          
            for(;(int)this.Estado<2; )
            {
                Thread.Sleep(4000);

                if (this.Estado==EEstado.Ingresado)
                {
                    this.Estado = EEstado.EnViaje;
                }
                else if(this.Estado == EEstado.EnViaje)
                {
                    this.Estado = EEstado.Entregado;
                }
                this.InformarEstado.Invoke(this.estado, EventArgs.Empty);
            }
        }

        /// <summary>
        /// El metodo implementa MostrarDatos de la interface,
        /// para mostrar el tracking id y la direccion del paquete.
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete>elementos)
        {            
            string sb = string.Empty;
            if(elementos is Paquete)
            {
                Paquete p = (Paquete)elementos;
                 sb = string.Format("{0} para {1}", p.TrackingID , p.direccionEntrega);
            }     
            return sb;
        }

        /// <summary>
        /// El metodo chequea si un paquete es distinto al otro,
        /// reutilizando el metodo ==.
        /// </summary>
        /// <param name="p1">El primer paquete a comparar.</param>
        /// <param name="p2">El segundo paquete a comparar.</param>
        /// <returns>True si no son iguales, false si si.</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// El metodo chequea si un paquete es igual al otro,
        /// si tienen el mismo tracking id.
        /// </summary>
        /// <param name="p1">El primer paquete a comparar.</param>
        /// <param name="p2">El segundo paquete a comparar.</param>
        /// <returns>True si son iguales, false si no.</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;

            if (p1.TrackingID == p2.TrackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Constructor de Paquete. Carga la dirreccion de entrega
        /// y el id con los parametros recibidos y estado como ingresado.
        /// </summary>
        /// <param name="direccionEntrega">La direccion a cargar.</param>
        /// <param name="trackingID">El id a cargar.</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.estado = EEstado.Ingresado;
        }

        /// <summary>
        /// El metodo sobrecarga a ToString y llama
        /// a MostrarDatos, para mostrar la informacion
        /// de los paquetes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion
    }
}
