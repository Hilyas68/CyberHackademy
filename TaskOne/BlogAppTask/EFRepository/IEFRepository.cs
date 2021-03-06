﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.BlogAppTask.EFRepository
{
    interface EFRepository<T>
    {
        T GetSingle(int id);
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(int id);
        void Edit(T entity);
        void Save();
    }
}
