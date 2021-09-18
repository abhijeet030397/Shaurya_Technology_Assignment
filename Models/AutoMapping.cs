using CRUDBasics.Models.CommandModel;
using AutoMapper;

namespace CRUDBasics.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AddUserCommandModel,User>(); // means you want to map from User to UserDTO
        }
    }
}
