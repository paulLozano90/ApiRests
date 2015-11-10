using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace RepositorioPracticaTienda.ViewModel
{
    public class ViewModelCategoria : IViewModel<Categoria>
    {
        public int idCategoria { get; set; }
        public string nombre { get; set; }

        public Categoria ToBaseDatos()
        {
            var categoria = new Categoria()
            {
                idCategoria = idCategoria,
                nombre = nombre
            };
            return categoria;
        }

        public void FromBaseDatos(Categoria modelo)
        {
            idCategoria = modelo.idCategoria;
            nombre = modelo.nombre;
        }

        public void UpdateBaseDatos(Categoria modelo)
        {
            modelo.idCategoria = idCategoria;
            modelo.nombre = nombre;
        }

        public object[] GetKeys()
        {
            return new[] { (object) idCategoria };
        }
    }
}
