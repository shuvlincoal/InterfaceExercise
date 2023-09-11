using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int    NbrWheels        { get; set; }
        public int    CargoCapacityLbs { get; set; }
        public bool   OffRoadCapable   { get; set; }    
        public string Description      { get; set; }
    }
}
