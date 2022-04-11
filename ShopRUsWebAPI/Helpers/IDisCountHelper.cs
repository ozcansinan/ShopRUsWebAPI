using ShopRUsWebAPI.Enums;
using ShopRUsWebAPI.Models;
using System.Collections.Generic;

namespace ShopRUsWebAPI.Helpers
{
    public interface IDisCountHelper
    {
        decimal CalculateTotal(List<Item> items);
        decimal CalculateTotalPerType(List<Item> items, ItemType type);
        decimal GetUserDiscount(User user);
        decimal CalculateBillsDiscount(decimal totalAmount);
        decimal CalculateDiscount(decimal amount, decimal discount);
        List<EnumValue> GetEnumList<T>();


    }
}
