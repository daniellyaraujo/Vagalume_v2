using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vagalume_v2.Models
{
    public class Notices
    {
        public ICollection<News> news { get; set; }
    }
}
