using System;

namespace Vagalume_v2.Models
{
    public class News
    {
        public int id { get; set; }
        public string headline { get; set; }
        public string kicker { get; set; }
        public string url { get; set; }
        public DateTime inserted { get; set; }
        public DateTime modified { get; set; }
    }
}