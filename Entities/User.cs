using System;
using System.Collections.Generic;

namespace SharedRide.DAL.Entities;

public record User(
Guid Id,
string FirstName,
string LastName,
string Photo) : IEntity

{
    public ICollection<Ride> Rides { get; init; } = new List<Ride>();

    public ICollection<Car> Cars { get; init; } = new List<Car>();
}

