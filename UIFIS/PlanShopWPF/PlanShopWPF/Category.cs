using System;
using System.Collections.Generic;

namespace PlanShopWPF
{
    public partial class Category
    {
        public Category()
        {
            Lists = new HashSet<List>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<List> Lists { get; set; }
    }
}
