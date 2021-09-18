using CRUDBasics.Handler.QueryHandler;
using CRUDBasics.Models.CommandModel;
using CRUDBasics.Models.QueryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.RepositoryContracts.QueryContracts
{
    /// <summary>
    /// IUserQueryRepository
    /// </summary>
    public interface IUserQueryRepository
    {
        Task<User> GetVehicleInformation(VehicleQueryModel queryModel);
    }
}
