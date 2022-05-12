namespace CapaDatos
{
    public interface IGenericService<T>
    {
        List<T> Listar();

        T GetById(int id);

        List<T> Insert(T item);

        List<T> Delete(int id);
    }
}