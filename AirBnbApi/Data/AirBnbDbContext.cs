using Microsoft.EntityFrameworkCore;
using AirBnbApi.Model;

namespace AirBnbApi.Data
{
    public class AirBnbDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Image> Image { get; set; } = default!;
        public DbSet<Landlord> Landlord { get; set; } = default!;
        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Reservation> Reservation { get; set; } = default!;
        public AirBnbDbContext(DbContextOptions<AirBnbDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    Id = 1,
                    Url = "https://image1.masterfile.com/getImage/NjE0LTA2MDAyMzg1ZW4uMDAwMDAwMDA=AK8F2M/614-06002385en_Masterfile.jpg"
                },
                new Image
                {
                    Id = 2,
                    Url = "https://i.pinimg.com/originals/a2/04/b1/a204b169f26ed3682ab91c0233e4ac62.jpg"
                },
                new Image
                {
                    Id = 3,
                    Url = "https://static.vecteezy.com/system/resources/previews/029/639/567/large_2x/indian-young-woman-wearing-white-saree-on-dark-background-generative-ai-photo.jpeg",
                    IsCover = true,
                    LocationId = 1
                },
                new Image
                {
                    Id = 4,
                    Url = "https://cloud.funda.nl/valentina_media/170/250/830_1440.jpg",
                    IsCover = true,
                    LocationId = 2
                },
                new Image
                {
                    Id = 5,
                    Url = "https://previews.123rf.com/images/bakharev/bakharev1902/bakharev190200001/117188594-outdoor-portrait-of-a-beautiful-middle-aged-blonde-woman.jpg"
                },
                new Image
                {
                    Id = 6,
                    Url = "https://www.shutterstock.com/image-photo/handsome-middle-age-hispanic-man-260nw-142872514.jpg"
                },
                new Image
                {
                    Id = 7,
                    Url = "https://cloud.funda.nl/valentina_media/170/256/013_1440.jpg",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 8,
                    Url = "https://cloud.funda.nl/valentina_media/170/250/840_1440.jpg",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 9,
                    Url = "https://cloud.funda.nl/valentina_media/170/250/820_1440.jpg",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 10,
                    Url = "https://cloud.funda.nl/valentina_media/170/256/014_1440.jpg",
                    IsCover = false,
                    LocationId = 1
                },
                new Image
                {
                    Id = 11,
                    Url = "https://cloud.funda.nl/valentina_media/188/638/349_720x480.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 12,
                    Url = "https://cloud.funda.nl/valentina_media/188/638/323_720x480.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 13,
                    Url = "https://cloud.funda.nl/valentina_media/188/638/322_720x480.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 14,
                    Url = "https://cloud.funda.nl/valentina_media/188/638/327_720x480.jpg",
                    IsCover = false,
                    LocationId = 2
                },
                new Image
                {
                    Id = 15,
                    Url = "https://cloud.funda.nl/valentina_media/188/418/351_720x480.jpg",
                    IsCover = true,
                    LocationId = 3
                },
                new Image
                {
                    Id = 16,
                    Url = "https://cloud.funda.nl/valentina_media/188/420/630_720x480.jpg",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 17,
                    Url = "https://cloud.funda.nl/valentina_media/188/418/297_720x480.jpg",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 18,
                    Url = "https://i.pinimg.com/originals/e6/70/75/e6707559c50325571f27b7b7854f0812.jpg",
                    IsCover = false,
                    LocationId = 3
                },
                new Image
                {
                    Id = 19,
                    Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20201121_123052.jpg",
                    IsCover = true,
                    LocationId = 4
                },
                new Image
                {
                    Id = 20,
                    Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_212958-375x500.jpg",
                    IsCover = false,
                    LocationId = 4
                },
                new Image
                {
                    Id = 21,
                    Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_213105-375x500.jpg",
                    IsCover = false,
                    LocationId = 4
                },
                new Image
                {
                    Id = 22,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503514152.jpg?k=f2f39e17db5527deebf35c7ac59182bdb37d5d7f4dcae5f7e3e30a30b9e77738&o=&hp=1",
                    IsCover = true,
                    LocationId = 5
                },
                new Image
                {
                    Id = 23,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/541072716.jpg?k=9def01306dacca4197c1e9723e12941340b3b34d74030a1b023a8872ee440382&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 24,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503518524.jpg?k=2d7d660b146a963ca23564387118af4ea725630adff74303310c38c68e42576c&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 25,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/482142109.jpg?k=e8fcbb3297e42bcca578e9abc4f7c23f6b69bdebbf64babc6354c6789e1888ea&o=&hp=1",
                    IsCover = false,
                    LocationId = 5
                },
                new Image
                {
                    Id = 26,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/125236757.jpg?k=8785e9332479f1966217699ed9b7cdb4946a5bc865987630acbcf981677952cd&o=&hp=1",
                    IsCover = true,
                    LocationId = 6
                },
                new Image
                {
                    Id = 27,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/27908101.jpg?k=fcebdc1ad086bdc42ee233d3c7277b881b198b82767c0b7403066120e550a21c&o=&hp=1",
                    IsCover = false,
                    LocationId = 6
                },
                new Image
                {
                    Id = 28,
                    Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139701_43.jpg",
                    IsCover = true,
                    LocationId = 7
                },
                new Image
                {
                    Id = 29,
                    Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139806_43.jpg",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 30,
                    Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139800_43.jpg",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 31,
                    Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139730_43.jpg",
                    IsCover = false,
                    LocationId = 7
                },
                new Image
                {
                    Id = 32,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/7248266.jpg?k=d26d70242a52ab0612c8c763ef6b3c6c27c8568d361c6af4010c9f1a3aca46b7&o=&hp=1",
                    IsCover = true,
                    LocationId = 8
                },
                new Image
                {
                    Id = 33,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13494293.jpg?k=a0f76dd4f95aaf3273ba59a5f8d87a4abd30223b232500fb7806f04893f1281d&o=&hp=1",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 34,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/3585099.jpg?k=84060386d5da4c48dbaa785a2800d599b7ba175000e733a3e0e9520db42cbb53&o=&hp=1",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 35,
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/5668092.jpg?k=db0d502b71f6a1c0a76d2471e03733b212d3b911e4c35ce80f6634a663c98d32&o=&hp=1",
                    IsCover = false,
                    LocationId = 8
                },
                new Image
                {
                    Id = 36,
                    Url = "https://a0.muscache.com/im/pictures/119d3dc9-04f0-4ac3-a049-1b36a52ff806.jpg?im_w=1200",
                    IsCover = true,
                    LocationId = 9
                },
                new Image
                {
                    Id = 37,
                    Url = "https://a0.muscache.com/im/pictures/308a6c14-2355-4ca4-8047-e4914cf543b1.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 38,
                    Url = "https://a0.muscache.com/im/pictures/5ba2b87f-5122-4e73-838b-3936fc72261b.jpg?im_w=1200",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 39,
                    Url = "https://a0.muscache.com/im/pictures/0b3d0abf-afca-4dbe-813c-9eb3ef24ea14.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 9
                },
                new Image
                {
                    Id = 40,
                    Url = "https://a0.muscache.com/im/pictures/32065969/5b08c353_original.jpg?im_w=1200",
                    IsCover = true,
                    LocationId = 10
                },
                new Image
                {
                    Id = 41,
                    Url = "https://a0.muscache.com/im/pictures/32065952/171b3926_original.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 10
                },
                new Image
                {
                    Id = 42,
                    Url = "https://a0.muscache.com/im/pictures/32065942/89169fb5_original.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 10
                },
                new Image
                {
                    Id = 43,
                    Url = "https://a0.muscache.com/im/pictures/32065963/308af047_original.jpg?im_w=720",
                    IsCover = false,
                    LocationId = 10
                },
                new Image
                {
                    Id = 44,
                    Url = "https://images.homes.com/listings/102/3262325963-726923171/6905-poppy-place-nw-albuquerque-nm-primaryphoto.jpg",
                    IsCover = true,
                    LocationId = 11
                },
                new Image
                {
                    Id = 45,
                    Url = "https://images.homes.com/listings/117/0362325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-2.jpg",
                    IsCover = false,
                    LocationId = 11
                },
                new Image
                {
                    Id = 46,
                    Url = "https://images.homes.com/listings/117/0462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-3.jpg",
                    IsCover = false,
                    LocationId = 11
                },
                new Image
                {
                    Id = 47,
                    Url = "https://images.homes.com/listings/117/9462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-5.jpg",
                    IsCover = false,
                    LocationId = 11
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Email = "alice.smith@gmail.com",
                    FirstName = "Alice",
                    LastName = "Smith"
                },
                new Customer
                {
                    Id = 2,
                    Email = "bob.jones@outlook.com",
                    FirstName = "Bob",
                    LastName = "Jones"
                },
                new Customer
                {
                    Id = 3,
                    Email = "carol.white@yahoo.com",
                    FirstName = "Carol",
                    LastName = "White"
                },
                new Customer
                {
                    Id = 4,
                    Email = "dave.brown@icloud.com",
                    FirstName = "Dave",
                    LastName = "Brown"
                },
                new Customer
                {
                    Id = 5,
                    Email = "eve.green@hotmail.com",
                    FirstName = "Eve",
                    LastName = "Green"
                }
            );


            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Title = "Urban Loft",
                    SubTitle = "City View",
                    Description = "Modern loft in the heart of the city with stunning urban views.",
                    LandlordId = 1,
                    Rooms = 1,
                    PricePerDay = 120,
                    Features = AirBnbApi.Model.Location.FeaturesType.Wifi | AirBnbApi.Model.Location.FeaturesType.TV,
                    Type = AirBnbApi.Model.Location.LocationType.Appartment,
                    NumberOfGuests = 2
                },
                new Location
                {
                    Id = 2,
                    Title = "Forest Cabin",
                    SubTitle = "Secluded Retreat",
                    Description = "Cozy cabin surrounded by woods, perfect for a peaceful retreat.",
                    LandlordId = 2,
                    Rooms = 2,
                    PricePerDay = 90,
                    Features = AirBnbApi.Model.Location.FeaturesType.Kitchen | AirBnbApi.Model.Location.FeaturesType.PetsAllowed,
                    Type = AirBnbApi.Model.Location.LocationType.Cabin,
                    NumberOfGuests = 4
                },
                new Location
                {
                    Id = 3,
                    Title = "Beach House",
                    SubTitle = "Ocean Front",
                    Description = "Beautiful house right on the beach, enjoy the ocean breeze and sunsets.",
                    LandlordId = 3,
                    Rooms = 3,
                    PricePerDay = 200,
                    Features = AirBnbApi.Model.Location.FeaturesType.Beachfront | AirBnbApi.Model.Location.FeaturesType.Balcony,
                    Type = AirBnbApi.Model.Location.LocationType.House,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 4,
                    Title = "Mountain Villa",
                    SubTitle = "Hillside Views",
                    Description = "Luxurious villa with panoramic mountain views and modern amenities.",
                    LandlordId = 4,
                    Rooms = 4,
                    PricePerDay = 250,
                    Features = AirBnbApi.Model.Location.FeaturesType.Pool | AirBnbApi.Model.Location.FeaturesType.HotTub,
                    Type = AirBnbApi.Model.Location.LocationType.Villa,
                    NumberOfGuests = 8
                },
                new Location
                {
                    Id = 5,
                    Title = "Country Estate",
                    SubTitle = "Rural Elegance",
                    Description = "Large estate in the countryside with plenty of room for large gatherings.",
                    LandlordId = 5,
                    Rooms = 5,
                    PricePerDay = 300,
                    Features = AirBnbApi.Model.Location.FeaturesType.PrivateParking | AirBnbApi.Model.Location.FeaturesType.Wifi,
                    Type = AirBnbApi.Model.Location.LocationType.Estate,
                    NumberOfGuests = 10
                },
                new Location
                {
                    Id = 6,
                    Title = "Downtown Condo",
                    SubTitle = "Heart of the City",
                    Description = "Condo in downtown area with easy access to shopping and entertainment.",
                    LandlordId = 1,
                    Rooms = 2,
                    PricePerDay = 150,
                    Features = AirBnbApi.Model.Location.FeaturesType.Elevator | AirBnbApi.Model.Location.FeaturesType.Gym,
                    Type = AirBnbApi.Model.Location.LocationType.Condominium,
                    NumberOfGuests = 3
                },
                new Location
                {
                    Id = 7,
                    Title = "Lakeside Cottage",
                    SubTitle = "Serene Lakefront",
                    Description = "Charming cottage by the lake, perfect for a relaxing weekend getaway.",
                    LandlordId = 2,
                    Rooms = 2,
                    PricePerDay = 130,
                    Features = AirBnbApi.Model.Location.FeaturesType.Lakefront | AirBnbApi.Model.Location.FeaturesType.BoatDock,
                    Type = AirBnbApi.Model.Location.LocationType.Cottage,
                    NumberOfGuests = 4
                },
                new Location
                {
                    Id = 8,
                    Title = "Desert Retreat",
                    SubTitle = "Minimalist Getaway",
                    Description = "Stay in our minimalist retreat in the heart of the desert with stunning landscape views.",
                    LandlordId = 3,
                    Rooms = 1,
                    PricePerDay = 110,
                    Features = AirBnbApi.Model.Location.FeaturesType.SunDeck | AirBnbApi.Model.Location.FeaturesType.HotTub,
                    Type = AirBnbApi.Model.Location.LocationType.Studio,
                    NumberOfGuests = 2
                },
                new Location
                {
                    Id = 9,
                    Title = "Historic Townhouse",
                    SubTitle = "Old Town Charm",
                    Description = "Experience the charm of history in our beautifully restored townhouse.",
                    LandlordId = 4,
                    Rooms = 3,
                    PricePerDay = 180,
                    Features = AirBnbApi.Model.Location.FeaturesType.Fireplace | AirBnbApi.Model.Location.FeaturesType.Victorian,
                    Type = AirBnbApi.Model.Location.LocationType.Townhouse,
                    NumberOfGuests = 5
                },
                new Location
                {
                    Id = 10,
                    Title = "Sky High Penthouse",
                    SubTitle = "City Skyline",
                    Description = "Enjoy breathtaking views of the city skyline from our luxurious penthouse.",
                    LandlordId = 5,
                    Rooms = 3,
                    PricePerDay = 350,
                    Features = AirBnbApi.Model.Location.FeaturesType.SkylineView | AirBnbApi.Model.Location.FeaturesType.RoofDeck,
                    Type = AirBnbApi.Model.Location.LocationType.Penthouse,
                    NumberOfGuests = 6
                },
                new Location
                {
                    Id = 11,
                    Title = "Suburban Home",
                    SubTitle = "Family Friendly",
                    Description = "Perfect home for families looking for a quiet, suburban setting.",
                    LandlordId = 1,
                    Rooms = 4,
                    PricePerDay = 220,
                    Features = AirBnbApi.Model.Location.FeaturesType.Backyard | AirBnbApi.Model.Location.FeaturesType.Garage,
                    Type = AirBnbApi.Model.Location.LocationType.House,
                    NumberOfGuests = 8
                },
                new Location
                {
                    Id = 12,
                    Title = "Boutique Hostel",
                    SubTitle = "Trendy & Affordable",
                    Description = "Stay in our trendy boutique hostel, designed for young travelers and backpackers.",
                    LandlordId = 2,
                    Rooms = 10,
                    PricePerDay = 30,
                    Features = AirBnbApi.Model.Location.FeaturesType.SharedKitchen | AirBnbApi.Model.Location.FeaturesType.Bar,
                    Type = AirBnbApi.Model.Location.LocationType.Hostel,
                    NumberOfGuests = 20
                }
            );


            modelBuilder.Entity<Landlord>().HasData(
                new Landlord
                {
                    Id = 1,
                    FirstName = "Elena",
                    LastName = "Walters",
                    Age = 42,
                    AvatarId = 1
                },
                new Landlord
                {
                    Id = 2,
                    FirstName = "Marco",
                    LastName = "Fischer",
                    Age = 38,
                    AvatarId = 2
                },
                new Landlord
                {
                    Id = 3,
                    FirstName = "Nadia",
                    LastName = "Singh",
                    Age = 29,
                    AvatarId = 3
                },
                new Landlord
                {
                    Id = 4,
                    FirstName = "Oliver",
                    LastName = "Martinez",
                    Age = 34,
                    AvatarId = 4
                },
                new Landlord
                {
                    Id = 5,
                    FirstName = "Lucy",
                    LastName = "Kim",
                    Age = 31,
                    AvatarId = 5
                }
            );



            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    LocationId = 1,
                    CustomerId = 1,
                    Discount = 15,
                    StartTime = new DateTime(2024, 5, 1),
                    EndTime = new DateTime(2024, 5, 7)
                },
                new Reservation
                {
                    Id = 2,
                    LocationId = 5,
                    CustomerId = 3,
                    Discount = 10,
                    StartTime = new DateTime(2024, 6, 15),
                    EndTime = new DateTime(2024, 6, 20)
                },
                new Reservation
                {
                    Id = 3,
                    LocationId = 8,
                    CustomerId = 5,
                    Discount = 20,
                    StartTime = new DateTime(2024, 7, 10),
                    EndTime = new DateTime(2024, 7, 15)
                }
            );

        }
    }
}
