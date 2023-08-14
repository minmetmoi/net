using System;
using System.Collections.Generic;

namespace Project_PRN_CUOIKY.Models
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
            RechangeHistories = new HashSet<RechangeHistory>();
            Coms = new HashSet<Computer>();
        }

        public string AccName { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public int Role { get; set; }
        public int StatusAcc { get; set; }
        public int Time { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RechangeHistory> RechangeHistories { get; set; }

        public virtual ICollection<Computer> Coms { get; set; }
    }
}
