namespace Inventory_Management_System.Services
{
    using Inventory_Management_System.Data;
    using Inventory_Management_System.Interfaces;
    using System.Collections.Generic;

    public class GenericService<T> : IGenericService<T>
        where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            T? entity = this.context.Set<T>().Find(id);
            this.context.Set<T>().Remove(entity!);
            this.context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return this.context.Set<T>().Find(id)!;
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
            this.context.SaveChanges();
        }
    }
}
