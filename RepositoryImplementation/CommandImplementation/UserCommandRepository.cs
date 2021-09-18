using AutoMapper;
using CRUDBasics.Models;
using CRUDBasics.Models.CommandModel;
using CRUDBasics.RepositoryContracts.CommandContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.RepositoryImplementation.CommandImplementation
{

    /// <summary>
    /// UserCommandRepository
    /// </summary>
    public class UserCommandRepository : IUserCommandRepository
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext appDbContext;
        /// <summary>
        /// UserCommandRepository
        /// </summary>
        public UserCommandRepository(AppDbContext appDbContext,IMapper mapper)
        {
            this.appDbContext = appDbContext;
            _mapper = mapper;
        }
        /// <summary>
        /// AddUser
        /// </summary>
        /// <param name="addUserCommandModel"></param>
        /// <returns></returns>
        public async Task<long> AddUser(AddUserCommandModel addUserCommandModel)
        {
            var request = _mapper.Map<User>(addUserCommandModel);
            var result = appDbContext.Users.AddAsync(request);
            await appDbContext.Vehicle.AddAsync(addUserCommandModel.Vehicle);
            await appDbContext.SaveChangesAsync();
            return result.Result.Entity.UserId;
        }

        /// <summary>
        /// UpdateUser
        /// </summary>
        /// <param name="updateUserCommandModel"></param>
        /// <returns></returns>
        public async Task<long> UpdateUser(UpdateUserCommandModel updateUserCommandModel)
        {

            var result = appDbContext.Users.Update(updateUserCommandModel);
            appDbContext.Vehicle.Update(updateUserCommandModel.Vehicle);
            await appDbContext.SaveChangesAsync();
            return result.Entity.UserId;
        }
    }
}
