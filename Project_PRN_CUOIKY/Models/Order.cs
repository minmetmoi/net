using System;
using System.Collections.Generic;

namespace Project_PRN_CUOIKY.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string AccName { get; set; } = null!;
        public string ServiceName { get; set; } = null!;
        public int Quantity { get; set; }
        public int ComId { get; set; }

        public virtual Account AccNameNavigation { get; set; } = null!;
        public virtual Computer Com { get; set; } = null!;
        public virtual Service ServiceNameNavigation { get; set; } = null!;
    }
}
