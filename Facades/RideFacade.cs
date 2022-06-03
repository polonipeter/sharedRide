using AutoMapper;
using SharedRide.BL.Models;
using SharedRide.DAL.Entities;
using SharedRide.DAL.UnitOfWork;

namespace SharedRide.BL.Facades;

public class RideFacade : CRUDFacade<Ride, RideListModel, RideDetailModel>
{
    public RideFacade(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory, mapper)
    {
    }

}