using Microsoft.AspNetCore.Mvc;
using ShopRUsWebAPI.Dtos;
using ShopRUsWebAPI.Enums;
using ShopRUsWebAPI.Models;
using ShopRUsWebAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopRUsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/GetUserType")]
        public async Task<List<EnumValue>> GetUserType()
        {
            return await _discountService.GetEnumList<UserType>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/GetItemType")]
        public async Task<List<EnumValue>> GetItemType()
        {
            return await _discountService.GetEnumList<ItemType>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/CreateDiscount")]
        public async Task<decimal> CreateDiscount([FromBody] DiscountRequest request)
        {
            return  await _discountService.DiscountCalculation(request.user, request.bill);
        }

        

    }
}
