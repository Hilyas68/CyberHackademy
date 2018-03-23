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

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity is null");

            var result = context.Set<T>().FirstOrDefault(t => t.Id == entity.Id);

            if (result == null)
                return;

            context.Set<T>().Remove(result);
            Save();
        }

        public void Delete(T[] entities)
        {
            Action<T> action = entity =>
            {
                if (entity == null)
                    throw new ArgumentNullException("entity is null");

                var result = context.Set<T>().FirstOrDefault(t => t.Id == entity.Id);

                if (result == null)
                    return;

                context.Set<T>().Remove(result);
            };

            Array.ForEach(entities, action);

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
            throw new NotImplementedException();
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
