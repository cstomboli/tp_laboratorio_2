using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<T> //ver si va te o q
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }


        public string DireccionEntrega { get; set; }
        public EEstado Estado { get; set; }
        public string TrackingID { get; set; }

        public void MockCicloDeVida()
        {

        }

        public string MostrarDatos(Mostrar<Paquete>elementos)
        {

        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;

            if (p1== p2) retorno = true;

            return retorno;
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        public override string ToString()
        {

        }

        public event DelegadoEstado InformarEstado;        

    }
    public delegate void DelegadoEstado();
}
