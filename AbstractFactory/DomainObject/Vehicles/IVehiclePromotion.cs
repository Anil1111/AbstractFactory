using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DomainObject.Vehicles
{
    public interface IVehiclePromotion : IVehicle
    {
        decimal Promotion { get; set; }
    }
}
