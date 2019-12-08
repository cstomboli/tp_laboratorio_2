using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
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
            }
        }

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

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;

            if (p1.TrackingID == p2.TrackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.estado = EEstado.Ingresado;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }
    }
}
