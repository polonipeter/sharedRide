using AutoMapper;
using AutoMapper.EquivalencyExpression;
using SharedRide.DAL.Entities;
namespace SharedRide.BL.Models
{
    public record CarDetailModel(
        string CarProducer,
        string CarType,
        DateTime DateOfRegistration,
        string Photo,
        int NumOfSeats) : ModelBase
    {
        public string CarProducer { get; set; } = CarProducer;
        public string CarType { get; set; } = CarType;
        public DateTime DateOfRegistration { get; set; } = DateOfRegistration;
        public string Photo { get; set; } = Photo;
        public int NumOfSeats { get; set; } = NumOfSeats;

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<Car, CarDetailModel>()
                    .ReverseMap();
            }
        }

        public static CarDetailModel Empty => new(string.Empty, string.Empty, default, string.Empty, default);
    }
}

