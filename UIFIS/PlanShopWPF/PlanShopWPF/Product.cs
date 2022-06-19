using System;
using System.Collections.Generic;

namespace PlanShopWPF
{
    public partial class Product
    {
        public Product()
        {
            Lists = new HashSet<List>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int IdStatus { get; set; }

        public virtual Status IdStatusNavigation { get; set; } = null!;
        public virtual ICollection<List> Lists { get; set; }
    }
}
