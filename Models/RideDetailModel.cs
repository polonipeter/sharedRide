using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using SharedRide.DAL.Entities;


namespace SharedRide.BL.Models
{
    public record RideDetailModel(
        string RideDestination,
        string StartingPoint,
        int TimeOfStart,
        int TimeOfRide) : ModelBase
    {
        public string RideDestination { get; set; } = RideDestination;
        public string StartingPoint { get; set; } = StartingPoint;
        public int TimeOfStart { get; set; } = TimeOfStart;
        public int TimeOfRide { get; set; } = TimeOfRide;
        public List<RidePassengerDetailModel> Users { get; init; } = new();

        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<Ride, RideDetailModel>()
                    .ReverseMap();
            }
        }

        public static RideDetailModel Empty => new(string.Empty, string.Empty, default, default);
    }
}