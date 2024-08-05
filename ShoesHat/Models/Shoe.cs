using System.ComponentModel.DataAnnotations;

namespace ShoesHat.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "מידה")] public int size { get; set; }
        [Display(Name = "מותג")] public string brand { get; set; }
        [Display(Name = "תמונה")] public byte image { get; set; }


    }
}
