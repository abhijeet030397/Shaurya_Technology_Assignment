using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.Models.CommandModel
{
    public class UpdateUserCommandModel :BaseCommandModel, IRequest<long>
    {
     
    }
}
