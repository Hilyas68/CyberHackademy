using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskOne.BlogAppTask.Model;

namespace TaskOne.BlogAppTask.EFRepository
{
    class EFRepository<C, T> : EFRepository<T> where C : BlogDBContext where T: BaseModel
    {
        private BlogDBContext context = new BlogDBContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(int id)
        {

            var result = context.Set<T>().FirstOrDefault(t => t.Id == id);

            context.Set<T>().Remove(result);
            Save();
        }

        public void Edit(T entity)
        {
            context.Set<T>().Attach(entity);
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            Save();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetSingle(int id)
        {
            return context.Set<T>().FirstOrDefault(c=> c.Id == id); 
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
