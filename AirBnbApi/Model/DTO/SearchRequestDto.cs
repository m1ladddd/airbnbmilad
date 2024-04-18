using static AirBnbApi.Model.Location;

namespace AirBnbApi.Model.DTO
{
    public class SearchRequestDto
    {
        public FeaturesType? Features { get; set; }
        public LocationType? Type { get; set; }
        public int? Rooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
