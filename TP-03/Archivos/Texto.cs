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
                throw new ArchivosExeption(e);
            }
            return retorno;
        }

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
                throw new ArchivosExeption(e);
            }
            return retorno;
        }


    }
}
