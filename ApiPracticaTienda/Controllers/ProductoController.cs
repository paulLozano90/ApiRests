using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Practices.Unity;
using RepositorioPracticaTienda.Model;
using RepositorioPracticaTienda.Repositorio;
using RepositorioPracticaTienda.ViewModel;

namespace ApiPracticaTienda.Controllers
{
    public class ProductoController : ApiController
    {
        [Dependency]
        public IRepositorio<Producto,ViewModelProducto> Repositorio { get; set; }

        public List<ViewModelProducto> Get()
        {
            return Repositorio.Get().ToList();
        }

        [ResponseType(typeof(ViewModelProducto))]
        public IHttpActionResult Get(string id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }
    }
}
