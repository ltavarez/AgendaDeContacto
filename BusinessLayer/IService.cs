using System.Data;

namespace BusinessLayer
{
    public interface IService<T>
    {
        void Add(T item);
        void Edit(T item);
        void Delete(int id);
        DataTable GetAll();
    }
}
