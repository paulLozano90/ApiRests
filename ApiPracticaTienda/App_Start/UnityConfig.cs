using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using RepositorioPracticaTienda.Model;
using RepositorioPracticaTienda.Repositorio;
using RepositorioPracticaTienda.ViewModel;
using Unity.WebApi;

namespace ApiPracticaTienda
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DbContext, Tienda19Entities>();
            container.RegisterType<IRepositorio<Producto,ViewModelProducto>,
                                   RepositorioEntity<Producto,ViewModelProducto>>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            
        }
    }
}