using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace RepositorioPracticaTienda.ViewModel
{
    public class ViewModelAlmacen : IViewModel<Almacen>
    {
        public int idAlmacen { get; set; }
        public string ciudad { get; set; }
        public Nullable<int> codPostal { get; set; }

        public Almacen ToBaseDatos()
        {
            var almacen = new Almacen()
            {
                idAlmacen = idAlmacen,
                ciudad = ciudad,
                codPostal = codPostal
            };
            return almacen;
        }

        public void FromBaseDatos(Almacen modelo)
        {
            idAlmacen = modelo.idAlmacen;
            ciudad = modelo.ciudad;
            codPostal = modelo.codPostal;
        }

        public void UpdateBaseDatos(Almacen modelo)
        {
            modelo.idAlmacen = idAlmacen;
            modelo.ciudad = ciudad;
            modelo.codPostal = codPostal;
        }

        public object[] GetKeys()
        {
            return new[] { (object) idAlmacen };
        }
    }
}
