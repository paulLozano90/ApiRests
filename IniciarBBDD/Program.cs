using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.Model;

namespace IniciarBBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            InicializarBBDD();
        }

        private static void InicializarBBDD()
        {
            using (var ctx = new Tienda19Entities())
            {
                if (ctx.Producto.Any()) return;

                List<Categoria> listaCategoria = new List<Categoria>()
                {
                    new Categoria(){nombre="A"},
                    new Categoria(){nombre="B"},
                    new Categoria(){nombre="C"},
                    new Categoria(){nombre="D"},
                    new Categoria(){nombre="E"},
                    new Categoria(){nombre="F"},
                    new Categoria(){nombre="G"},
                    new Categoria(){nombre="H"},
                    new Categoria(){nombre="I"}
                };

                List<Producto> listaProducto = new List<Producto>()
                {
                    new Producto() {nombre = "Iphone",fabricante="Apple",precioCompra=215,precioVenta=600.2,idCategoria=1},
                    new Producto() {nombre = "Note 3",fabricante="Samsung",precioCompra=190,precioVenta=580.50,idCategoria=1},
                    new Producto() {nombre = "Galaxy S",fabricante="Samsung",precioCompra=150,precioVenta=260.2,idCategoria=2},
                    new Producto() {nombre = "MacBook",fabricante="Apple",precioCompra=245.1,precioVenta=854,idCategoria=3},
                    new Producto() {nombre = "MacPro",fabricante="Apple",precioCompra=450.60,precioVenta=1520.50,idCategoria=4},
                    new Producto() {nombre = "Tab",fabricante="Samsung",precioCompra=254,precioVenta=560.2,idCategoria=5},
                    new Producto() {nombre = "MiBand",fabricante="Xiaomi",precioCompra=5.5,precioVenta=20.2,idCategoria=6}
                };

                List<Etiquetas> listaEtiquetas = new List<Etiquetas>()
                {
                    new Etiquetas() {nombre="Etiquetas 1" },
                    new Etiquetas() {nombre="Etiquetas 2" },
                    new Etiquetas() {nombre="Etiquetas 3" }
                };

                List<Almacen> listaAlmacen = new List<Almacen>()
                {
                    new Almacen() {ciudad="Madrid",codPostal=28033 },
                    new Almacen() {ciudad="Barcelona",codPostal=24500 },
                    new Almacen() {ciudad="Sevilla",codPostal=23450 },
                    new Almacen() {ciudad="Londres",codPostal=27540 },
                    new Almacen() {ciudad="Argentina",codPostal=21054 },
                    new Almacen() {ciudad="Portugal",codPostal=29450 }
                };

                List<ProductoAlmacen> listaProductoAlmacen = new List<ProductoAlmacen>()
                {
                    new ProductoAlmacen() {idProducto=1,idAlmacen=2,cantidad=542},
                    new ProductoAlmacen() {idProducto=1,idAlmacen=3,cantidad=451},
                    new ProductoAlmacen() {idProducto=2,idAlmacen=1,cantidad=542},
                    new ProductoAlmacen() {idProducto=2,idAlmacen=2,cantidad=3564},
                    new ProductoAlmacen() {idProducto=3,idAlmacen=1,cantidad=645},
                    new ProductoAlmacen() {idProducto=3,idAlmacen=2,cantidad=3204},
                    new ProductoAlmacen() {idProducto=3,idAlmacen=4,cantidad=54},
                    new ProductoAlmacen() {idProducto=4,idAlmacen=2,cantidad=123},
                    new ProductoAlmacen() {idProducto=5,idAlmacen=2,cantidad=6858},
                    new ProductoAlmacen() {idProducto=5,idAlmacen=5,cantidad=4525},
                    new ProductoAlmacen() {idProducto=6,idAlmacen=1,cantidad=5468582},
                    new ProductoAlmacen() {idProducto=7,idAlmacen=5,cantidad=5363442},
                    new ProductoAlmacen() {idProducto=7,idAlmacen=6,cantidad=543662},
                };

                ctx.Categoria.AddRange(listaCategoria);
                ctx.Producto.AddRange(listaProducto);
                ctx.Etiquetas.AddRange(listaEtiquetas);
                ctx.Almacen.AddRange(listaAlmacen);
                ctx.ProductoAlmacen.AddRange(listaProductoAlmacen);

                ctx.SaveChanges();
            }
        }
    }
}
