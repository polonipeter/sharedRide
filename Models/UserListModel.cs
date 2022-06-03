using AutoMapper;
using SharedRide.DAL.Entities;

namespace SharedRide.BL.Models
{
    public record UserListModel(string FirstName) : ModelBase
    {
        public string FirstName { get; set; } = FirstName;

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<User, UserListModel>();
            }
        }
    }
}