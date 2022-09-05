
namespace Torentos.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "League Of Legends",
                Description = "What is League of Legends?League of Legends is a team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory.",
                Image = "images/LeagueOfLegends.png",
                Price = 9.99m,
                Type = "images/VideoGame.png"
            },
             new Product
             {
                 Id = 2,
                 Title = "Cars 2",
                 Description = "Cars 2 is an animated movie that explains the life of all cars.",
                 Image = "images/Cars2.png",
                 Price = 5.40m,
                 Type = "images/Movie.png"
             },
             new Product
             {
                 Id = 3,
                 Title = "AC-DC",
                 Description = "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..",
                 Image = "images/ACDC.png",
                 Price = 2.30m,
                 Type = "images/Music.png"
             }
         );
        }
        public DbSet<Product> Products { get; set; }
    }
}
