using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
    abstract class Vehicle:IEngine,IWheel,ITransmission
    {
       
        public double DriveTime {get; set;}
       
        public double DrivePath{get;set;}
        

        public int HorsePower { get; set; }
        public int TankSize { get ; set ; }
        public int CurrentOil { get ; set ; }
        public string Fueltype { get ; set ; }
        public int leftFuelAmount { get; set ; }
        public int WhellTicknese { get ; set ; }

        public abstract double AverageSpeed();
        
        
        public abstract void ShowInfo();
        
        
    }
   
}
