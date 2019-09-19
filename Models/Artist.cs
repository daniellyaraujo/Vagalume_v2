using Newtonsoft.Json;
using System.Collections.Generic;

namespace Vagalume_v2.Models
{
    public class Artist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public ICollection<Related> related { get; set; }
    }
}