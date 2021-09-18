using MediatR;
using CRUDBasics.Models.QueryModel;
using CRUDBasics.Models.CommandModel;
using CRUDBasics.Models;

namespace CRUDBasics.Handler.QueryHandler
{
    /// <summary>
    /// VehicleQueryModel
    /// </summary>
    public class VehicleQueryModel : IRequest<User>
    {
        /// <summary>
        /// VehicleId
        /// </summary>
        public long VehicleId { get; set; }
    }
}
