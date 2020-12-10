using Microsoft.Extensions.Configuration;
using Search.POC.API.Domain.Context;
using Search.POC.API.Domain.Entities;
using Search.POC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search.POC.API.Service
{
    public class SearchService : IService
    {
        private PheonixDbContext _pheonixDbContext;
        private IConfiguration configuration;

        public SearchService(PheonixDbContext pheonixDbContext, IConfiguration configuration)
        {
            _pheonixDbContext = pheonixDbContext;
            this.configuration = configuration;
        }

        public IEnumerable<Somast> Search(SearchRequestDTO search)
        {
            IEnumerable<Somast> result = null;



            return result;
        }
    }
}
