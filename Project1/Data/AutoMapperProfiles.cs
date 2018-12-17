using System;

namespace Project1.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserSummary>().ForMember(dest => dest.ProfPicUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsProfilePic).Url);
            });
            CreateMap<User, UserDetails>().ForMember(dest => dest.ProfPicUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsProfilePic).Url);
            });
        }
    }
}
