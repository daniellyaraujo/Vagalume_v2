using Newtonsoft.Json;

namespace Vagalume_v2.Models
{
    public class Docs
    {
        public string Id { get; set; }
        public string Url { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string title { get; set; }
        public string Band { get; set; }
    }
}
