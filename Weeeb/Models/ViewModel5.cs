using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class ViewModel5
    {
        public int order_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public DateTime order_date { get; set; }
        public int quantity { get; set; }
        public int paid_status { get; set; }
        public int total { get; set; }
        public int status { get; set; }
    }
}
