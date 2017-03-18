using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    class RepositorioClientes
    {
        public void Guardar(string cliente)
        {

            File.AppendAllText("archivo.txt", cliente);
        }

        public void Eliminar(string cliente)
        {

        }
        public void Modificar()
        {

        }

        public List<string> Listar()
        {
            return null;
        }
    }
}
