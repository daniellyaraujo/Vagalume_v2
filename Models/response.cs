using System.Collections.Generic;

namespace Vagalume_v2.Models
{
    public class Response
    {
        public int numFound { get; set; }
        public int start { get; set; }
        public ICollection<Docs> docs { get; set; }
    }
}
