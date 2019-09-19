using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Vagalume_v2.Models
{
    public class Music
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Response response { get; set; }

        [JsonIgnore]
        public string type { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Artist art { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ICollection<MusicDescription> mus { get; set; }
    }

    public class MusicDescription
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int lang { get; set; }
        public string text { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ICollection<Translate> translate { get; set; }
        public Albuns alb { get; set; }
    }
}