using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking input for car details
            Console.WriteLine("Enter Car Details:");
            Console.Write("Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Type (hatchback/sedan/utility): ");
            string type = Console.ReadLine();
            Console.Write("Distance (in km): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            // Based on car type, creating the respective object and calculating drive cost
            switch (type.ToLower())
            {
                case "hatchback":
                    Console.Write("Power Windows (true/false): ");
                    bool powerWindows = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Automatic Gear (true/false): ");
                    bool automaticGear = Convert.ToBoolean(Console.ReadLine());
                    Hatchback hatchback = new Hatchback(id, name, powerWindows, automaticGear);
                    double hatchbackCost = hatchback.CalculateDriveCost(distance);
                    Console.WriteLine($"Cost is Rs {Math.Round(hatchbackCost, 0)}");
                    break;
                case "sedan":
                    Console.Write("ABS Enabled (true/false): ");
                    bool absEnabled = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Boot Space (in litres): ");
                    int bootSpace = Convert.ToInt32(Console.ReadLine());
                    Sedan sedan = new Sedan(id, name, absEnabled, bootSpace);
                    double sedanCost = sedan.CalculateDriveCost(distance);
                    Console.WriteLine($"Cost is Rs {Math.Round(sedanCost, 0)}");
                    break;
                case "utility":
                    Console.Write("Rear Cooling Vents (true/false): ");
                    bool rearCoolingVents = Convert.ToBoolean(Console.ReadLine());
                    UtilityCar utilityCar = new UtilityCar(id, name, rearCoolingVents);
                    double utilityCarCost = utilityCar.CalculateDriveCost(distance);
                    Console.WriteLine($"Cost is Rs {Math.Round(utilityCarCost, 0)}");
                    break;
                default:
                    Console.WriteLine("Invalid car type.");
                    break;
            }
        }
    }
}
