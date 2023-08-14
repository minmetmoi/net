using System;
using System.Collections.Generic;

namespace Project_PRN_CUOIKY.Models
{
    public partial class RechangeHistory
    {
        public string? AccName { get; set; }
        public int IdRechange { get; set; }
        public double? Monney { get; set; }

        public virtual Account? AccNameNavigation { get; set; }
    }
}
