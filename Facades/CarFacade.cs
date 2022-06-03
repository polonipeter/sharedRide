using AutoMapper;
using SharedRide.BL.Models;
using SharedRide.DAL.Entities;
using SharedRide.DAL.UnitOfWork;

namespace SharedRide.BL.Facades;

public class CarFacade : CRUDFacade<Car, CarListModel, CarDetailModel>
{
    public CarFacade(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory, mapper)
    {
    }

}