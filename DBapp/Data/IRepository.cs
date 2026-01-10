using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    /// <summary>
    /// Generic repository interface defining basic CRUD operations.
    /// </summary>
    /// <typeparam name="T">Type of the entity.</typeparam>
    internal interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
