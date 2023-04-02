using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T, TContext> : IGenericDal<T> where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(T t)
        {
                using TContext context = new TContext();
                context.Remove(t);
                context.SaveChanges();
            
        }

        public T GetById(int id)
        {
            using TContext context = new TContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using TContext context = new TContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using TContext context = new TContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using TContext context = new TContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
