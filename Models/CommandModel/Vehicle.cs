using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBasics.Models.CommandModel
{
    /// <summary>
    /// AddVehichleCommandModel
    /// </summary>
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string ChassisNumber { get; set; }

        public string EngineNumber { get; set; }
        public string Manufacturingyear { get; set; }
        public string LoadCarryingCapacity { get; set; }
        public string MakeOfVehicle { get; set; }

        public string  ModelNumber{ get; set; }
        public string  BondType{ get; set; }
        public string  OrganizationName{ get; set; }
        public long DeviceID { get; set; }
        public long  UserID { get; set; }
        public long VehicleId { get; internal set; }
    }
}
