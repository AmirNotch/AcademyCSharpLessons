using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductStoreMVC.Models.ViewModels
{
    public class StoreViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        /*[MinLength(1, ErrorMessage = "Must be greater than 1")]*/
        public decimal Cost { get; set; }
        public DateTime DeliveryDate { get; set; }
        [Required]
        public int StoreCompanyId { get; set; }
        public string StoreCompanyName { get; set; }

        public List<SelectListItem> Companies { get; set; } = new List<SelectListItem>();

    }
}
