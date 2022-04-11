using ShopRUsWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopRUsWebAPI.Services
{
    public interface IDiscountService
    {
        Task<decimal> DiscountCalculation(User user, Bill bill);

        Task<List<EnumValue>> GetEnumList<T>();
    }
}
