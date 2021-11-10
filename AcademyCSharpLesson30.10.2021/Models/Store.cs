using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreMVC.Models
{
    public class Store
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        /*[MinLength(1, ErrorMessage = "Must be greater than 1")]*/
        public decimal Cost { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int StoreCompanyId { get; set; } 

        [ForeignKey("StoreCompanyId")]
        public virtual StoreCompany StoreCompany { get; set; }
    }
}
