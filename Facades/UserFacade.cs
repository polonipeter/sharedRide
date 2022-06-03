using AutoMapper;
using SharedRide.BL.Models;
using SharedRide.DAL.Entities;
using SharedRide.DAL.UnitOfWork;


namespace SharedRide.BL.Facades;

public class UserFacade : CRUDFacade<User, UserListModel, UserDetailModel>
{
    public UserFacade(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory, mapper)
    {
    }
}