﻿using static AirBnbApi.Model.Location;

namespace AirBnbApi.Model.DTO.v2
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string LandlordAvatarURL { get; set; }
        public float Price { get; set; }
        public LocationType Type { get; set; }
    }
}
