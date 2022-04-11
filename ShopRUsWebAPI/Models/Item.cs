using ShopRUsWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRUsWebAPI.Models
{
    public class Item
    {
        [Required]
        public ItemType itemType { get; set; }
        [Required]
        public decimal price { get; set; }
    }
}
