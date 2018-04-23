using System;
using Xunit;

namespace task_7
{
    public class InvokerTest
    {
        Invoker invoker = new Invoker();

       [Fact]
       public void CreateCarTestParametersWithDifferentSymbols()
        {
            //Arrange
            string brand = "Audi";
            string model = "1Q_#$,.32 p";
            string typeOfBody = "Sedan";
            string typeOfTransmission = "Manual";
            string typeOfEngine = "Diesel";
            int amount = 1267;
            int power = 123;
            string climateManagement = "No";
            string typeOfInterior = "Combi";
            Car car = null;

            //Act
            car = invoker.CreateCar(brand, model, typeOfBody, typeOfTransmission, typeOfEngine,
                                       amount, power, climateManagement, typeOfInterior);
            //Assert
            Assert.NotNull(car);
        }

        [Fact]
        public void CreateCarTestParametersWithNullBrand()
        {
            //Arrange
            string brand = null;
            string model = "1Q_#$,.32 p";
            string typeOfBody = "Sedan";
            string typeOfTransmission = "Manual";
            string typeOfEngine = "Diesel";
            int amount = 1267;
            int power = 123;
            string climateManagement = "No";
            string typeOfInterior = "Combi";

            //Act
            //Assert
            Assert.Throws<Exception>(() => invoker.CreateCar(brand, model, typeOfBody, typeOfTransmission, typeOfEngine,
                                                             amount, power, climateManagement, typeOfInterior));
        }

        [Fact]
        public void CreateCarTestParametersWithNullParameters()
        {
            //Arrange
            string brand = "Audi";
            string model = null;
            string typeOfBody = null;
            string typeOfTransmission = null ;
            string typeOfEngine = null;
            int amount = 0;
            int power = 0;
            string climateManagement = null;
            string typeOfInterior = null;
            Car car = null;

            //Act
            car = invoker.CreateCar(brand, model, typeOfBody, typeOfTransmission, typeOfEngine,
                                       amount, power, climateManagement, typeOfInterior);
            //Assert
            Assert.NotNull(car);
        }
    }
}
