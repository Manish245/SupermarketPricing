using SupermarketPricing.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.Query
{

    public interface IItemsQueryRepository
    {
         Task<Item> GetItemDetails(int ItemId);
        Task<Guid> GetItemOfferId(int ItemId);
    }
    public class ItemsQueryRepository: IItemsQueryRepository
    {

        public async Task<Item> GetItemDetails(int ItemId)
        {

            //Implement to get item details form DB  like cost price .
            await Task.Delay(1000);
            return new Item();
        }

        public async Task<Guid> GetItemOfferId(int ItemId)
        {
            //Implement to get current item offer details.
            await Task.Delay(1000);
            return new Guid();

        }
    }
}
