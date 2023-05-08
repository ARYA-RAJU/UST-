using CarNS;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CarTests

{

    [TestClass]

    public class CarTestsClass

    {

        Car test_car;

        [TestInitialize]

        public void CreateCarObject()

        {

            test_car = new Car("Toyota", "Prius", 10, 50);

        }

        //TODO: constructor sets gasTankLevel properly

        [TestMethod]

        public void TestConstructorSetsGasTankLevel()

        {

            double expectedValue = 10;

            double actualValue = test_car.GasTankLevel;

            Assert.AreEqual(expectedValue, actualValue, "Gas tank level not set correctly in constructor");

        }

        //TODO: gasTankLevel is accurate after driving within tank range

        [TestMethod]

        public void TestGasTankLevelIsAccurateAfterDrivingWithinTankRange()

        {

            double milesToDrive = 200;

            test_car.Drive(milesToDrive);

            double expectedGasTankLevel = test_car.GasTankSize - milesToDrive / test_car.MilesPerGallon;

            Assert.AreEqual(expectedGasTankLevel, test_car.GasTankLevel, 0.001);

        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range

        [TestMethod]

        public void TestGasTankLevelAccuracyAfterAttemptingToDrivePastRange()

        {

            double miles = 550;

            test_car.Drive(miles);

            double expectedValue = 0;

            double actualValue = test_car.GasTankLevel;

            Assert.AreEqual(expectedValue, actualValue, "Gas tank level not accurate after attempting to drive past tank range");

        }

        //TODO: can't have more gas than tank size, expect an exception

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void TestGasOverfillException()

        {

            test_car.AddGas(5);

            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");

        }

    }

}





























