using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class ViewModel4
    {
        public int user_id { get; set; }
        public DateTime order_date { get; set; }
        public string note { get; set; }
        public int paid_status { get; set; }
        public int status { get; set; }
        public int[] product_id { get; set; }
        public int[] quantity { get; set; }
    }
}
