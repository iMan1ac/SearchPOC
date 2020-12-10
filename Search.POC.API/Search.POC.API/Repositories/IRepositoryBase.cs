using Search.POC.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search.POC.API.Repositories
{
    interface IRepositoryBase<T>
    {
        IEnumerable<Somast> Search(Somast searchObj);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
