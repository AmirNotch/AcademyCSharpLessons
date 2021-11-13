using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyCSharpLesson02._11._2021.Models
{
    public class QuotesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        /*[MinLength(1, ErrorMessage = "Must be greater than 1")]*/
        public string Author { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public DateTime InsertDate { get; set; }
        [Required]
        public int QuotesCategoryId { get; set; }

        [ForeignKey("QuotesCategoryId")]
        public virtual QuotesCategory QuotesCategory { get; set; }
   
    }
}
