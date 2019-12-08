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
            Correo correoLocal = (Correo)elementos;
            string datosCompletos = "";
            foreach (Paquete p in correoLocal.Paquete)
            {
                datosCompletos += string.Format("{0} para {1} ({2}) \n\r", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }
            return datosCompletos;

            /*
            string sb = string.Empty;

            if (elementos is Paquete)
            {
                Paquete p = (Paquete)elementos;
                sb = string.Format("{0} para {1}", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }
            return sb; */
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            
            foreach(Paquete enLista in c.paquetes)
            {
                bool retorno = false;
                if (!(c is null) && !(p is null))
                {
                    foreach (Paquete paq in c.paquetes)
                    {
                        if (paq == p)
                        {
                            throw new TrackingIdRepetidoException("id repetido");
                        }

                    }
                    if (!retorno)
                    {
                        c.Paquete.Add(p);
                        try
                        {
                            Thread t = new Thread(p.MockCicloDeVida);
                            t.Start();
                            c.mockPaquetes.Add(t);
                        }
                        catch (Exception exception)
                        {
                            throw new Exception(exception.Message, exception);
                        }

                    }
                }

                    /*
                    bool retorno = false;
                    if(enLista== p)
                    {
                        throw new TrackingIdRepetidoException("Id repetido");
                                                             ///mmmm Break??
                    }
                    if (!(retorno))
                    {
                        c.paquetes.Add(p);
                        Thread t = new Thread(p.MockCicloDeVida);
                        t.Start();
                        c.mockPaquetes.Add(t);
                        //break;     
                    }
                }
                return c;*/
               
            }

            return c;//dejar mas lindo
        }

    }
}
