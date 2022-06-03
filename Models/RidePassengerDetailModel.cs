using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using SharedRide.DAL.Entities;


namespace SharedRide.BL.Models
{
    public record RidePassengerDetailModel(
        User User,
        Ride Ride) : ModelBase
    {
        public User User { get; set; } = User;
        public Ride Ride { get; set; } = Ride;


        public class MapperProfile : Profile
        {
            public MapperProfile()
            {
                CreateMap<RidePassenger, RidePassengerDetailModel>()
                    .ReverseMap()
                    .ForMember(entity => entity.User, expression => expression.Ignore())
                    .ForMember(entity => entity.Ride, expression => expression.Ignore())
                    .ForMember(entity => entity.RideId, expression => expression.Ignore());
            }
        }
    }
}