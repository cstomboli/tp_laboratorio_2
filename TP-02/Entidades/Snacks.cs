using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        #region "Contructor"

        /// <summary>
        /// Instancio los atributos que recibe por parametro.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDeBarras"></param>
        /// <param name="colorPrimarioEmpaque"></param>
        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color)
            : base(marca, codigoDeBarras, color)
        {

        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// sobrecarga del Metodo Mostrar
        /// </summary>
        /// <returns>Un snack y sus calorias.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
