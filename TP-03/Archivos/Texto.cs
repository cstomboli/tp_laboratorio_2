using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region Metodos

        /// <summary>
        /// Escribe una cadena en el archivo.
        /// </summary>
        /// <param name="archivo">Archivo donde escribe.</param>
        /// <param name="datos">A escribir en el archivo.</param>
        /// <returns>True si pudo escribir, false si no.</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno =false;
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, File.Exists(archivo)))
                {
                    writer.Write(datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        /// <summary>
        /// Lee una cadena del archivo.
        /// </summary>
        /// <param name="archivo">Archivo donde Lee.</param>
        /// <param name="datos">Lo que lee.</param>
        /// <returns>True si pudo leer, false si no.</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamReader read= new StreamReader(archivo, File.Exists(archivo)))
                {
                    datos=read.ReadToEnd();
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        #endregion


    }
}
