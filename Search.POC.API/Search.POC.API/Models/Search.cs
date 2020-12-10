using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Search.POC.API.Models
{
    [DataContract]
    [Serializable]
    public class Search
    {
        [DataMember]
        [JsonProperty("key")]
        public String Key { get; set; }
        [DataMember]
        [JsonProperty("value")]
        public String Value { get; set; }
        [DataMember]
        [JsonProperty("type")]
        public String ValueType { get; set; }
    }
}
