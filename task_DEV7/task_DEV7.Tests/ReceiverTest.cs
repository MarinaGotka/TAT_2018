using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace task_7
{
    public class ReceiverTest
    {
        Receiver receiver = new Receiver();
        Car car1 = new BMW("12X", "Sedan", "Automatic", "Petrol", 1630, 123, "Air conditioning", "Leather");
        Car car2 = new Audi("Q8", "Minivan", "Automatic", "Diesel", 1584, 231, "Climate control", "Combi");
        Car car3 = new Volksvagen("P1", "Sedan", "Automatic", "Petrol", 1219, 100, "No", "Tissue");
        Car car4 = new Volksvagen("P1", "Sedan", "Automatic", "Petrol", 1219, 100, "No", "Tissue");
        Car car5 = new Volksvagen("P1", "Estate car", "Manual", "Petrol", 1309, 111, "No", "Leather");
        Car car6 = new BMW("12X", "Sedan", "Automatic", "Petrol", 1630, 123, "Air conditioning", "Leather");
        Car car7 = new Tesla("W", "Estate car", "Automatic", "Electric", 1567, 300, "Climate control", "Leather");

        [Fact]
        public void LoadCarsFromFileTest()
        {
            // Arrange
            string stringResult = "{\"Brand\":\"BMW\",\"Model\":\"12X\",\"TypeOfBody\":\"Sedan\",\"TypeOfTransmission\":\"Automatic\",\"TypeOfEngine\":\"Petrol\",\"Amount\":1630,\"Power\":123,\"ClimateManagement\":\"Air conditioning\",\"TypeOfInterior\":\"Leather\"}";
            string stringContent = String.Empty;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7\bin\Debug\storageTest.json"))
            {
                string json = JsonConvert.SerializeObject(car1);
                sw.WriteLine(json);
            }

            // Act
            receiver.LoadCarsFromFile(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7\bin\Debug\storageTest.json");

            // Assert
            using (StreamReader sr = new StreamReader(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7\bin\Debug\storageTest.json"))
            {
                stringContent = sr.ReadLine();
            }
            Assert.Equal(stringContent, stringResult);
        }

        [Fact]
        public void ProduceCarTest()
        {
            // Arrange
            string stringResult = "{\"Brand\":\"BMW\",\"Model\":\"12X\",\"TypeOfBody\":\"Sedan\",\"TypeOfTransmission\":\"Automatic\",\"TypeOfEngine\":\"Petrol\",\"Amount\":1630,\"Power\":123,\"ClimateManagement\":\"Air conditioning\",\"TypeOfInterior\":\"Leather\"}";
            string stringContent = String.Empty;

            // Act
            receiver.ProduceCar(car1, @"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7\bin\Debug\storageTest.json");

            // Assert
            using (StreamReader sr = new StreamReader(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7\bin\Debug\storageTest.json"))
            {
                while (!sr.EndOfStream)
                {
                    stringContent = sr.ReadLine();
                }
            }
            Assert.Equal(stringContent, stringResult);
        }

        [Fact]
        public void SelectCarsByAllParameters()
        {
            // Arrange
            List<Car> carList = new List<Car>
            {
                car1,
                car2,
                car3
            };
            Car desiredCar = new Audi("Q8", "Minivan", "Automatic", "Diesel", 1584, 231, "Climate control", "Combi");
            List<Car> expectedList = new List<Car>();
            expectedList.Add(desiredCar);

            // Act
            IEnumerable<Car> actual = receiver.SelectCars(carList, desiredCar);
            List<Car> actualList = new List<Car>(actual);

            // Assert
            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void SelectCarsByOneParameterAndOtherEmpty()
        {
            // Arrange
            List<Car> carList = new List<Car>
            {
                car1,
                car2
            };
            Car desiredCar = new Audi("Q8",null, null, null, 0, 0, null, null);
            List<Car> expectedList = new List<Car>();
            expectedList.Add(car2);

            // Act
            IEnumerable<Car> actual = receiver.SelectCars(carList, desiredCar);
            List<Car> actualList = new List<Car>(actual);

            // Assert
            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void SelectCarsBySeveralParameterAndOtherEmpty()
        {
            // Arrange
            List<Car> carList = new List<Car>
            {
                car1,
                car2,
                car5
            };
            Car desiredCar = new Audi(null, "Minivan", null, null, 0, 231, null, null);
            List<Car> expectedList = new List<Car>();
            expectedList.Add(car2);

            // Act
            IEnumerable<Car> actual = receiver.SelectCars(carList, desiredCar);
            List<Car> actualList = new List<Car>(actual);

            // Assert
            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void SelectCarsByAllParametersAreEmpty()
        {
            // Arrange
            List<Car> carList = new List<Car>
            {
                car1,
                car2
            };
            Car desiredCar = new BMW(null, null, null, null, 0, 0, null, null);
            List<Car> expectedList = new List<Car>();
            expectedList.Add(car1);

            // Act
            IEnumerable<Car> actual = receiver.SelectCars(carList, desiredCar);
            List<Car> actualList = new List<Car>(actual);

            // Assert
            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void FindCarsFromCatalogAllParametersAreNotEmpty()
        {
            //Arrange
            List<Car> carList = new List<Car>()
            {
                car1,
                car2,
                car7
            };
            foreach (Car c in carList)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7.Tests\catalogTest.json", true))
                {
                    string json = JsonConvert.SerializeObject(c);
                    sw.WriteLine(json);
                }
            }
            Car desiredCar = new Tesla("W", "Estate car", "Automatic", "Electric", 1567, 300, "Climate control", "Leather");
            List<Car> expectedList = new List<Car>();
            expectedList.Add(car7);

            //Act
            IEnumerable<Car> actual = receiver.FindCarsFromCatalog(desiredCar, @"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7.Tests\catalogTest.json");
            List<Car> actualList = new List<Car>(actual);

            //Assert
            Assert.Equal(expectedList, actual);
        }

        [Fact]
        public void FindCarsFromCatalogAllParametersAreEmpty()
        {
            //Arrange
            List<Car> carList = new List<Car>
            {
                car1,
                car3,
            };
            foreach (Car c in carList)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7.Tests\catalogTest.json", true))
                {
                    string json = JsonConvert.SerializeObject(c);
                    sw.WriteLine(json);
                }
            }
            Car desiredCar = new BMW(null, null, null, null, 0, 0, null, null);
            List<Car> expectedList = new List<Car>();
            expectedList.Add(car1);

            //Act
            IEnumerable<Car> actual = receiver.FindCarsFromCatalog(desiredCar, @"C:\Users\Марина\Desktop\TAT_2018\task_DEV7\task_DEV7.Tests\catalogTest.json");
            List<Car> actualList = new List<Car>(actual);

            //Assert
            Assert.Equal(expectedList, actualList);
        }
    }
}
