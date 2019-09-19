using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestTicketProject
{
    [TestClass]
    public class UnitTest1
    {
        Car car = new Car();
        MC mc = new MC();
        [TestMethod]
        public void TestCarPrice()
        {
            // Arrange

            // Act 
            double c = car.Price();

            //Assert
            Assert.AreEqual(240, c);
        }

        [TestMethod]
        public void TestCarVehicleType()
        {
            // Arrange

            // Act 
            string c = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", c);
        }
        [TestMethod]
        public void TestMCPrice()
        {
            // Arrange

            // Act 
            double c = mc.Price();

            //Assert
            Assert.AreEqual(125, c);
        }
        [TestMethod]
        public void TestMCVehicle()
        {
            // Arrange

            // Act 
            string c = mc.Vehicle();

            //Assert
            Assert.AreEqual("MC", c);
        }

        public void TestCarLicenseLength()
        {
            // Arrange

            // Act 
            string c = mc.LicenseLength();

            //Assert
            // Assert.ThrowsException()
        }
    }
}
