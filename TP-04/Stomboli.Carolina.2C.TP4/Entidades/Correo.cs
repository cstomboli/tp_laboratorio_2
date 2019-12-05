using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<T> //ver si va te o q
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquete { get; set; }

        public Correo()
        {

        }

        public void FinEntregas()
        {

        }

        public string MostrarDatos(Mostrar<List<Paquete>>elementos)
        {

        }

        public static Correo operator +(Correo c, Paquete p)
        {
            //return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

    }
}
