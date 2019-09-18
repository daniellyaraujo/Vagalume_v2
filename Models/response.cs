using System.Collections.Generic;
using Newtonsoft.Json;
namespace Vagalume_v2.Models
{
    public class Response
    {
        public ICollection<Docs> docs { get; set; }
    }
}
