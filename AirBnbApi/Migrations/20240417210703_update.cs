using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnbApi.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCover = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Landlord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AvatarId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landlord_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerDay = table.Column<float>(type: "real", nullable: false),
                    Features = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Landlord_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "alice.smith@gmail.com", "Alice", "Smith" },
                    { 2, "bob.jones@outlook.com", "Bob", "Jones" },
                    { 3, "carol.white@yahoo.com", "Carol", "White" },
                    { 4, "dave.brown@icloud.com", "Dave", "Brown" },
                    { 5, "eve.green@hotmail.com", "Eve", "Green" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, false, null, "https://image1.masterfile.com/getImage/NjE0LTA2MDAyMzg1ZW4uMDAwMDAwMDA=AK8F2M/614-06002385en_Masterfile.jpg" },
                    { 2, false, null, "https://i.pinimg.com/originals/a2/04/b1/a204b169f26ed3682ab91c0233e4ac62.jpg" },
                    { 5, false, null, "https://previews.123rf.com/images/bakharev/bakharev1902/bakharev190200001/117188594-outdoor-portrait-of-a-beautiful-middle-aged-blonde-woman.jpg" },
                    { 6, false, null, "https://www.shutterstock.com/image-photo/handsome-middle-age-hispanic-man-260nw-142872514.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 1, 42, 1, "Elena", "Walters" });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 2, 38, 2, "Marco", "Fischer" });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 5, 31, 5, "Lucy", "Kim" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Modern loft in the heart of the city with stunning urban views.", 12, 1, 2, 120f, 1, "City View", "Urban Loft", 0 },
                    { 2, "Cozy cabin surrounded by woods, perfect for a peaceful retreat.", 66, 2, 4, 90f, 2, "Secluded Retreat", "Forest Cabin", 13 },
                    { 5, "Large estate in the countryside with plenty of room for large gatherings.", 2052, 5, 10, 300f, 5, "Rural Elegance", "Country Estate", 6 },
                    { 6, "Condo in downtown area with easy access to shopping and entertainment.", 12288, 1, 3, 150f, 2, "Heart of the City", "Downtown Condo", 8 },
                    { 7, "Charming cottage by the lake, perfect for a relaxing weekend getaway.", 49152, 2, 4, 130f, 2, "Serene Lakefront", "Lakeside Cottage", 1 },
                    { 10, "Enjoy breathtaking views of the city skyline from our luxurious penthouse.", 1572864, 5, 6, 350f, 3, "City Skyline", "Sky High Penthouse", 11 },
                    { 11, "Perfect home for families looking for a quiet, suburban setting.", 6291456, 1, 8, 220f, 4, "Family Friendly", "Suburban Home", 5 },
                    { 12, "Stay in our trendy boutique hostel, designed for young travelers and backpackers.", 25165824, 2, 20, 30f, 10, "Trendy & Affordable", "Boutique Hostel", 12 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 3, true, 1, "https://static.vecteezy.com/system/resources/previews/029/639/567/large_2x/indian-young-woman-wearing-white-saree-on-dark-background-generative-ai-photo.jpeg" },
                    { 4, true, 2, "https://cloud.funda.nl/valentina_media/170/250/830_1440.jpg" },
                    { 7, false, 1, "https://cloud.funda.nl/valentina_media/170/256/013_1440.jpg" },
                    { 8, false, 1, "https://cloud.funda.nl/valentina_media/170/250/840_1440.jpg" },
                    { 9, false, 1, "https://cloud.funda.nl/valentina_media/170/250/820_1440.jpg" },
                    { 10, false, 1, "https://cloud.funda.nl/valentina_media/170/256/014_1440.jpg" },
                    { 11, false, 2, "https://cloud.funda.nl/valentina_media/188/638/349_720x480.jpg" },
                    { 12, false, 2, "https://cloud.funda.nl/valentina_media/188/638/323_720x480.jpg" },
                    { 13, false, 2, "https://cloud.funda.nl/valentina_media/188/638/322_720x480.jpg" },
                    { 14, false, 2, "https://cloud.funda.nl/valentina_media/188/638/327_720x480.jpg" },
                    { 22, true, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503514152.jpg?k=f2f39e17db5527deebf35c7ac59182bdb37d5d7f4dcae5f7e3e30a30b9e77738&o=&hp=1" },
                    { 23, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/541072716.jpg?k=9def01306dacca4197c1e9723e12941340b3b34d74030a1b023a8872ee440382&o=&hp=1" },
                    { 24, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503518524.jpg?k=2d7d660b146a963ca23564387118af4ea725630adff74303310c38c68e42576c&o=&hp=1" },
                    { 25, false, 5, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/482142109.jpg?k=e8fcbb3297e42bcca578e9abc4f7c23f6b69bdebbf64babc6354c6789e1888ea&o=&hp=1" },
                    { 26, true, 6, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/125236757.jpg?k=8785e9332479f1966217699ed9b7cdb4946a5bc865987630acbcf981677952cd&o=&hp=1" },
                    { 27, false, 6, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/27908101.jpg?k=fcebdc1ad086bdc42ee233d3c7277b881b198b82767c0b7403066120e550a21c&o=&hp=1" },
                    { 28, true, 7, "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139701_43.jpg" },
                    { 29, false, 7, "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139806_43.jpg" },
                    { 30, false, 7, "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139800_43.jpg" },
                    { 31, false, 7, "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139730_43.jpg" },
                    { 40, true, 10, "https://a0.muscache.com/im/pictures/32065969/5b08c353_original.jpg?im_w=1200" },
                    { 41, false, 10, "https://a0.muscache.com/im/pictures/32065952/171b3926_original.jpg?im_w=720" },
                    { 42, false, 10, "https://a0.muscache.com/im/pictures/32065942/89169fb5_original.jpg?im_w=720" },
                    { 43, false, 10, "https://a0.muscache.com/im/pictures/32065963/308af047_original.jpg?im_w=720" },
                    { 44, true, 11, "https://images.homes.com/listings/102/3262325963-726923171/6905-poppy-place-nw-albuquerque-nm-primaryphoto.jpg" },
                    { 45, false, 11, "https://images.homes.com/listings/117/0362325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-2.jpg" },
                    { 46, false, 11, "https://images.homes.com/listings/117/0462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-3.jpg" },
                    { 47, false, 11, "https://images.homes.com/listings/117/9462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CustomerId", "Discount", "EndTime", "LocationId", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 15f, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 10f, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 3, 29, 3, "Nadia", "Singh" });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 4, 34, 4, "Oliver", "Martinez" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "Beautiful house right on the beach, enjoy the ocean breeze and sunsets.", 384, 3, 6, 200f, 3, "Ocean Front", "Beach House", 5 },
                    { 4, "Luxurious villa with panoramic mountain views and modern amenities.", 1536, 4, 8, 250f, 4, "Hillside Views", "Mountain Villa", 7 },
                    { 8, "Stay in our minimalist retreat in the heart of the desert with stunning landscape views.", 66560, 3, 2, 110f, 1, "Minimalist Getaway", "Desert Retreat", 9 },
                    { 9, "Experience the charm of history in our beautifully restored townhouse.", 393216, 4, 5, 180f, 3, "Old Town Charm", "Historic Townhouse", 10 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 15, true, 3, "https://cloud.funda.nl/valentina_media/188/418/351_720x480.jpg" },
                    { 16, false, 3, "https://cloud.funda.nl/valentina_media/188/420/630_720x480.jpg" },
                    { 17, false, 3, "https://cloud.funda.nl/valentina_media/188/418/297_720x480.jpg" },
                    { 18, false, 3, "https://i.pinimg.com/originals/e6/70/75/e6707559c50325571f27b7b7854f0812.jpg" },
                    { 19, true, 4, "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20201121_123052.jpg" },
                    { 20, false, 4, "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_212958-375x500.jpg" },
                    { 21, false, 4, "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_213105-375x500.jpg" },
                    { 32, true, 8, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/7248266.jpg?k=d26d70242a52ab0612c8c763ef6b3c6c27c8568d361c6af4010c9f1a3aca46b7&o=&hp=1" },
                    { 33, false, 8, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13494293.jpg?k=a0f76dd4f95aaf3273ba59a5f8d87a4abd30223b232500fb7806f04893f1281d&o=&hp=1" },
                    { 34, false, 8, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/3585099.jpg?k=84060386d5da4c48dbaa785a2800d599b7ba175000e733a3e0e9520db42cbb53&o=&hp=1" },
                    { 35, false, 8, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/5668092.jpg?k=db0d502b71f6a1c0a76d2471e03733b212d3b911e4c35ce80f6634a663c98d32&o=&hp=1" },
                    { 36, true, 9, "https://a0.muscache.com/im/pictures/119d3dc9-04f0-4ac3-a049-1b36a52ff806.jpg?im_w=1200" },
                    { 37, false, 9, "https://a0.muscache.com/im/pictures/308a6c14-2355-4ca4-8047-e4914cf543b1.jpg?im_w=720" },
                    { 38, false, 9, "https://a0.muscache.com/im/pictures/5ba2b87f-5122-4e73-838b-3936fc72261b.jpg?im_w=1200" },
                    { 39, false, 9, "https://a0.muscache.com/im/pictures/0b3d0abf-afca-4dbe-813c-9eb3ef24ea14.jpg?im_w=720" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CustomerId", "Discount", "EndTime", "LocationId", "StartTime" },
                values: new object[] { 3, 5, 20f, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord",
                column: "AvatarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_LandlordId",
                table: "Location",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_LocationId",
                table: "Reservation",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Landlord");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
