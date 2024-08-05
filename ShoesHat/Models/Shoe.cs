using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace ShoesHat.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "מידה")] public int size { get; set; }
        [Display(Name = "מותג")] public string brand { get; set; }
        [Display(Name = "צבע")] public string color { get; set; }
        [Display(Name = "תמונה")] public Byte[] Image { get; set; }
        public IFormFile setImage
        {
            get { return null; }
            set
            {
                if (value == null) { return; }
                AddImage(value);

            }
        }
        public void AddImage(IFormFile image)
        {
            if (image == null) return;

            using (var stream = new MemoryStream())
            {
                image.CopyTo(stream);
                Image = stream.ToArray(); // Store the image data as a byte array
            }
        }


    }
}
