﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T, TContext>:IRepository<T> where T:class, new() where TContext: DbContext, new()
    {
        private DataContext context = new DataContext();
        DbSet<T> _object;

        public GenericRepository(DataContext context)
        {
            this.context = context;
            _object = context.Set<T>();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Add(T p)
        {
            _object.Add(p);
        }

        public void Update(T p)
        {
            _object.Update(p);
        }

        public void Delete(T p)
        {
            _object.Remove(p);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
