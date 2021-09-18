using CRUDBasics.Models.CommandModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.RepositoryContracts.CommandContracts
{
    /// <summary>
    /// IUserCommandRepository
    /// </summary>
    public interface IUserCommandRepository
    {
        /// <summary>
        /// AddUser
        /// </summary>
        /// <param name="addUserCommandModel"></param>
        /// <returns></returns>
        Task<long> AddUser(AddUserCommandModel addUserCommandModel);

        /// <summary>
        /// UpdateUser
        /// </summary>
        /// <param name="updateUserCommandModel"></param>
        /// <returns></returns>
        Task<long> UpdateUser(UpdateUserCommandModel updateUserCommandModel);
    }
}
