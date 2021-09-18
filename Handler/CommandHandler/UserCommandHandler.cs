using CRUDBasics.Models.CommandModel;
using CRUDBasics.RepositoryContracts.CommandContracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CRUDBasics.Handler.CommandHandler
{
    public class UserCommandHandler : IRequestHandler<AddUserCommandModel, long>,
                                      IRequestHandler<UpdateUserCommandModel, long>
    {
        /// <summary>
        /// IUserCommandRepository
        /// </summary>
        public readonly IUserCommandRepository _userCommandRepository;

        /// <summary>
        /// UserCommandHandler
        /// </summary>
        /// <param name="userCommandRepository"></param>
        public UserCommandHandler(IUserCommandRepository userCommandRepository)
        {
            _userCommandRepository = userCommandRepository;
        }
        /// <summary>
        /// AddUserCommandModel
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<long> Handle(AddUserCommandModel request, CancellationToken cancellationToken)
        {
           return await _userCommandRepository.AddUser(request);
        }

        /// <summary>
        /// UpdateUserCommandModel
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<long> Handle(UpdateUserCommandModel request, CancellationToken cancellationToken)
        {
            return await _userCommandRepository.UpdateUser(request);
        }
    }
}
