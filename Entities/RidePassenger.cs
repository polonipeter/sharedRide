using System;
using System.Collections.Generic;


namespace SharedRide.DAL.Entities;

public record RidePassenger(
Guid Id,
Guid UserId,
Guid RideId) : IEntity

{
    public RidePassenger() : this(default, default, default) { }
    public Ride? Ride { get; init; }
    public User? User { get; init; }
}

