using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Car : Vehicle
{
    public string Model { get; set; }
    public string EngineType { get; set; }

    public Car(string make, int year, string model, string engineType) : base(make, year)
    {
        Model = model;
        EngineType = engineType;
    }

    public void carClass1()
    {
        Debug.WriteLine(Make + " " + Model + " Car class 1");
    }

    public void carClass2()
    {
        Debug.WriteLine(Make +" " + Model + " "+ EngineType + " Car class 2");
    }
}

