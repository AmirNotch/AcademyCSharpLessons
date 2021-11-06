using System;
using System.ComponentModel.DataAnnotations;

namespace MVCproj.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Can not be null")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Can not be null")]
        public decimal Cost { get; set; }
        public DateTime TimeOfDelivery { get; set; }
    }
}
