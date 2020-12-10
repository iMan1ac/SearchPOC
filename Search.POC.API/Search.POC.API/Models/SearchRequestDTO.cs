using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Search.POC.API.Models
{
    [DataContract]
    public class SearchRequestDTO
    {
        const int maxPageSize = 50;
        private int _pageSize = 10;

        [DataMember]
        [JsonProperty("searchParams")]
        public IEnumerable<Search> searchParams { get; set; }

        [DataMember]
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; } = 1;
    
        [DataMember]
        [JsonProperty("pageSize")]
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
