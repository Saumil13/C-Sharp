using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();

            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowVehicleInfo();

            Console.WriteLine("---------------");

            vehicleCreator = new VehicleCreator(new ToyotaBuilder());
            vehicleCreator.CreateVehicle();

            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowVehicleInfo();

            Console.ReadLine();

        }
    }
}
