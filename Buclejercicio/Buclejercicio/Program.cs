using Buclejercicio.Datos;
using Buclejercicio.Entidades;
using Buclejercicio.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buclejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            N_Alumnos negocios = new N_Alumnos();
            List<E_Alumno> listado = negocios.N_listaDeAlumnos();
            E_Alumno alumno = new E_Alumno();
            List<E_Maestro> lista = negocios.ListaDeMaestros();

            int opcion = 1;

            while (opcion != 0)
            {

                Console.WriteLine("************ MENÚ ************" +
                    "\n1 - Ver lista de alumnos." +
                    "\n2 - Agregar un nuevo alumno." +
                    "\n3 - Editar un alumno existente." +
                    "\n4 - Eliminar un alumno existente." +
                    "\n5 - Ver lista de maestros." +
                    "\n0 - Salir del sistema.");
                opcion = int.Parse(Console.ReadLine());

                alumno = new E_Alumno();
           
              

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("************ LISTA DE ALUMNOS ************");

                        foreach (E_Alumno item in listado)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n");

                        break;

                    case 2:
                        Console.WriteLine("************ REGISTRANDO NUEVO ALUMNO ************");

                        E_Alumno nuevoId = listado[listado.Count - 1];
                        alumno.Id = (nuevoId.Id + 1);

                        Console.WriteLine("Nombres: ");
                        alumno.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());

                        negocios.N_agregarAlumno(alumno);

                        Console.WriteLine("Procesando..." +
                            "\nAgregando..." +
                            "\nAlumno registrado con éxito!");
                        Console.WriteLine("\n\n\n");

                        break;

                    case 3:
                        Console.WriteLine("************ EDITANDO ALUMNO ************");

                        Console.WriteLine("ID:");
   
                        alumno.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombres: ");
                        alumno.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Promedio: ");
                        alumno.Promedio = double.Parse(Console.ReadLine());

                        negocios.N_editarAlumno(alumno);

                        Console.WriteLine("Procesando..." +
                            "\nEditando..." +
                            "\nAlumno editado con éxito!");
                        break;

                    case 4:
                        Console.WriteLine("************ ELIMINANDO ALUMNO ************");

                        Console.WriteLine("ID: ");
                        alumno.Id = int.Parse(Console.ReadLine());

                        negocios.N_eliminarAlumno(alumno);
                        Console.WriteLine("Procesando..." +
                            "\nEliminando..." +
                            "\nAlumno eliminado con éxito!");
                        break;
                    case 5:
                        Console.WriteLine("************ LISTA DE MAESTROS ************");

                        foreach (E_Maestro item in lista)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n");

                        break;

                    case 0:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
