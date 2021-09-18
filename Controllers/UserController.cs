using CRUDBasics.Handler.QueryHandler;
using CRUDBasics.Models;
using CRUDBasics.Models.CommandModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUDBasics.Controllers
{
    /// <summary>
    /// EmployeeController
    /// </summary>
    public class UserController : ControllerBase
    {
        /// <summary>
        /// IMediator
        /// </summary>
        private readonly IMediator _mediator;

        /// <summary>
        /// UserController
        /// </summary>
        /// <param name="mediator"></param>
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// AddUser
        /// </summary>
        /// <param name="addUserCommand"></param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser([FromBody]AddUserCommandModel addUserCommand)
        {
           var userId =await  _mediator.Send(addUserCommand);
           var response = new { message = "User Added Successfully", userId };
           return Ok(response);
        }

        /// <summary>
        /// UpdateUser
        /// </summary>
        /// <param name="addUserCommand"></param>
        /// <returns></returns>
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody]UpdateUserCommandModel addUserCommand)
        {
            var userId = await _mediator.Send(addUserCommand);
            var response = new { message = "User Updated Successfully", userId };
            return Ok(response);
        }

        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetVehicle")]
        public async Task<IActionResult> GetVehicle([FromRoute]long id)
        {
            return new OkObjectResult(await _mediator.Send(new VehicleQueryModel { VehicleId = id }));
        }

    }
}