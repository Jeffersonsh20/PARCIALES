using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Class
{
    class ClsArchivo
    {
        public string[] LeerArch(string archivo)
        {
            string[] linea = File.ReadAllLines(archivo, Encoding.Default);
            return linea;
        }

        public string leertodoArch(string archivo)
        {
            string contenidoArch;
            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                contenidoArch = reader.ReadToEnd();
            }
            return contenidoArch;

        }

 
    }
}
