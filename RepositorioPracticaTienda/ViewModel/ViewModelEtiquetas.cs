using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace RepositorioPracticaTienda.ViewModel
{
    public class ViewModelEtiquetas : IViewModel<Etiquetas>
    {
        public int idEtiquetas { get; set; }
        public string nombre { get; set; }

        public Etiquetas ToBaseDatos()
        {
            var etiquetas = new Etiquetas()
            {
                idEtiquetas = idEtiquetas,
                nombre = nombre
            };
            return etiquetas;
        }

        public void FromBaseDatos(Etiquetas modelo)
        {
            idEtiquetas = modelo.idEtiquetas;
            nombre = modelo.nombre;
        }

        public void UpdateBaseDatos(Etiquetas modelo)
        {
            modelo.idEtiquetas = idEtiquetas;
            modelo.nombre = nombre;
        }

        public object[] GetKeys()
        {
            return new[] { (object)idEtiquetas };
        }
    }
}
