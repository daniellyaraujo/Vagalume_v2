using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Vagalume_v2.Models
{
    public class ArtistResponse
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
        public ICollection<Docs> Result { get; set; }
    }
}
