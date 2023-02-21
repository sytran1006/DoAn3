using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project1.Models;
using System.Drawing;

namespace Project1.DatabaseContext
{
    public class ReactContext : DbContext
    {
        public ReactContext(DbContextOptions<ReactContext> options)
           : base(options)
        {
        }

        public DbSet<CreateAcc> CreateAcc { get; set; }
        public DbSet<Login> Login { get; set; } = null!;
        public DbSet<ProductPopular> ProductPopular { get; set; }
        public DbSet<ListProduct> ListProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 1,
                title = "Leather-Coat",
                img = "../../wwwroot/img/Screenshot (1).png",
                color = "white",
                size = "M",
                createdAt = "2020",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 2,
                title = "Fur-Coat",
                img = "https://www.pngarts.com/files/3/Red-Dress-PNG-Transparent-Image.png",
                color = "red",
                size = "L",
                createdAt = "2022",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 3,
                title = "Outerwear",
                img = "https://www.prada.com/content/dam/pradanux_products/U/UCS/UCS319/1YOTF010O/UCS319_1YOT_F010O_S_182_SLF.png",
                color = "white",
                size = "M",
                createdAt = "2017",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 4,
                title = "Sweaters",
                img = "https://www.burdastyle.com/pub/media/catalog/product/cache/7bd3727382ce0a860b68816435d76e26/107/BUS-PAT-BURTE-1320516/1170x1470_BS_2016_05_132_front.png",
                color = "black",
                size = "L",
                createdAt = "2015",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 5,
                title = "Mens-Black-Beanie",
                img = "https://images.ctfassets.net/5gvckmvm9289/3BlDoZxSSjqAvv1jBJP7TH/65f9a95484117730ace42abf64e89572/Noissue-x-Creatsy-Tote-Bag-Mockup-Bundle-_4_-2.png",
                color = "yellow",
                size = "S",
                createdAt = "2019",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 6,
                title = "Plaid-Skirt",
                img = "https://d3o2e4jr3mxnm3.cloudfront.net/Rocket-Vintage-Chill-Cap_66374_1_lg.png",
                color = "white",
                size = "L",
                createdAt = "2021",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 7,
                title = "Sequin-Skirt",
                img = "https://www.pngarts.com/files/5/Black-Jacket-Transparent-Background-PNG.png",
                color = "blue",
                size = "XL",
                createdAt = "2012",
            });
            modelBuilder.Entity<ProductPopular>().HasData(new ProductPopular
            {
                id = 8,
                title = "Women-Jacket",
                img = "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png",
                color = "gray",
                size = "XL",
                createdAt = "2011",
            });

            // list product
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 1,
                title = "Leather-Coat",
                img = "https://d3o2e4jr3mxnm3.cloudfront.net/Mens-Jake-Guitar-Vintage-Crusher-Tee_68382_1_lg.png",
                color = "black,gray",
                size = "L,XL",
                createdAt = "2020",
                price = "600",
                category = "shirts",

            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 2,
                title = "Fur-Coat",
                img = "https://www.pngarts.com/files/3/Red-Dress-PNG-Transparent-Image.png",
                color= "yellow",
                size= "S,M,L,XL,XXL",
                createdAt = "2022",
                price = "800",
                category = "shirts",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 3,
                title = "Outerwear",
                img = "https://www.prada.com/content/dam/pradanux_products/U/UCS/UCS319/1YOTF010O/UCS319_1YOT_F010O_S_182_SLF.png",
                color= "darkgray,gray",
                size= "M,L,XL",
                createdAt = "2017",
                price = "400",
                category = "shirts",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 4,
                title = "Sweaters",
                img = "https://www.burdastyle.com/pub/media/catalog/product/cache/7bd3727382ce0a860b68816435d76e26/107/BUS-PAT-BURTE-1320516/1170x1470_BS_2016_05_132_front.png",
                color= "red,black",
                size= "L,XL",
                createdAt = "2015",
                price = "500",
                category = "shirts",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 5,
                title = "Mens-Black-Beanie",
                img = "https://images.ctfassets.net/5gvckmvm9289/3BlDoZxSSjqAvv1jBJP7TH/65f9a95484117730ace42abf64e89572/Noissue-x-Creatsy-Tote-Bag-Mockup-Bundle-_4_-2.png",
                color="black,blue",
                size="S,M",
                createdAt = "2019",
                price = "100",
                category = "accessory",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 6,
                title = "Plaid-Skirt",
                img = "https://d3o2e4jr3mxnm3.cloudfront.net/Rocket-Vintage-Chill-Cap_66374_1_lg.png",
                color= "black,darkblue",
                size= "L,XL",
                createdAt = "2021",
                price = "250",
                category = "accessory",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 7,
                title = "Sequin-Skirt",
                img = "https://www.pngarts.com/files/5/Black-Jacket-Transparent-Background-PNG.png",
                color= "blue",
                size= "M,L,XL",
                createdAt = "2012",
                price = "280",
                category = "accessory",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 8,
                title = "Women-Jacket",
                img = "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png",
                color= "gray, black",
                size= "L,XL",
                createdAt = "2011",
                price = "550",
                category = "shirts",
            });
            modelBuilder.Entity<ListProduct>().HasData(new ListProduct
            {
                id = 9,
                title = "Women-Jacket",
                img = "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png",
                color= "gray,black",
                size= "L,XL,XXL",
                createdAt = "2011",
                price = "325",
                category = "Trousers",
            });

        }
    }
}
