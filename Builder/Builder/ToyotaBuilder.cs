using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ToyotaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Camry";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "2.5L";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "Automatic";
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
