using AutoMapper;
using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using AirBnbApi.Model.DTO.v2;

namespace AirBnbApi
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Location, Model.DTO.LocationDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.SubTitle, opt => opt.MapFrom(src => src.SubTitle))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.FirstOrDefault(img => img.IsCover).Url))
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url));

            CreateMap<Location, Model.DTO.v2.LocationDto>()
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src => src.Images.FirstOrDefault(img => img.IsCover).Url))
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src => src.Landlord.Avatar.Url))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay));

            CreateMap<Location, LocationDetailsDto>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
                .ForMember(dest => dest.Landlord, opt => opt.MapFrom(src => src.Landlord));

            CreateMap<Image, ImageDto>()
                .ForMember(dest => dest.URL, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.IsCover, opt => opt.MapFrom(src => src.IsCover));

            CreateMap<Landlord, DetailLandlordDto>()
                // voor name alleen firstname of de hele naam?
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar.Url));
        }
    }
}
