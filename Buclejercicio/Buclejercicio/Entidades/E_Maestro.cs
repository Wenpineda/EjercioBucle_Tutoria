using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buclejercicio.Entidades
{
    class E_Maestro
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string materia;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Materia { get => materia; set => materia = value; }

        public E_Maestro() 
        { }

        public E_Maestro(int id, string nombre, string apellidos, string materia)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.materia = materia;
        }
        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2}, Asignatura: {3},  ", id, Nombre, apellidos, materia);
        }
    }
}
