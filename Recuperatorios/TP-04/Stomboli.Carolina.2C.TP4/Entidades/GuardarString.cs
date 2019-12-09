using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarString
    {
        #region "Metodo"
        /// <summary>
        /// El metodo guarda el texto que recibe en un archivo de texto 
        /// que tambien recibe en el escritorio de la maquina.
        /// </summary>
        /// <param name="texto">El texto a guardar.</param>
        /// <param name="archivo">El nombre del archivo donde guardar y su extension.</param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\\{1}", path, archivo);
            StreamWriter writer = new StreamWriter(sb.ToString(), File.Exists(path +"\\"+ archivo));
            
            try
            {
                using (writer)
                {
                    writer.WriteLine(texto);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo guardar en la salida de texto.", e);
            }

            return retorno;
        }
        #endregion
    }
}
