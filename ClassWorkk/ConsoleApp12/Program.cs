using ConsoleApp12.Models;
using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(5,200,400,60,20,"afsf",20,20);
            c.ShowInfo();
        }
    }
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public string Fueltype { get; set; }
        public int leftFuelAmount { get; set; }

    }
    interface IWheel
    {
        public int WhellTicknese { get; set; }
    }
    interface ITranssmision
    {
        public string TranssmisionKind { get; set; }
    }
}
