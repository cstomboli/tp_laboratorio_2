using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Exepciones;

namespace Archivos
{
    public class Xml <T> : IArchivo<T>
    {
        /// <summary>
        /// Genera, guarda un archivo del tipo XML. Serealizando el objeto recibido 
        /// </summary>
        /// <param name="archivo">Archivo donde guarda</param>
        /// <param name="datos">Que guarda.</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            
            try
            {
                XmlTextWriter writer;
                XmlSerializer ser;

                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                writer.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        /// <summary>
        /// Leer archivos con contenido de datos XML.
        /// </summary>
        /// <param name="archivo">De donde lee.</param>
        /// <param name="datos">Datos que lee.</param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            try
            {
                XmlTextReader reader;   
                XmlSerializer ser;      
                
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(T));
                datos= (T)ser.Deserialize(reader);
                reader.Close();

                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;

        }

    }
}
