using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Repositorio.ViewModel;

namespace Repositorio.Repositorio
{
    //TModelo tiene que ser una clase y ademas tiene que ser un modelo
    public interface IRepositorio<TModelo,TViewModel> where TModelo:class where TViewModel:IViewModel<TModelo>
    {
        //Automaticamente añade en la base de datos, 
        //los transformo y lo devuelve (el modelo)
        TViewModel Add(TViewModel model);
        //Primero borra y luego devuelve un entero
        int Borrar(TViewModel model);
        int Borrar(Expression<Func<TModelo, bool>> expression);
        //Primero actualiza y luego devuelve un entero
        int Actualizar(TViewModel model);
        //Devuelve todos los datos de la entidad
        ICollection<TViewModel> Get();
        //Aqui obtendremos todas las claves primarias
        TViewModel Get(params Object[] keys);
        //Con la clase expresion generamos una expresion landa. Toda expresion recibe una 
        //funcion dentro, la cual tendra una expresion de entrada...(algo del modelo) y una 
        //salida un boleano. Esto seria igual a  o=>o.Nombre="Luis"
        ICollection<TViewModel> Get(Expression<Func<TModelo, bool>> expression);

    }
}