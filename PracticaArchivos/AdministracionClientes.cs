using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    class AdministracionClientes
    {


        GestorClientes gestorClientes = new GestorClientes();
        public void MostrarMenu()
        {

            string opcion;
            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("1 - Alta");
                Console.WriteLine("2 - Baja");
                Console.WriteLine("3 - Modificación");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("5 - Salir");            
                Console.Write("Ingrese la opción: ");
              
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Guardar();
                        break;
                    case "2":
                        Eliminar();
                        break;
                    case "3":
                        Modificar();
                        break;
                    case "4":
                        Listar();
                        break;

                }
            } while (opcion != "5");


        }



        public void Guardar()
        {
            var cliente = new Cliente();
            Console.Write("Ingrese el apellido:");
            cliente.Apellido = Console.ReadLine();

            Console.Write("Ingrese el nombre:");
            cliente.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad:");
            cliente.Edad = int.Parse(Console.ReadLine());
            gestorClientes.Guardar(cliente);
        }

        public void Eliminar()
        {
            Console.Write("Ingrese el apellido:");
            var apellido = Console.ReadLine();
            Console.Write("Ingrese el nombre:");
            var nombre = Console.ReadLine();
            gestorClientes.Eliminar(apellido, nombre);

        }
        public void Modificar()
        {
            Console.Write("Ingrese el apellido:");
            var apellido = Console.ReadLine();
            Console.Write("Ingrese el nombre:");
            var nombre = Console.ReadLine();
            var indice = gestorClientes.Buscar(apellido, nombre);
            if (indice > 0)
            {
                Console.WriteLine("Cliente encontrado");


                Console.Write("Ingrese el nuevo apellido:");
                var nuevoApellido = Console.ReadLine();


                Console.Write("Ingrese el nuevo nombre:");
                var nuevoNombre= Console.ReadLine();

                Console.Write("Ingrese la nueva edad:");
                var nuevaEdad=Console.ReadLine();

                gestorClientes.Modificar(nuevoApellido, nuevoNombre, nuevaEdad, indice);
            }
            else
            {
                Console.WriteLine("No se econtró el cliente");
            }
          
        }

        public void Listar()
        {

            var clientes = gestorClientes.Listar();

            Console.WriteLine("===================================");
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");
        }
    }
}
