using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelAlumno:IViewModel<Alumno>
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public List<String> Cursos { get; set; }

        public Alumno ToBaseDatos()
        {
            var alumno = new Alumno()
            {
                dni = Dni,
                nombre = Nombre
            };
            return alumno;
        }

        public void FromBaseDatos(Alumno modelo)
        {
            Dni = modelo.dni;
            Nombre = modelo.nombre;
        }

        public void UpdateBaseDatos(Alumno modelo)
        {
            modelo.dni = Dni;
            modelo.nombre = Nombre;
        }

        public object[] GetKeys()
        {
            return new[] {Dni};
        }
    }
}
