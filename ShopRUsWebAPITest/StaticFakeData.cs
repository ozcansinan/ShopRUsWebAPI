using Newtonsoft.Json;
using ShopRUsWebAPI.Dtos;
using ShopRUsWebAPI.Enums;
using System;
using System.Net.Http;
using System.Text;

namespace ShopRUsWebAPITest
{
    public static class StaticFakeData
    {

        public static StringContent SuccessCreateDiscountData()
        {
            return new StringContent(JsonConvert.SerializeObject(LoadSuccessData()).ToString(), Encoding.UTF8, "application/json");
        }

        public static StringContent ErrorCreateDiscountData()
        {
            return new StringContent(JsonConvert.SerializeObject(LoadErrorData()).ToString(), Encoding.UTF8, "application/json");
        }


        public static DiscountRequest LoadSuccessData()
        {
            return new DiscountRequest
            {
                user = new ShopRUsWebAPI.Models.User
                {
                    registerDate = DateTime.Now,
                    userType = UserType.CUSTOMER
                },
                bill = new ShopRUsWebAPI.Models.Bill
                {
                    items = new System.Collections.Generic.List<ShopRUsWebAPI.Models.Item>()
                    { new ShopRUsWebAPI.Models.Item() { itemType = ItemType.TECHNOLOGY,price = 100} }

                }
            };
        }
        public static DiscountRequest LoadErrorData()
        {
            return new DiscountRequest
            {
                user = new ShopRUsWebAPI.Models.User
                {
                    registerDate = DateTime.Now.AddYears(5),
                    userType = UserType.CUSTOMER
                },
                bill = new ShopRUsWebAPI.Models.Bill
                {
                    items = new System.Collections.Generic.List<ShopRUsWebAPI.Models.Item>()
                    { new ShopRUsWebAPI.Models.Item() { itemType = ItemType.TECHNOLOGY,price = 100} }

                }
            };
        }
    }
}
