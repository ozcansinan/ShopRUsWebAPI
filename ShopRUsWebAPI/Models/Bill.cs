using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopRUsWebAPI.Models
{
    public class Bill
    {
        [Required]
        public List<Item> items { get; set; }
    }
}
