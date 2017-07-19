using AbstractFactory.DomainObject.Equipments;
using System.Collections.Generic;

namespace AbstractFactory.DomainObject.Parts
{
    public class Part
    {
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public List<Equipment> EquipmentList { get; set; }

    }
}