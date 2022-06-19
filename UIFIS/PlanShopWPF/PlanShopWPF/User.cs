using System;
using System.Collections.Generic;

namespace PlanShopWPF
{
    public partial class User
    {
        public User()
        {
            Lists = new HashSet<List>();
        }

        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string EMail { get; set; } = null!;

        public virtual ICollection<List> Lists { get; set; }
    }
}
