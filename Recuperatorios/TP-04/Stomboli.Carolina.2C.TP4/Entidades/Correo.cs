using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>> 
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquete 
        { 
            get
            {
                return paquetes;
            }
            set
            {
                paquetes = value;
            }        
        }

        /// <summary>
        /// Constructor de Correo, instancia la Lista de Paquetes
        /// y la lista de hilos de Paquetes.
        /// </summary>
        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        #region "Metodos"
        /// <summary>
        /// El metodo cierra los hilos abiertos.
        /// </summary>
        public void FinEntregas()
        {
            foreach(Thread hilos in mockPaquetes)
            {
                if(hilos.IsAlive && hilos != null)
                {
                    hilos.Abort();
                }
            }
        }

        /// <summary>
        /// El metodo primero chequea que recibe un correo y luego
        /// muestra los datos del paquete.
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>>elementos)
        {            
            string sb = string.Empty;
            if (elementos is Correo)
            {
                Correo correo = (Correo)elementos;
                foreach(Paquete p in correo.paquetes)
                {
                    sb += string.Format("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                }                
            }
            return sb; 
        }

        /// <summary>
        /// El metodo agrega un paquete al correo, y si el TrackingId esta
        /// repetido lanza la excepcion TrackingIdRepetidoException.
        /// </summary>
        /// <param name="c">El correo donde agregar.</param>
        /// <param name="p">El paquete a agregar.</param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {        
            bool retorno = false;
            if (!(c is null) && !(p is null))
            {
                foreach (Paquete paquete in c.paquetes)
                {
                    if (paquete == p)
                    {
                        throw new TrackingIdRepetidoException("EL TRACKING ID " + p.TrackingID + " ya figura en la lista de envios.");
                    }
                }
                if (!retorno)
                {
                    c.Paquete.Add(p);
                    try
                    {
                        Thread hilo = new Thread(p.MockCicloDeVida);
                        hilo.Start();
                        c.mockPaquetes.Add(hilo);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message, e);
                    }
                }
            }
            return c;
        }
        #endregion
    }
}
