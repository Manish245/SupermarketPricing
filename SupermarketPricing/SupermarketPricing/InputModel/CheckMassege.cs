using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.InputModel
{
    public class CheckMassege
    {
        public List<Item> Items { get; set; }
        public Guid TransactionId { get; set; }
    }
}
