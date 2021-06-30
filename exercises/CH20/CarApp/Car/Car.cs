using System;
namespace Car
{
    public class CarClass
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int GasTankSize { get; set; }

        private double _gasTankLevel;
        public double GasTankLevel 
        {   
            get {return _gasTankLevel; }
            set 
            {
                //if (value > GasTankSize)
                //{
                //    throw new ArgumentOutOfRangeException();
                //}
                //else
                //{
                    _gasTankLevel = value;
                //}
            } 
        }
        public double MilesPerGallon { get; set; }
        public double Odometer { get; set; } = 0;
        public int NumberOfWheels { get; set; }

       

        //Method Updates the GasTankLevel and Odometer based on how many miles driven entered as arg
        public void Drive(double miles)
        {
            //adjust fuel based on mpg and miles requested to drive
            double maxDistance = MilesPerGallon * GasTankLevel;
            /**the double below uses some syntax called the ternary operator.
                * if the value of miles is greater than the value of maxDistance,
                * then milesAbleToTravel = maxDistance.
                * otherwise, if miles is not greater than maxDistance,
                * then milesAbleToTravel = miles
                */
            double milesAbleToTravel = miles > maxDistance ? maxDistance : miles;
            double gallonsUsed = milesAbleToTravel / MilesPerGallon;
            GasTankLevel -= gallonsUsed;
            Odometer += milesAbleToTravel;
        }

        //Method to add gas to the vehicle
        public void AddGas(double gas)
        {
            GasTankLevel += gas;
            if (GasTankLevel > GasTankSize)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        
        //Method to provide max distance for vehicle
        public double GiveMaxDistance()
        {
            double maxDistance = this.MilesPerGallon * this.GasTankLevel;

            return maxDistance;
        }

       
        //Constructor
        public CarClass()
        {
        }

        //Constructor overload +1
        public CarClass(string make, string model, int gasTankSize, double milesPerGallon, int numberOfWheels)
        {
            this.Make = make;
            this.Model = model;
            this.GasTankSize = gasTankSize;
            // Gas tank level defaults to a full tank
            this.GasTankLevel = gasTankSize;
            this.MilesPerGallon = milesPerGallon;
            this.NumberOfWheels = numberOfWheels;
        }

        
    }
    
}
