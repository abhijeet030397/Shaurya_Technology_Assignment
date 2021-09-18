using CRUDBasics.Handler.QueryHandler;
using CRUDBasics.Models.CommandModel;
using CRUDBasics.RepositoryContracts.QueryContracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CRUDBasics.Models.QueryModel
{
    /// <summary>
    /// VehicleQueryHandler
    /// </summary>
    public class VehicleQueryHandler : IRequestHandler<VehicleQueryModel, User>
    {
        /// <summary>
        /// IUserQueryRepository
        /// </summary>
        public readonly IUserQueryRepository _userQueryRepository;

        /// <summary>
        /// VehicleQueryHandler
        /// </summary>
        public VehicleQueryHandler(IUserQueryRepository userQueryRepository)
        {
            _userQueryRepository = userQueryRepository;
        }

        /// <summary>
        /// Get vechile data
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> Handle(VehicleQueryModel request, CancellationToken cancellationToken)
        {
           return await _userQueryRepository.GetVehicleInformation(request);
        }
    }
}
