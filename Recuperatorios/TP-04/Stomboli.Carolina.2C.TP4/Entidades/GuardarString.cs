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
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\\{1}", path, archivo);
            using (StreamWriter writer = new StreamWriter(sb.ToString(), File.Exists(archivo)))
            {
                writer.WriteLine(texto);
                retorno = true;
            }
            return retorno;
        }
    }
}
