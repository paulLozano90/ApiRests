using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace RepositorioPracticaTienda.ViewModel
{
    public class ViewModelProducto : IViewModel<Producto>
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string fabricante { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public int idCategoria { get; set; }
        public string categoria { get; set; }
        public List<ViewModelEtiquetas> Etiquetas { get; set; }

        public Producto ToBaseDatos()
        {
            var producto = new Producto()
            {
                idProducto = idProducto,
                nombre = nombre,
                fabricante = fabricante,
                precioCompra = precioCompra,
                precioVenta = precioVenta,
                idCategoria = idCategoria
            };
            return producto;
        }

        public void FromBaseDatos(Producto modelo)
        {
            idProducto = modelo.idProducto;
            nombre = modelo.nombre;
            fabricante = modelo.fabricante;
            precioCompra = modelo.precioCompra;
            precioVenta = modelo.precioVenta;
            idCategoria = modelo.idCategoria;

            try
            {
                categoria = modelo.Categoria.nombre;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                if(Etiquetas==null)
                    Etiquetas=new List<ViewModelEtiquetas>();

                foreach (var etiqueta in modelo.Etiquetas)
                {
                    var et=new ViewModelEtiquetas();
                    et.FromBaseDatos(etiqueta);
                    Etiquetas.Add(et);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateBaseDatos(Producto modelo)
        {
            modelo.idProducto = idProducto;
            modelo.nombre = nombre;
            modelo.fabricante = fabricante;
            modelo.precioCompra = precioCompra;
            modelo.precioVenta = modelo.precioVenta;
            modelo.idCategoria = modelo.idCategoria;
        }

        public object[] GetKeys()
        {
            return new[] { (object) idProducto };
        }
    }
}
