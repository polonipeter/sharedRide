using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedRide.DAL.Entities;


public record Car(
    Guid Id,
    string CarProducer,
    string CarType,
    DateTime DateOfRegistration,
    string Photo,
    int NumOfSeats) : IEntity

{
    public User? Owner { get; init; }
    public ICollection<Ride> Rides { get; init; }=new List<Ride>();
}