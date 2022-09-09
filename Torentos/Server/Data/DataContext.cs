
namespace Torentos.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(x => new { x.ProductId,x.ProductTypeId});
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1,Name="Blu-ray" },
                new ProductType { Id = 2, Name="VHS" },
                new ProductType { Id = 3,Name= "MP3" },
                new ProductType { Id = 4, Name = "M4A" },
                new ProductType { Id = 5, Name ="Playstation"},
                new ProductType { Id = 6, Name = "PC"}
                );
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
                CategoryId = 1,
                Featured = true
            },
             new Product
             {
                 Id = 2,
                 Title = "Cars 2",
                 Description = "Cars 2 is an animated movie that explains the life of all cars.",
                 Image = "images/Cars2.png",
                 CategoryId = 2
             },
             new Product
             {
                 Id = 3,
                 Title = "AC-DC",
                 Description = "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..",
                 Image = "images/ACDC.png",
                 CategoryId = 3
             },
             new Product
             {
                 Id = 4,
                 Title = "World Of Warcraft",
                 Description = "As a massively multiplayer online game, World of Warcraft enables thousands of players from across the globe to come together online – undertaking grand quests and heroic exploits in a land of fantastic adventure",
                 Image = "images/worldofwarcraft.png",
                 CategoryId = 1,
                 Featured = true
             },
             new Product
             {
                 Id = 5,
                 Title = "Top Gun: Maverick",
                 Description = "After thirty years, Maverick is still pushing the envelope as a top naval aviator, but must confront ghosts of his past when he leads TOP GUN's elite graduates on a mission that demands the ultimate sacrifice from those chosen to fly it.",
                 Image = "images/TopGunMaverick.png",
                 CategoryId = 2,
                 Featured = true
             },
              new Product
              {
                  Id = 6,
                  Title = "The Rolling Stones - Sticky Fingers",
                  Description = "You know the album, the one with the zipper on it. Sticky Fingers represents the best-selling Rolling Stones album of all time as it celebrated its 50th anniversary in 2021.",
                  Image = "images/RollingStones.png",
                  CategoryId = 3
              }
         );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 6,
                    Price = 15m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 40m,
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 6,
                    Price = 0.370m,
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 60m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 2m,
                },
                 new ProductVariant
                 {
                     ProductId = 6,
                     ProductTypeId = 4,
                     Price = 0.248m,
                 },
                  new ProductVariant
                  {
                      ProductId = 1,
                      ProductTypeId = 5,
                      Price = 25m,
                  }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
