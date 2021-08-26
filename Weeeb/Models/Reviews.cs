using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Reviews
    {
        public int review_id { get; set; }
        public int product_id { get; set; }
        public int user_id { get; set; }
        public string comment { get; set; }
        public string name { get; set; }
    }
}
