using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace ShoesHat.Models
{
    public class hat
    {
        public int Id { get; set; }

        [Display(Name = "צבע")] public string Color { get; set; }
        [Display(Name = "מידה")] public int size { get; set; }
        [Display(Name = "מותג")] public string brand { get; set; }
        [Display(Name = "תמונה")] public byte image { get; set; }
        [Display(Name = "תמונה")] public byte image { get; set; }


    }
}
