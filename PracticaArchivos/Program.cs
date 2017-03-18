using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var adminClientes = new AdministracionClientes();
            adminClientes.MostrarMenu();

            Console.WriteLine("Fin");
            Console.Read();



        }
    }
}
