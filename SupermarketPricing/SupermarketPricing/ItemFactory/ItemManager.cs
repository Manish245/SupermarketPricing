using SupermarketPricing.InputModel;
using SupermarketPricing.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.ItemFactory
{

    public interface IItemManager
    {
        Task<Item> getItemDetailsAsync(int itemId);
    }
    public class ItemManager: IItemManager
    {
        private readonly IItemsQueryRepository _itemsQueryRepository;
        private readonly ISchemeQueryRepository _schemeQueryRepository;
        public ItemManager(IItemsQueryRepository itemsQueryRepository, ISchemeQueryRepository schemeQueryRepository)
        {
            _itemsQueryRepository = itemsQueryRepository;
            _schemeQueryRepository = schemeQueryRepository;
        }
       
        public async Task<Item> getItemDetailsAsync(int itemId)
        {
           var item=await   _itemsQueryRepository.GetItemDetails(itemId);
            item.SchemeId = await _itemsQueryRepository.GetItemOfferId(itemId);
            item.SchemeDetails = await _schemeQueryRepository.GetDiscountDetailsAsync(item.SchemeId);
            await Task.Delay(1000);
            return new Item();
        }
    }
}
