using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HeatedSeats { get; set; }
        public bool LeatherInterior { get; set; }
        public int NbrWheels { get ; set ; }
        public int CargoCapacityLbs { get ; set ; }
        public bool OffRoadCapable { get ; set ; }
        public string Description { get ; set ; }
        public string StockSymbol { get ; set ; }
        public int StockPrice { get ; set ; }

        public static void DisplayCar(Car car1)
        {
            Console.WriteLine("**** Cars *****");
            Console.WriteLine($"Off Road          {car1.OffRoadCapable}");
            Console.WriteLine($"Cargo Capacity:   {car1.CargoCapacityLbs}");
            Console.WriteLine($"Heated Seats:     {car1.HeatedSeats}");
            Console.WriteLine($"Leather Interior: {car1.LeatherInterior}");
            Console.WriteLine("--------------------\n\n");
        }

    }
}
