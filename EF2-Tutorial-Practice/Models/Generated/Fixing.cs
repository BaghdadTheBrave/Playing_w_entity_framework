using System;
using System.Collections.Generic;

namespace Workshop.Models
{
    public partial class Fixing
    {
        public Fixing()
        {
            Products = new HashSet<Product>();
        }

        public int IdFixings { get; set; }
        public string? NameFixings { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
