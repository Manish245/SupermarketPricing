using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.InputModel
{
    public class Item
    {
        public int ItemCode { get; set; }
        public String ItemName { get; set; }
        public String ItemCategory { get; set; }
        public double ActualCost { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public Guid SchemeId { get; set; }
        public SchemeDetails SchemeDetails { get; set; }

    }
}
