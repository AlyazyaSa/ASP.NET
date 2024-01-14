using BLL.Interfaces;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Reposatory
{
    public class GenericReposatory<T> : IGenericRepositorys<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericReposatory(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
           => _context.Set<T>().Find(id);

         public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
            => _context.Set<T>().ToList();



    }
}
