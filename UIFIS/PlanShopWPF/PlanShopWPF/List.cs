using System;
using System.Collections.Generic;

namespace PlanShopWPF
{
    public partial class List
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Data { get; set; }
        public int? IdProduct { get; set; }
        public int IdCategory { get; set; }
        public int? IdUser { get; set; }

        public virtual Category IdCategoryNavigation { get; set; } = null!;
        public virtual Product? IdProductNavigation { get; set; }
        public virtual User? IdUserNavigation { get; set; }
    }
}
