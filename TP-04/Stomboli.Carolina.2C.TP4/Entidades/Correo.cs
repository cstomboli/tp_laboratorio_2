using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>> //ver si va te o q
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

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

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

        public string MostrarDatos(IMostrar<List<Paquete>>elementos)
        {
            string sb = string.Empty;

            if (elementos is Paquete)
            {
                Paquete p = (Paquete)elementos;
                sb = string.Format("{0} para {1}", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }
            return sb;
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach(Paquete enLista in c.paquetes)
            {
                if( !(enLista== p))
                {
                    c.paquetes.Add(p);
                    Thread t = new Thread(p.MockCicloDeVida);
                    t.Start();
                    c.mockPaquetes.Add(t);
                    break;                                          ///mmmm Break??
                }
                else
                {
                    throw new TrackingIdRepetidoException("Id repetido");
                }
            }
            return c;
        }

    }
}
