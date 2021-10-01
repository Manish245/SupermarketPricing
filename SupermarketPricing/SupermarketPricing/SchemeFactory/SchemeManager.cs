using SupermarketPricing.Enum;
using SupermarketPricing.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.SchemeFactory
{
    public interface ISchemeManager
    {
        Task CalculatePrice(Item item);
    }
    public class SchemeManager: ISchemeManager
    {
        public SchemeManager() { 
        
        }
        public async Task CalculatePrice(Item item)
        {
            switch  (item.SchemeDetails.SchemeType)
            {
                case ItemSchemeEnum.Discount:
                    break;
                case ItemSchemeEnum.Offer:
                    break;
                default:
                    break;
            }
        }
    }
}
