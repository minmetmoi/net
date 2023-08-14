using System;
using System.Collections.Generic;

namespace Project_PRN_CUOIKY.Models
{
    public partial class Computer
    {
        public Computer()
        {
            Orders = new HashSet<Order>();
            AccNames = new HashSet<Account>();
        }

        public int ComId { get; set; }
        public int StatusCom { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Account> AccNames { get; set; }
    }
}
