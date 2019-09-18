using Newtonsoft.Json;
using System.Net;

namespace Vagalume_v2.Models
{
    public class Albuns
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string year { get; set; }
    }
}