using AutoMapper;
using AutoMapper.EquivalencyExpression;
using SharedRide.DAL.Entities;
namespace SharedRide.BL.Models
{
    public record UserDetailModel(
        string FirstName,
        string LastName,
        string Photo) : ModelBase
    {
        public string FirstName { get; set; } = FirstName;
        public string LastName { get; set; } = LastName;
        public string Photo { get; set; } = Photo;

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<User, UserDetailModel>()
                    .ReverseMap();
            }
        }

        public static UserDetailModel Empty => new(string.Empty, string.Empty, string.Empty);
    }
}