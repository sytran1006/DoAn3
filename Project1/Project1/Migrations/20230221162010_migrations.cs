using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateAcc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    confirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAcc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ListProducts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListProducts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPopular",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPopular", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "ListProducts",
                columns: new[] { "id", "category", "color", "createdAt", "img", "price", "size", "title" },
                values: new object[,]
                {
                    { 1, "shirts", "black,gray", "2020", "https://d3o2e4jr3mxnm3.cloudfront.net/Mens-Jake-Guitar-Vintage-Crusher-Tee_68382_1_lg.png", "600", "L,XL", "Leather-Coat" },
                    { 2, "shirts", "yellow", "2022", "https://www.pngarts.com/files/3/Red-Dress-PNG-Transparent-Image.png", "800", "S,M,L,XL,XXL", "Fur-Coat" },
                    { 3, "shirts", "darkgray,gray", "2017", "https://www.prada.com/content/dam/pradanux_products/U/UCS/UCS319/1YOTF010O/UCS319_1YOT_F010O_S_182_SLF.png", "400", "M,L,XL", "Outerwear" },
                    { 4, "shirts", "red,black", "2015", "https://www.burdastyle.com/pub/media/catalog/product/cache/7bd3727382ce0a860b68816435d76e26/107/BUS-PAT-BURTE-1320516/1170x1470_BS_2016_05_132_front.png", "500", "L,XL", "Sweaters" },
                    { 5, "accessory", "black,blue", "2019", "https://images.ctfassets.net/5gvckmvm9289/3BlDoZxSSjqAvv1jBJP7TH/65f9a95484117730ace42abf64e89572/Noissue-x-Creatsy-Tote-Bag-Mockup-Bundle-_4_-2.png", "100", "S,M", "Mens-Black-Beanie" },
                    { 6, "accessory", "black,darkblue", "2021", "https://d3o2e4jr3mxnm3.cloudfront.net/Rocket-Vintage-Chill-Cap_66374_1_lg.png", "250", "L,XL", "Plaid-Skirt" },
                    { 7, "accessory", "blue", "2012", "https://www.pngarts.com/files/5/Black-Jacket-Transparent-Background-PNG.png", "280", "M,L,XL", "Sequin-Skirt" },
                    { 8, "shirts", "gray, black", "2011", "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png", "550", "L,XL", "Women-Jacket" },
                    { 9, "Trousers", "gray,black", "2011", "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png", "325", "L,XL,XXL", "Women-Jacket" }
                });

            migrationBuilder.InsertData(
                table: "ProductPopular",
                columns: new[] { "id", "color", "createdAt", "img", "size", "title" },
                values: new object[,]
                {
                    { 1, "white", "2020", "../../wwwroot/img/Screenshot (1).png", "M", "Leather-Coat" },
                    { 2, "red", "2022", "https://www.pngarts.com/files/3/Red-Dress-PNG-Transparent-Image.png", "L", "Fur-Coat" },
                    { 3, "white", "2017", "https://www.prada.com/content/dam/pradanux_products/U/UCS/UCS319/1YOTF010O/UCS319_1YOT_F010O_S_182_SLF.png", "M", "Outerwear" },
                    { 4, "black", "2015", "https://www.burdastyle.com/pub/media/catalog/product/cache/7bd3727382ce0a860b68816435d76e26/107/BUS-PAT-BURTE-1320516/1170x1470_BS_2016_05_132_front.png", "L", "Sweaters" },
                    { 5, "yellow", "2019", "https://images.ctfassets.net/5gvckmvm9289/3BlDoZxSSjqAvv1jBJP7TH/65f9a95484117730ace42abf64e89572/Noissue-x-Creatsy-Tote-Bag-Mockup-Bundle-_4_-2.png", "S", "Mens-Black-Beanie" },
                    { 6, "white", "2021", "https://d3o2e4jr3mxnm3.cloudfront.net/Rocket-Vintage-Chill-Cap_66374_1_lg.png", "L", "Plaid-Skirt" },
                    { 7, "blue", "2012", "https://www.pngarts.com/files/5/Black-Jacket-Transparent-Background-PNG.png", "XL", "Sequin-Skirt" },
                    { 8, "gray", "2011", "https://www.pngarts.com/files/3/Women-Jacket-PNG-High-Quality-Image.png", "XL", "Women-Jacket" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAcc");

            migrationBuilder.DropTable(
                name: "ListProducts");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "ProductPopular");
        }
    }
}
