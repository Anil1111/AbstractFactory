using AbstractFactory;
using AbstractFactory.DomainObject;
using AbstractFactory.DomainObject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Context
{
    public class SampleAppContext<T> : ISampleAppContext where T : Brand, new()
    {
        IVehicle _CurrentVehicle;

        public SampleAppContext()
        {
            _CurrentVehicle = new Vehicle<T>();
        }

        public IVehicle CurrentVehicle
        {
            get
            { return _CurrentVehicle; }
        }

        public override string ToString()
        {
            return _CurrentVehicle.VehicleComercialLable;
        }
    }

    public interface ISampleAppContext
    {
        IVehicle CurrentVehicle { get; }
    }
}
