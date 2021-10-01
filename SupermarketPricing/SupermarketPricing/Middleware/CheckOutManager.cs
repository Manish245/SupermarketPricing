using SupermarketPricing.InputModel;
using SupermarketPricing.ItemFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.Middleware
{
    public interface IUseCaseManager
    {
        CheckMassege CheckOut(CheckMassege message);
    }
    public class CheckOutManager : IUseCaseManager
    {
        private readonly IItemManager _itemManager;
        public CheckOutManager(IItemManager itemManager)
        {
            _itemManager = itemManager;
        }

        public CheckMassege PayAsync(CheckMassege message)
        {
            List<Item> items = new List<Item>();
            foreach (Item item in GetItemDetails(message.Items))
            {
                items.Add(item);
            }

        }

        private  IEnumerable<Item> GetItemDetails(IEnumerable<Item> items)
        {
            foreach (Item item in items)
            {
                var result =  _itemManager.getItemDetailsAsync(item.ItemCode);
                yield return result.Result;
            }
        }
    }
}
