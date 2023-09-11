using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HatchBack { get; set; }
        public bool RoofRack { get; set; }
        public string StockSymbol { get ; set ; }
        public int StockPrice { get ; set ; }
        public int NbrWheels { get ; set ; }
        public int CargoCapacityLbs { get ; set ; }
        public bool OffRoadCapable { get ; set ; }
        public string Description { get ; set ; }

        public static void DisplaySUV(SUV suv1)
        {
            Console.WriteLine("**** SUV *****");
            Console.WriteLine($"Off Road        {suv1.OffRoadCapable}");
            Console.WriteLine($"Cargo Capacity: {suv1.CargoCapacityLbs}");
            Console.WriteLine($"Hatchback:      {suv1.HatchBack}");
            Console.WriteLine($"Roof Rack:      {suv1.RoofRack}");
            Console.WriteLine("--------------------\n\n");
        }

    }
}
