using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
    class Plane: Vehicle
    {
        public int WingLenght { get; set; }
        public Plane(double DriveTime, double DrivePath, int HorsePower, int TankSize, int CurrentOil, string Fueltype, int leftFuelAmount, int WhellTicknese)
        {
            this.DriveTime = DriveTime;
            this.DrivePath = DrivePath;
            this.HorsePower = HorsePower;
            this.TankSize = TankSize;
            this.CurrentOil = CurrentOil;
            this.Fueltype = Fueltype;
            this.leftFuelAmount = leftFuelAmount;
            this.WhellTicknese = WhellTicknese;
        }
        public override double AverageSpeed()
        {
            double speed = DrivePath / DrivePath;
            return speed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{DriveTime}\n{DrivePath}\n{HorsePower}\n{TankSize}\n{CurrentOil}\n{Fueltype}\n{leftFuelAmount}\n{WhellTicknese}");
        }
    }
}
