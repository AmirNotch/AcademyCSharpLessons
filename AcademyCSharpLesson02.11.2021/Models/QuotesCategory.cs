using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcademyCSharpLesson02._11._2021.Models
{
    public class QuotesCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuotesModel> Quotes { get; set; }
    }
}
