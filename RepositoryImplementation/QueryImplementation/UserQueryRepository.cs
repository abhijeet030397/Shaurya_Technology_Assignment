using CRUDBasics.Handler.QueryHandler;
using CRUDBasics.Models;
using CRUDBasics.Models.CommandModel;
using CRUDBasics.Models.QueryModel;
using CRUDBasics.RepositoryContracts.QueryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.RepositoryImplementation.QueryImplementation
{
    /// <summary>
    /// UserQueryRepository
    /// </summary>
    public class UserQueryRepository : IUserQueryRepository
    {
        private readonly AppDbContext appDbContext;
        /// <summary>
        /// UserQueryRepository
        /// </summary>
        public UserQueryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        /// <summary>
        /// GetVehicleInformation
        /// </summary>
        /// <param name="vehicleQueryModel"></param>
        /// <returns></returns>
        public async Task<User> GetVehicleInformation(VehicleQueryModel queryModel)
        {
           return await appDbContext.Users.Include(e => e.Vehicle).FirstOrDefaultAsync(u => u.Vehicle.VehicleId == queryModel.VehicleId);
        }
    }
}
