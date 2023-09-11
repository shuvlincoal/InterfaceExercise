using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany [DONE]

            //Create 3 classes called Car , Truck , & SUV [DONE]

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. [DONE]
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company [DONE]
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class [DONE]
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and
             * implement their members.  [DONE]
             * 
             */

            //Now, create objects of your 3 classes and give their members values; [DONE]
            //Creatively display and organize their values [DONE]

            Car   car1  = new Car()   { HeatedSeats = true, LeatherInterior = true, CargoCapacityLbs = 300, StockSymbol = "CXX" };
            SUV   suv1  = new SUV()   { HatchBack = true, RoofRack = true, CargoCapacityLbs = 600, StockSymbol = "OCX" };
            Truck trk1  = new Truck() { SplitTailGate = true, StepUpTailGate = true, CargoCapacityLbs = 1000, StockSymbol = "BVN" };

            Console.WriteLine($"Car: {car1}");

            //List<IVehicle> transportList = new List<IVehicle>();
            //transportList.Add(car1);
            //transportList.Add(suv1);
            //transportList.Add(trk1);

            //List<Car> carList = new List<Car>();
            //carList.Add(car1);
            //List<SUV> suvList = new List<SUV>();
            //suvList.Add(suv1);
            //List<Truck> trkList = new List<Truck>();
            //trkList.Add(trk1);


            Car.DisplayCar(car1);
            SUV.DisplaySUV(suv1);
            Truck.DisplayTruck(trk1);


        }
    }
}
