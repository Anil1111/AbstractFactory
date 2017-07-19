using System;
using System.Configuration;
using AbstractFactory;
using System.Reflection;
using System.Linq;
using AbstractFactory.Context;
using AbstractFactory.DomainObject;

namespace ClientProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Brand From confuguration
            var name = ConfigurationSettings.AppSettings["Brand"];
            ISampleAppContext Ctx;

            if (name.Equals("BMW", StringComparison.InvariantCultureIgnoreCase))
                Ctx = new SampleAppContext<BMW>();
            else if (name.Equals("Peugot", StringComparison.InvariantCultureIgnoreCase))
                Ctx = new SampleAppContext<Peugeot>();
            else Ctx = new SampleAppContext<Citroen>();

            Console.WriteLine(Ctx.ToString());

        }
        
    }
}
