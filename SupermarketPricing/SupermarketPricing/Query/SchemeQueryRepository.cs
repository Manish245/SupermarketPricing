using SupermarketPricing.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.Query
{
    public  interface ISchemeQueryRepository {
        Task<SchemeDetails> GetDiscountDetailsAsync(Guid discountId);
    }
    public class SchemeQueryRepository: ISchemeQueryRepository
    {
     

        public async Task<SchemeDetails> GetDiscountDetailsAsync(Guid discountId)
        {
            //Implement to update checkout status.
            await Task.Delay(1000);
            return new SchemeDetails();

        }
    }
}
