using static AirBnbApi.Model.Location;

namespace AirBnbApi.Model.DTO
{
    public class LocationDetailsDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public float PricePerDay { get; set; }
        public LocationType Type { get; set; }
        public FeaturesType Features { get; set; }
        public List<ImageDto> Images { get; set; }
        public DetailLandlordDto Landlord { get; set; }
    }
    public class ImageDto
    {
        public string URL { get; set; }
        public bool IsCover { get; set; }
    }

    public class DetailLandlordDto
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }
}
