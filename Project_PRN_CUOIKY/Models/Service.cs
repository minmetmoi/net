using System;
using System.Collections.Generic;

namespace Project_PRN_CUOIKY.Models
{
    public partial class Service
    {
        public Service()
        {
            Orders = new HashSet<Order>();
        }

        public string ServiceName { get; set; } = null!;
        public double? Price { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
