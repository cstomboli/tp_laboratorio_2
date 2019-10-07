using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo
        {
            Entera, Descremada
        }
        private ETipo tipo; // ver cuando llama al segundo constructor q pasa con el tipo.

        #region "Contructores"
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color)
            : base(marca, codigoDeBarras, color)
        {
            this.tipo = ETipo.Entera;
        }

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo)
            : this(marca, codigoDeBarras, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;                             // this.CantidadCalorias=20; se escribe asi si hay set, pero no hay set!!
            }
        }


        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
