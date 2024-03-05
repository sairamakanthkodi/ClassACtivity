using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassACtivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle("new", 2020);
            myVehicle.VehicleClass1();
            myVehicle.VehicleClass2();

            Car myCar = new Car("Honda", 2024, "Accord", "Petrol");
            myCar.VehicleClass1();  //Inherit
            myCar.VehicleClass2(); 
            myCar.carClass1();
            myCar.carClass2();
        }
    }
}
