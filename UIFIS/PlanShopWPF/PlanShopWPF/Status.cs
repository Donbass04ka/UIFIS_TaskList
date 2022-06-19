using System;
using System.Collections.Generic;

namespace PlanShopWPF
{
    public partial class Status
    {
        public Status()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
