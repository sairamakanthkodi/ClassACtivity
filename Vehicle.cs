using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Vehicle
{
    public string Make { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, int year)
    {
        Make = make;
        Year = year;
    }

    public void VehicleClass1()
    {
        Debug.WriteLine(Make +" "+ Year + " Vehicle class 1");
    }

    public void VehicleClass2()
    {
        Debug.WriteLine(Make + " " + Year + " Vehicle class 2");
    }
}

