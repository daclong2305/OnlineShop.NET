using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class ViewModel2
    {
        public Products pr { get; set; }
        public IEnumerable<Reviews> rv { get; set; }
    }
}
