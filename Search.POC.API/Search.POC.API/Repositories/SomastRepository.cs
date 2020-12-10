using Search.POC.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search.POC.API.Repositories
{
    public class SomastRepository : IRepositoryBase<Somast>
    {
        void IRepositoryBase<Somast>.Create(Somast entity)
        {
            throw new NotImplementedException();
        }

        void IRepositoryBase<Somast>.Delete(Somast entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Somast> IRepositoryBase<Somast>.Search(Somast searchObj)
        {
            throw new NotImplementedException();
        }

        void IRepositoryBase<Somast>.Update(Somast entity)
        {
            throw new NotImplementedException();
        }
    }
}
