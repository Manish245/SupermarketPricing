using SupermarketPricing.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketPricing.Middleware
{
    public interface IUseCaseManager
    {
        public List<Items> checkOut(List<Items> items);
    }
    public class UseCaseManager: IUseCaseManager
    {
        public List<Items> checkOut(List<Items> items)
        {

        }
    }
}
