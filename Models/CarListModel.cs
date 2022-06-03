using System;
using AutoMapper;
using SharedRide.DAL.Entities;

namespace SharedRide.BL.Models
{
    public record CarListModel(
        string CarProducer,
        string CarType,
        DateTime DateOfRegistration) : ModelBase
    {
        public string CarProducer { get; set; } = CarProducer;
        public string CarType { get; set; } = CarType;
        public DateTime DateOfRegistration { get; set; } = DateOfRegistration;

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<Car, CarListModel>();
            }
        }
    }
}
