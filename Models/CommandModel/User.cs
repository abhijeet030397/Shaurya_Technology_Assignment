using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.Models.CommandModel
{
    public class User
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
