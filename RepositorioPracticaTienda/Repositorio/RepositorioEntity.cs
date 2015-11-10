using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RepositorioPracticaTienda.ViewModel;

namespace RepositorioPracticaTienda.Repositorio
{
    public class RepositorioEntity <TModelo, TViewModel> : IRepositorio <TModelo, TViewModel> 
                 where TModelo : class where TViewModel : IViewModel<TModelo>, new ()
    {
        private DbContext context;

        //Se hace protected para que toda la estructura se haga desde aqui
        protected virtual DbSet<TModelo> DbSet
        {
            get { return context.Set<TModelo>(); }
        }

        public RepositorioEntity(DbContext context)
        {
            this.context = context;
        }

        public virtual int Actualizar(TViewModel model)
        {
            var obj = DbSet.Find(model.GetKeys());
            model.UpdateBaseDatos(obj);

            try
            {
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public virtual TViewModel Add(TViewModel model)
        {
            var m = model.ToBaseDatos();
            DbSet.Add(m);

            try
            {
                context.SaveChanges();
                model.FromBaseDatos(m);
                return model;
            }
            catch (Exception e)
            {
                return default(TViewModel);
            }
        }
        public virtual int Borrar(TViewModel model)
        {
            var obj = DbSet.Find(model.GetKeys());
            DbSet.Remove(obj);

            try
            {
                return context.SaveChanges();
            }
            catch (Exception e)
            {

                return 0;
            }
        }
        public virtual int Borrar(Expression<Func<TModelo, bool>> consulta)
        {
            var data = DbSet.Where(consulta);
            DbSet.RemoveRange(data);

            try
            {
                return context.SaveChanges();
            }
            catch (Exception e)
            {

                return 0;
            }
        }
        public virtual ICollection<TViewModel> Get()
        {
            //Quiero obtener todos los datos
            //Pero no sabemos de que tipo va ser
            var data = new List<TViewModel>();

            foreach (var modelo in DbSet)
            {
                TViewModel obj = new TViewModel();
                obj.FromBaseDatos(modelo);
                data.Add(obj);
            }
            return data;
        }
        public virtual ICollection<TViewModel> Get(Expression<Func<TModelo, bool>> consulta)
        {
            var datos0 = DbSet.Where(consulta);
            var data = new List<TViewModel>();

            foreach (var modelo in datos0)
            {
                TViewModel obj = new TViewModel();
                obj.FromBaseDatos(modelo);
                data.Add(obj);
            }
            return data;
        }
        public virtual TViewModel Get(params object[] keys)
        {
            var dato = DbSet.Find(keys);
            var retorno = new TViewModel();
            retorno.FromBaseDatos(dato);

            return retorno;
        }
    }
}
