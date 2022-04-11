using ShopRUsWebAPI.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopRUsWebAPI.Models
{
    public class User
    {
        [Required]
        public UserType userType { get; set; }
        [Required]
        public DateTime registerDate { get; set; }
    }
}
