using System;
using AutoMapper;
using SharedRide.DAL.Entities;

namespace SharedRide.BL.Models
{
    public record RideListModel(
        string StartingPoint,
        string RideDestination,
        int TimeOfStart,
        int TimeOfRide) : ModelBase
    {
        public string StartingPoint { get; set; } = StartingPoint;
        public string RideDestination { get; set; } = RideDestination;
        public int TimeOfStart { get; set; } = TimeOfStart;
        public int TimeOfRide { get; set; } = TimeOfRide;

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<Ride, RideListModel>();
            }
        }
    }
}