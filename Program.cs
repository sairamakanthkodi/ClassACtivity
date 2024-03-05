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
            myVehicle.Start();
            myVehicle.Stop();

            Car myCar = new Car("Honda", 2024, "Accord", "Petrol");
            myCar.Start(); 
            myCar.Stop(); 
            myCar.carClass1();
            myCar.carClass2();
        }
    }
}
