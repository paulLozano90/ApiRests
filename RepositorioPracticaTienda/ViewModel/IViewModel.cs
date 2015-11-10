namespace RepositorioPracticaTienda.ViewModel
{
    //Al final decimos que queremos que TModelo sea igual que clase
    public interface IViewModel<TModelo> where TModelo:class
    {
        TModelo ToBaseDatos();

        void FromBaseDatos(TModelo modelo);

        void UpdateBaseDatos(TModelo modelo);

        object[] GetKeys();
    }
}