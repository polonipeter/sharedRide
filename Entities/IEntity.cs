using System;

namespace SharedRide.DAL.Entities
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}