using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HondaBuilder : IVehicleBuilder
    {
        private Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "2.5L";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "Manual";
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
