using System;
using System.Collections.Generic;

namespace bitsHomePageUWP.Models
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
        }

        public int InventoryTransactionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransaction { get; set; }
    }
}
