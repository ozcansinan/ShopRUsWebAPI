using ShopRUsWebAPI.Models;

namespace ShopRUsWebAPI.Dtos
{
    public class DiscountRequest
    {
        public User user { get; set; }
        public Bill bill { get; set; }
    }
}
