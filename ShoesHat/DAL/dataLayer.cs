using Microsoft.EntityFrameworkCore;
using ShoesHat.Models;

namespace ShoesHat.DAL
{
    //דאטא לייאר יורשת מדיבי את כל הערכים
    public class dataLayer : DbContext //הנקודתיים מייצג את הירושה מעביר בירושה לדאטאלייאר
    {
        //כדי להכניס ערכים לקונסטרקטור של מחלקצת הבסיס משתמשים בבייס

        public dataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        { 
            Database.EnsureCreated();
            Seed();
        }
        private void Seed()
        {
            if(Hats.Any()) return;
            Hat hat = new Hat { Color = "אדום", size = 9, brand = "נייקי", image = ""};
            Hats.Add(hat);
            SaveChanges();



            if (Shoes.Any()) return;
            Shoe shoe = new Shoe { size = 9 , brand = "נייקי", Color = "אדום",image = "" };
            Shoes.Add(shoe);
            SaveChanges();


        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
        public DbSet<Hat> Hats { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
    }
}
