using AbstractFactory.DomainObject.Options;
using AbstractFactory.DomainObject.Parts;
using System.Collections.Generic;

namespace AbstractFactory.DomainObject
{
    public interface IVehicle
    {
        string ModelLabel { get; set; }
        string BodyStyle { get; set; }
        string EngineCode { get; set; }
        string ColorCode { get; set; }
        string TrimCode { get; set; }
        string FinitionCode { get; set; }
        List<Option> OptionList { get; set; }
        List<Part> PartsList { get; set; }
        decimal CalculatePrice();
        decimal OptionPrice();
        string VehicleComercialLable { get; }
        string VehicleNetworkLabel { get; }

        // All necessary properties

    }
}
