using System.Collections.Generic;
using Newtonsoft.Json;
namespace Vagalume_v2.Models
{
    public class Response
    {
        [JsonIgnore]
        public int numFound { get; set; }
        [JsonIgnore]
        public int start { get; set; }
        [JsonIgnore]
        public ICollection<Docs> docs { get; set; }
    }
}
