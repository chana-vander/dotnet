using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbset;
        public Repository(DataContext con)
        {
            _dbset = con.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }
        public T? GetById(int id)
        {
            return _dbset.Find(id);
        }
        public T Add(T entity)
        {
            _dbset.Add(entity);
            return entity;
        }
        public T Update(T entity)
        {
            _dbset.Update(entity);
            return entity;
        }
        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }
    }
}
