using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class ArchivosExeption : Exception
    {
        public ArchivosExeption(Exception InnerException) :base("Error en el archivo.", InnerException)
        {

        }
    }
}
