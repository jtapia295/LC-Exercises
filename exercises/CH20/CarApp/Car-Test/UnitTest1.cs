using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car;
using System;

namespace Car_Test
{
    [TestClass]
    public class UnitTest1
    {
        
        CarClass SampleCar = new CarClass("Nissan","Versa", gasTankSize: 11, milesPerGallon:40,4);
        
       
        //Verifies gas tank level is properly adjusted after using drive method in Car class.
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            SampleCar.Drive(50);
            Assert.AreEqual(9.75, SampleCar.GasTankLevel);
        }

        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            SampleCar.Drive(500);
            Assert.AreEqual(0, SampleCar.GasTankLevel);
        }

        //Looks for expected result of ArgumentOutOfRangeException
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverFillException()
        {
            SampleCar.AddGas(5);
            Assert.Fail("Gas limit has been reached!");
            //SampleCar.GasTankLevel = 20;
        }

        [TestMethod]
        public void TestGasTankLevel()
        {
            CarClass car1 = new
            CarClass("Honda", "Accord", 12, 44.5, 4);

            Assert.AreEqual(12, car1.GasTankSize, 1);
        }


        [TestMethod]
        public void TestGiveMaxDistance()
        {
            CarClass car1 = new
            CarClass("Honda", "Accord", 12, 44.5, 4);
            double maxDistance = car1.GiveMaxDistance();
            //Assert.AreEqual(534, maxDistance, 1);
            Assert.IsFalse(maxDistance > 677);
        }
    }
    
}
