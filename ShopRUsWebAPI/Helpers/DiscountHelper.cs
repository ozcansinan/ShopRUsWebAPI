using ShopRUsWebAPI.Enums;
using ShopRUsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ShopRUsWebAPI.Constant;
using ShopRUsWebAPI.Extensions;

namespace ShopRUsWebAPI.Helpers
{
    public class DiscountHelper:IDisCountHelper
    {
        public decimal CalculateTotal(List<Item> items)
        {
            return items.Sum(item => item.price);
        }

        public decimal CalculateTotalPerType(List<Item> items, ItemType type)
        {
            return items.Where(item => item.itemType == type).Sum(item_ => item_.price);

        }

        public decimal GetUserDiscount(User user)
        {
            decimal discount = 0.00M;

            switch (user.userType)
            {
                case UserType.EMPLOYEE:
                    discount = Convert.ToDecimal(DefinitionConst.EMPLOYEE_DISCOUNT_PERCENTAGE);
                    break;

                case UserType.AFFILIATE:
                    discount = Convert.ToDecimal(DefinitionConst.AFFILIATE_DISCOUNT_PERCENTAGE);
                    break;

                case UserType.CUSTOMER:
                    if (IsCustomerSince(user.registerDate, DefinitionConst.YEARS_FOR_DISCOUNT))
                    {
                        discount = Convert.ToDecimal(DefinitionConst.CUSTOMER_DISCOUNT_PERCENTAGE);
                    }
                    break;

                default:
                    break;
            }

            return discount;
        }

        public decimal CalculateBillsDiscount(decimal totalAmount)
        {
            return DefinitionConst.DISCOUNT_RATE * Convert.ToInt32(totalAmount / DefinitionConst.PER_DISCOUNT_AMOUNT);
        }

        public decimal CalculateDiscount(decimal amount, decimal discount)
        {
            if (amount > 0)
                return amount - (amount * discount);

            return amount;
        }

        public List<EnumValue> GetEnumList<T>()
        {
            return EnumExtensions.GetValues<T>();
        }

        #region private func
        private bool IsCustomerSince(DateTime registeredDate, int years)
        {
            return GetDifferenceInYears(registeredDate, DateTime.Now) >= years;
        }
        private int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            int years = endDate.Year - startDate.Year;

            if (startDate.Month == endDate.Month &&
                endDate.Day < startDate.Day
                || endDate.Month < startDate.Month)
            {
                years--;
            }

            return years;
        }
        #endregion
    }
}
