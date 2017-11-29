using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wedPlan.Models
{
    public class Wedding
    {
        public int Id { get; set; }
        public string Wedder1 { get; set; }
        public string Wedder2 { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

    }
}
