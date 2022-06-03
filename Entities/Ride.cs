using System;
using System.Collections.Generic;
namespace SharedRide.DAL.Entities;

public record Ride(
Guid Id,
string RideDestination,
string StartingPoint,
int TimeOfStart,
int TimeOfRide) : IEntity



{
    public ICollection<RidePassenger> Users { get; init; } = new List<RidePassenger>();

    public Car? Car { get; init; }

    public User? Driver { get; init; }
}

