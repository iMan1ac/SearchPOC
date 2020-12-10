using Search.POC.API.Domain.Entities;
using Search.POC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search.POC.API.Service
{
    public interface IService
    {
        public IEnumerable<Somast> Search(SearchRequestDTO search);
    }
}
