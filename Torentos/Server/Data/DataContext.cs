
namespace Torentos.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category {
                   Id = 1,
                   Name = "Games",
                   Url = "games"

               },
               new Category
               {
                   Id = 2,
                   Name = "Movies",
                   Url = "movies"

               },
               new Category
               {
                   Id = 3,
                   Name = "Music",
                   Url = "music"

               }
               );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "League Of Legends",
                Description = "What is League of Legends?League of Legends is a team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory.",
                Image = "images/LeagueOfLegends.png",
                Price = 9.99m,
                Type = "images/VideoGame.png",
                CategoryId = 1
            },
             new Product
             {
                 Id = 2,
                 Title = "Cars 2",
                 Description = "Cars 2 is an animated movie that explains the life of all cars.",
                 Image = "images/Cars2.png",
                 Price = 5.40m,
                 Type = "images/Movie.png",
                 CategoryId = 2
             },
             new Product
             {
                 Id = 3,
                 Title = "AC-DC",
                 Description = "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..",
                 Image = "images/ACDC.png",
                 Price = 2.30m,
                 Type = "images/Music.png",
                 CategoryId = 3
             },
             new Product
             {
                 Id = 4,
                 Title = "World Of Warcraft",
                 Description = "As a massively multiplayer online game, World of Warcraft enables thousands of players from across the globe to come together online – undertaking grand quests and heroic exploits in a land of fantastic adventure",
                 Image = "images/worldofwarcraft.png",
                 Price = 5.50m,
                 Type = "images/VideoGame.png",
                 CategoryId = 1
             },
             new Product
             {
                 Id = 5,
                 Title = "Top Gun: Maverick",
                 Description = "After thirty years, Maverick is still pushing the envelope as a top naval aviator, but must confront ghosts of his past when he leads TOP GUN's elite graduates on a mission that demands the ultimate sacrifice from those chosen to fly it.",
                 Image = "images/TopGunMaverick.png",
                 Price = 2.50m,
                 Type = "images/Movie.png",
                 CategoryId = 2
             },
              new Product
              {
                  Id = 6,
                  Title = "The Rolling Stones - Sticky Fingers",
                  Description = "You know the album, the one with the zipper on it. Sticky Fingers represents the best-selling Rolling Stones album of all time as it celebrated its 50th anniversary in 2021.",
                  Image = "images/RollingStones.png",
                  Price = 3.50m,
                  Type = "images/Music.png",
                  CategoryId = 3
              }
         );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
