using System.Collections.Generic;

namespace Vagalume_v2.Models
{
    public class Music
    {
        public Response response { get; set; }
        public string type { get; set; }
        public Artist art { get; set; }
        public ICollection<MusicDescription> mus { get; set; }
    }

    public class MusicDescription
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int lang { get; set; }
        public string text { get; set; }
        public ICollection<Translate> translate { get; set; }
        public Albuns alb { get; set; }
    }
}