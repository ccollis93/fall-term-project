﻿using System;
using System.Collections.Generic;

namespace bitsHomePageUWP.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
        }

        public int AppUserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransaction { get; set; }

        public override string ToString()
        {
            return AppUserId + ", " + Name;
        }

    }
}
