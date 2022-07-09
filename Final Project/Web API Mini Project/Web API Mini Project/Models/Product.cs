﻿using System.ComponentModel.DataAnnotations;

namespace Web_API_Mini_Project.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
