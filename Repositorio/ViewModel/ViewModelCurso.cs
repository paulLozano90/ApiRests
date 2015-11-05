using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelCurso:IViewModel<Curso>
    {
        public int idCurso { get; set; }
        public string nombre { get; set; }
        public double duracion { get; set; }
        public Nullable<System.DateTime> inicio { get; set; }
        public Nullable<System.DateTime> fin { get; set; }
        public Nullable<int> aula { get; set; }

        public Curso ToBaseDatos()
        {
            return new Curso()
            {
                idCurso = idCurso,
                aula = aula,
                nombre = nombre,
                duracion = duracion,
                inicio = inicio,
                fin = fin
            };
        }

        public void FromBaseDatos(Curso modelo)
        {
            idCurso = modelo.idCurso;
            aula = modelo.aula;
            nombre = modelo.nombre;
            duracion = modelo.duracion;
            inicio = modelo.inicio;
            fin = modelo.fin;
        }

        public void UpdateBaseDatos(Curso modelo)
        {
            modelo.idCurso = idCurso;
            modelo.aula = aula;
            modelo.nombre = nombre;
            modelo.duracion = duracion;
            modelo.inicio = inicio;
            modelo.fin = fin;
        }

        public object[] GetKeys()
        {
            return new [] {(object) idCurso};
        }
    }
}
