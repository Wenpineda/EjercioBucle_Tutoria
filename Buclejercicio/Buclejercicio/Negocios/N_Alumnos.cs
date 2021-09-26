using Buclejercicio.Datos;
using Buclejercicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buclejercicio.Negocios
{
    class N_Alumnos
    {
        D_Alumnos datos = new D_Alumnos();
       
        public List<E_Alumno> N_listaDeAlumnos()
        {
            List<E_Alumno> lista = datos.ListaDeAlumnos();
            return lista;
        
        }
        public void N_agregarAlumno(E_Alumno alumnoNuevo)
        {
            datos.AgegarAlumno(alumnoNuevo);
        }
        public void N_editarAlumno(E_Alumno alumnoEditado)
        {
            datos.EditarAlumnos(alumnoEditado);
        }
        public void N_eliminarAlumno(E_Alumno alumnoEliminado)
        {
            datos.EliminarAlumno(alumnoEliminado);
        }
        List<E_Maestro> ListaMaestros = new List<E_Maestro>();

        public List<E_Maestro> ListaDeMaestros()
        {

            if (ListaMaestros.Count != 0)
            {
                return ListaMaestros;
            }
            else
            {
                ListaMaestros.Add(new E_Maestro(1, "Marta", "Cartagena", "Sociales"));
                ListaMaestros.Add(new E_Maestro(2, "Pedro", "Valle", "Lenguaje"));
                ListaMaestros.Add(new E_Maestro(3, "Oscar", "Villeda", "Ciencias"));
                ListaMaestros.Add(new E_Maestro(4, "Rosario", "Vasquez", "Matematica"));
                ListaMaestros.Add(new E_Maestro(5, "Alejandra", "Portillo", "Ingles"));


                return ListaMaestros;
            }


        
        }
    }
}
