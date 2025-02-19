﻿// <auto-generated />
using System;
using AirBnbApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirBnbApi.Migrations
{
    [DbContext(typeof(AirBnbDbContext))]
    [Migration("20240417210703_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AirBnbApi.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice.smith@gmail.com",
                            FirstName = "Alice",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob.jones@outlook.com",
                            FirstName = "Bob",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = 3,
                            Email = "carol.white@yahoo.com",
                            FirstName = "Carol",
                            LastName = "White"
                        },
                        new
                        {
                            Id = 4,
                            Email = "dave.brown@icloud.com",
                            FirstName = "Dave",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 5,
                            Email = "eve.green@hotmail.com",
                            FirstName = "Eve",
                            LastName = "Green"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = false,
                            Url = "https://image1.masterfile.com/getImage/NjE0LTA2MDAyMzg1ZW4uMDAwMDAwMDA=AK8F2M/614-06002385en_Masterfile.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = false,
                            Url = "https://i.pinimg.com/originals/a2/04/b1/a204b169f26ed3682ab91c0233e4ac62.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://static.vecteezy.com/system/resources/previews/029/639/567/large_2x/indian-young-woman-wearing-white-saree-on-dark-background-generative-ai-photo.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://cloud.funda.nl/valentina_media/170/250/830_1440.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            Url = "https://previews.123rf.com/images/bakharev/bakharev1902/bakharev190200001/117188594-outdoor-portrait-of-a-beautiful-middle-aged-blonde-woman.jpg"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = false,
                            Url = "https://www.shutterstock.com/image-photo/handsome-middle-age-hispanic-man-260nw-142872514.jpg"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://cloud.funda.nl/valentina_media/170/256/013_1440.jpg"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://cloud.funda.nl/valentina_media/170/250/840_1440.jpg"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://cloud.funda.nl/valentina_media/170/250/820_1440.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://cloud.funda.nl/valentina_media/170/256/014_1440.jpg"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://cloud.funda.nl/valentina_media/188/638/349_720x480.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://cloud.funda.nl/valentina_media/188/638/323_720x480.jpg"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://cloud.funda.nl/valentina_media/188/638/322_720x480.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://cloud.funda.nl/valentina_media/188/638/327_720x480.jpg"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://cloud.funda.nl/valentina_media/188/418/351_720x480.jpg"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://cloud.funda.nl/valentina_media/188/420/630_720x480.jpg"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://cloud.funda.nl/valentina_media/188/418/297_720x480.jpg"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://i.pinimg.com/originals/e6/70/75/e6707559c50325571f27b7b7854f0812.jpg"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20201121_123052.jpg"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_212958-375x500.jpg"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://images.ajar.casa/wp-content/uploads/2021/04/IMG_20190812_213105-375x500.jpg"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503514152.jpg?k=f2f39e17db5527deebf35c7ac59182bdb37d5d7f4dcae5f7e3e30a30b9e77738&o=&hp=1"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/541072716.jpg?k=9def01306dacca4197c1e9723e12941340b3b34d74030a1b023a8872ee440382&o=&hp=1"
                        },
                        new
                        {
                            Id = 24,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/503518524.jpg?k=2d7d660b146a963ca23564387118af4ea725630adff74303310c38c68e42576c&o=&hp=1"
                        },
                        new
                        {
                            Id = 25,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/482142109.jpg?k=e8fcbb3297e42bcca578e9abc4f7c23f6b69bdebbf64babc6354c6789e1888ea&o=&hp=1"
                        },
                        new
                        {
                            Id = 26,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/125236757.jpg?k=8785e9332479f1966217699ed9b7cdb4946a5bc865987630acbcf981677952cd&o=&hp=1"
                        },
                        new
                        {
                            Id = 27,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/27908101.jpg?k=fcebdc1ad086bdc42ee233d3c7277b881b198b82767c0b7403066120e550a21c&o=&hp=1"
                        },
                        new
                        {
                            Id = 28,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139701_43.jpg"
                        },
                        new
                        {
                            Id = 29,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139806_43.jpg"
                        },
                        new
                        {
                            Id = 30,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139800_43.jpg"
                        },
                        new
                        {
                            Id = 31,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://photos.centerparcs.com/admin/fp2/photos/43/800x600/AAA_139730_43.jpg"
                        },
                        new
                        {
                            Id = 32,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/7248266.jpg?k=d26d70242a52ab0612c8c763ef6b3c6c27c8568d361c6af4010c9f1a3aca46b7&o=&hp=1"
                        },
                        new
                        {
                            Id = 33,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13494293.jpg?k=a0f76dd4f95aaf3273ba59a5f8d87a4abd30223b232500fb7806f04893f1281d&o=&hp=1"
                        },
                        new
                        {
                            Id = 34,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/3585099.jpg?k=84060386d5da4c48dbaa785a2800d599b7ba175000e733a3e0e9520db42cbb53&o=&hp=1"
                        },
                        new
                        {
                            Id = 35,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/5668092.jpg?k=db0d502b71f6a1c0a76d2471e03733b212d3b911e4c35ce80f6634a663c98d32&o=&hp=1"
                        },
                        new
                        {
                            Id = 36,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://a0.muscache.com/im/pictures/119d3dc9-04f0-4ac3-a049-1b36a52ff806.jpg?im_w=1200"
                        },
                        new
                        {
                            Id = 37,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://a0.muscache.com/im/pictures/308a6c14-2355-4ca4-8047-e4914cf543b1.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 38,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://a0.muscache.com/im/pictures/5ba2b87f-5122-4e73-838b-3936fc72261b.jpg?im_w=1200"
                        },
                        new
                        {
                            Id = 39,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://a0.muscache.com/im/pictures/0b3d0abf-afca-4dbe-813c-9eb3ef24ea14.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 40,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://a0.muscache.com/im/pictures/32065969/5b08c353_original.jpg?im_w=1200"
                        },
                        new
                        {
                            Id = 41,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://a0.muscache.com/im/pictures/32065952/171b3926_original.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 42,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://a0.muscache.com/im/pictures/32065942/89169fb5_original.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 43,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://a0.muscache.com/im/pictures/32065963/308af047_original.jpg?im_w=720"
                        },
                        new
                        {
                            Id = 44,
                            IsCover = true,
                            LocationId = 11,
                            Url = "https://images.homes.com/listings/102/3262325963-726923171/6905-poppy-place-nw-albuquerque-nm-primaryphoto.jpg"
                        },
                        new
                        {
                            Id = 45,
                            IsCover = false,
                            LocationId = 11,
                            Url = "https://images.homes.com/listings/117/0362325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-2.jpg"
                        },
                        new
                        {
                            Id = 46,
                            IsCover = false,
                            LocationId = 11,
                            Url = "https://images.homes.com/listings/117/0462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-3.jpg"
                        },
                        new
                        {
                            Id = 47,
                            IsCover = false,
                            LocationId = 11,
                            Url = "https://images.homes.com/listings/117/9462325963-726923171/6905-poppy-place-nw-albuquerque-nm-buildingphoto-5.jpg"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId")
                        .IsUnique();

                    b.ToTable("Landlord");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 42,
                            AvatarId = 1,
                            FirstName = "Elena",
                            LastName = "Walters"
                        },
                        new
                        {
                            Id = 2,
                            Age = 38,
                            AvatarId = 2,
                            FirstName = "Marco",
                            LastName = "Fischer"
                        },
                        new
                        {
                            Id = 3,
                            Age = 29,
                            AvatarId = 3,
                            FirstName = "Nadia",
                            LastName = "Singh"
                        },
                        new
                        {
                            Id = 4,
                            Age = 34,
                            AvatarId = 4,
                            FirstName = "Oliver",
                            LastName = "Martinez"
                        },
                        new
                        {
                            Id = 5,
                            Age = 31,
                            AvatarId = 5,
                            FirstName = "Lucy",
                            LastName = "Kim"
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Modern loft in the heart of the city with stunning urban views.",
                            Features = 12,
                            LandlordId = 1,
                            NumberOfGuests = 2,
                            PricePerDay = 120f,
                            Rooms = 1,
                            SubTitle = "City View",
                            Title = "Urban Loft",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cozy cabin surrounded by woods, perfect for a peaceful retreat.",
                            Features = 66,
                            LandlordId = 2,
                            NumberOfGuests = 4,
                            PricePerDay = 90f,
                            Rooms = 2,
                            SubTitle = "Secluded Retreat",
                            Title = "Forest Cabin",
                            Type = 13
                        },
                        new
                        {
                            Id = 3,
                            Description = "Beautiful house right on the beach, enjoy the ocean breeze and sunsets.",
                            Features = 384,
                            LandlordId = 3,
                            NumberOfGuests = 6,
                            PricePerDay = 200f,
                            Rooms = 3,
                            SubTitle = "Ocean Front",
                            Title = "Beach House",
                            Type = 5
                        },
                        new
                        {
                            Id = 4,
                            Description = "Luxurious villa with panoramic mountain views and modern amenities.",
                            Features = 1536,
                            LandlordId = 4,
                            NumberOfGuests = 8,
                            PricePerDay = 250f,
                            Rooms = 4,
                            SubTitle = "Hillside Views",
                            Title = "Mountain Villa",
                            Type = 7
                        },
                        new
                        {
                            Id = 5,
                            Description = "Large estate in the countryside with plenty of room for large gatherings.",
                            Features = 2052,
                            LandlordId = 5,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            SubTitle = "Rural Elegance",
                            Title = "Country Estate",
                            Type = 6
                        },
                        new
                        {
                            Id = 6,
                            Description = "Condo in downtown area with easy access to shopping and entertainment.",
                            Features = 12288,
                            LandlordId = 1,
                            NumberOfGuests = 3,
                            PricePerDay = 150f,
                            Rooms = 2,
                            SubTitle = "Heart of the City",
                            Title = "Downtown Condo",
                            Type = 8
                        },
                        new
                        {
                            Id = 7,
                            Description = "Charming cottage by the lake, perfect for a relaxing weekend getaway.",
                            Features = 49152,
                            LandlordId = 2,
                            NumberOfGuests = 4,
                            PricePerDay = 130f,
                            Rooms = 2,
                            SubTitle = "Serene Lakefront",
                            Title = "Lakeside Cottage",
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Stay in our minimalist retreat in the heart of the desert with stunning landscape views.",
                            Features = 66560,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 110f,
                            Rooms = 1,
                            SubTitle = "Minimalist Getaway",
                            Title = "Desert Retreat",
                            Type = 9
                        },
                        new
                        {
                            Id = 9,
                            Description = "Experience the charm of history in our beautifully restored townhouse.",
                            Features = 393216,
                            LandlordId = 4,
                            NumberOfGuests = 5,
                            PricePerDay = 180f,
                            Rooms = 3,
                            SubTitle = "Old Town Charm",
                            Title = "Historic Townhouse",
                            Type = 10
                        },
                        new
                        {
                            Id = 10,
                            Description = "Enjoy breathtaking views of the city skyline from our luxurious penthouse.",
                            Features = 1572864,
                            LandlordId = 5,
                            NumberOfGuests = 6,
                            PricePerDay = 350f,
                            Rooms = 3,
                            SubTitle = "City Skyline",
                            Title = "Sky High Penthouse",
                            Type = 11
                        },
                        new
                        {
                            Id = 11,
                            Description = "Perfect home for families looking for a quiet, suburban setting.",
                            Features = 6291456,
                            LandlordId = 1,
                            NumberOfGuests = 8,
                            PricePerDay = 220f,
                            Rooms = 4,
                            SubTitle = "Family Friendly",
                            Title = "Suburban Home",
                            Type = 5
                        },
                        new
                        {
                            Id = 12,
                            Description = "Stay in our trendy boutique hostel, designed for young travelers and backpackers.",
                            Features = 25165824,
                            LandlordId = 2,
                            NumberOfGuests = 20,
                            PricePerDay = 30f,
                            Rooms = 10,
                            SubTitle = "Trendy & Affordable",
                            Title = "Boutique Hostel",
                            Type = 12
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 15f,
                            EndTime = new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartTime = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 3,
                            Discount = 10f,
                            EndTime = new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 5,
                            StartTime = new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 5,
                            Discount = 20f,
                            EndTime = new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 8,
                            StartTime = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.HasOne("AirBnbApi.Model.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.HasOne("AirBnbApi.Model.Image", "Avatar")
                        .WithOne("Landlord")
                        .HasForeignKey("AirBnbApi.Model.Landlord", "AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.HasOne("AirBnbApi.Model.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("AirBnbApi.Model.Reservation", b =>
                {
                    b.HasOne("AirBnbApi.Model.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirBnbApi.Model.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirBnbApi.Model.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AirBnbApi.Model.Image", b =>
                {
                    b.Navigation("Landlord")
                        .IsRequired();
                });

            modelBuilder.Entity("AirBnbApi.Model.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("AirBnbApi.Model.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
