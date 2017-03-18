using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    class GestorClientes
    {

        public void Guardar(Cliente cliente)
        {
            var stringCliente = cliente.Apellido + " " + cliente.Nombre + " " + cliente.Edad + Environment.NewLine;
            File.AppendAllText("archivo.txt", stringCliente);
        }

        public void Eliminar(string apellido, string nombre)
        {
            var clientes = File.ReadAllLines("archivo.txt").ToList();
            for (int i = 0; i < clientes.Count; i++)
            {
                /* Se separa la línea por espacios
                 ejemplo:
                 cliente = Juan Perez 31
                 resultado = cliente.Split(' '); 
                 resultado[0]="Juan"
                 resultado[1]="Perez"
                 resultado[2]="31" */
                var linea = clientes[i].Split(' ');
                if ((linea[0] == apellido) && (linea[1] == nombre))
                {
                    clientes.RemoveAt(i);
                    break;
                }
            }
            File.WriteAllLines("archivo.txt", clientes);
        }

        public int Buscar(string apellido, string nombre)
        {
            var clientes = File.ReadAllLines("archivo.txt").ToList();
            for (int i = 0; i < clientes.Count; i++)
            {
                var linea = clientes[i].Split(' ');
                if ((linea[0] == apellido) && (linea[1] == nombre))
                {                    
                    return i;
                }
            }
            return -1;
        }


        public void Modificar(string nuevoApellido, string nuevoNombre, string nuevaEdad, int indice)
        {
            var clientes = File.ReadAllLines("archivo.txt").ToList();
            clientes[indice] = nuevoApellido + " " + nuevoNombre + " " + nuevaEdad;
            File.WriteAllLines("archivo.txt", clientes);
        }

        public List<string> Listar()
        {
            return File.ReadAllLines("archivo.txt").ToList(); ;
        }
    }
}
