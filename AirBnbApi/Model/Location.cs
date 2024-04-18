using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbApi.Model
{
    public class Location
    {
        [Flags]
        public enum FeaturesType
        {
            Smoking = 1,
            PetsAllowed = 2,
            Wifi = 4,
            TV = 8,
            Bath = 16,
            Breakfast = 32,
            Kitchen = 64,
            Beachfront = 128,
            Balcony = 256,
            Pool = 512,
            HotTub = 1024,
            PrivateParking = 2048,
            Elevator = 4096,
            Gym = 8192,
            Lakefront = 16384,
            BoatDock = 32768,
            SunDeck = 65536,
            Fireplace = 131072,
            Victorian = 262144,
            SkylineView = 524288,
            RoofDeck = 1048576,
            Backyard = 2097152,
            Garage = 4194304,
            SharedKitchen = 8388608,
            Bar = 16777216
        }
        public enum LocationType
        {
            Appartment,
            Cottage,
            Chalet,
            Room,
            Hotel,
            House,
            Estate,
            Villa,
            Condominium,
            Studio,
            Townhouse,
            Penthouse,
            Hostel,
            Cabin
        }
        public int Id { get; set; }
        public ICollection<Image> Images { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public string Title { get; set; }
        public Landlord Landlord { get; set; }
        [ForeignKey("Landlord.Id")]
        public int LandlordId { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        [Required]
        public string SubTitle { get; set; }
        [Required]
        public float PricePerDay { get; set; }
        [Required]
        public FeaturesType Features { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public LocationType Type { get; set; }
        [Required]
        public int NumberOfGuests { get; set; }
    }
}
