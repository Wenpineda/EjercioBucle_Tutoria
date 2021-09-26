using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buclejercicio.Entidades;

namespace Buclejercicio.Datos
{
    class D_Alumnos
    {
        List<E_Alumno> ListaEstudiantes = new List<E_Alumno>();

        public List<E_Alumno> ListaDeAlumnos() { 

           if (ListaEstudiantes.Count != 0) 
            {
                return ListaEstudiantes;
            }
           else
            {
                ListaEstudiantes.Add(new E_Alumno(1, "Fernando", "Perez", 17, 8.5));
                ListaEstudiantes.Add(new E_Alumno(2, "Gabriela", "Hernandez", 18, 8.4));
                ListaEstudiantes.Add(new E_Alumno(3, "Jose", "Castillo", 22, 9.5));
                ListaEstudiantes.Add(new E_Alumno(4, "Maria", "Ochoa", 20, 9.0));
                ListaEstudiantes.Add(new E_Alumno(5, "Liseth", "Pineda", 19, 8.5));

                return ListaEstudiantes;
            }
        
        }

        public void AgegarAlumno(E_Alumno alumnonNuevo)
        {
            ListaEstudiantes.Add(alumnonNuevo);
        }

        public void EditarAlumnos(E_Alumno alumnoeditado) 
        {
            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {
                if (ListaEstudiantes[i].Id == alumnoeditado.Id)
                {
                    ListaEstudiantes[i] = alumnoeditado;
                }
            }
        }
        public void EliminarAlumno(E_Alumno alumnoEliminado)
        {
            ListaEstudiantes.RemoveAll(r => r.Id == alumnoEliminado.Id);

        }
    }
}