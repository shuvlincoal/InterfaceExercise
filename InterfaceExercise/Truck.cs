using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool StepUpTailGate { get; set; }
        public bool SplitTailGate  { get; set; }
        public int NbrWheels { get ; set ; }
        public int CargoCapacityLbs { get ; set ; }
        public bool OffRoadCapable { get ; set ; }
        public string Description { get ; set ; }
        public string StockSymbol { get ; set ; }
        public int StockPrice { get ; set ; }

        public static  void DisplayTruck(Truck trk1)
        {
            Console.WriteLine("**** Trucks *****");
            Console.WriteLine($"Off Road        {trk1.OffRoadCapable}");
            Console.WriteLine($"Cargo Capacity: {trk1.CargoCapacityLbs}");
            Console.WriteLine($"StepUpTailGate: {trk1.StepUpTailGate}");
            Console.WriteLine($"SplitTail Gate: {trk1.SplitTailGate}");
            Console.WriteLine("--------------------\n\n");

        }
    }


}
