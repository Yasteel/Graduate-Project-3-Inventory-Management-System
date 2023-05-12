namespace Inventory_Management_System.Interfaces
{
    public interface IGenericService<T> 
        where T : class
    {
        void Create(T entity);

        List<T> GetAll();

        T Get(int id);

        void Update(T entity);

        void Delete(int id);
    }
}
