using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace RepositorioPracticaTienda.ViewModel
{
    public class ViewModelProductoAlmacen : IViewModel<ProductoAlmacen>
    {
        public int idAlmacen { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public string almacen { get; set; }

        public ProductoAlmacen ToBaseDatos()
        {
            var productoAlmacen = new ProductoAlmacen()
            {
                idAlmacen = idAlmacen,
                idProducto = idProducto,
                cantidad = cantidad
            };
            return productoAlmacen;
        }

        public void FromBaseDatos(ProductoAlmacen modelo)
        {
            idAlmacen = modelo.idAlmacen;
            idProducto = modelo.idProducto;
            cantidad = modelo.cantidad;
        }

        public void UpdateBaseDatos(ProductoAlmacen modelo)
        {
            modelo.idAlmacen = idAlmacen;
            modelo.idProducto = idProducto;
            modelo.cantidad = cantidad;
        }

        public object[] GetKeys()
        {
            return new[] { (object) idAlmacen, idProducto };
        }
    }
}
