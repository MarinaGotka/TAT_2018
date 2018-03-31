using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace task_7
{
    /// <summary>
    ///  This class contains methods for accepting data and for working with car
    /// </summary>
    public class Receiver 
    {
        List<Car> carList;
        public Receiver()
        {
        }

        /// <summary>
        ///  This methods produses car and sends it to the storage
        /// </summary>
        public void ProduceCar(Car car,string path)
        {
            if(car == null)
            {
                throw new ArgumentNullException("Error. Car is null.");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string json = JsonConvert.SerializeObject(car);
                sw.WriteLine(json);
            }
            Console.WriteLine("Car was prodused.");
        }

        /// <summary>
        ///  This methods for loading cars from file
        /// </summary>
        /// <returns>Returns the list of cars </returns>
        public List<Car> LoadCarsFromFile(string path)
        {
            carList = new List<Car>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string type = line.Split(',')[0].Split('"')[3];
                        Car car;
                        switch (type)
                        {
                            case "BMW":
                                car = JsonConvert.DeserializeObject<BMW>(line);
                                break;
                            case "Audi":
                                car = JsonConvert.DeserializeObject<Audi>(line);
                                break;
                            case "Land Rover":
                                car = JsonConvert.DeserializeObject<LandRover>(line);
                                break;
                            case "Mazda":
                                car = JsonConvert.DeserializeObject<Mazda>(line);
                                break;
                            case "Tesla":
                                car = JsonConvert.DeserializeObject<Tesla>(line);
                                break;
                            case "Volksvagen":
                                car = JsonConvert.DeserializeObject<Volksvagen>(line);
                                break;
                            default:
                                throw new Exception("Catalog don't exist valid cars");
                        }
                        carList.Add(car);
                    }
                }
            }
            return carList;
        }

        /// <summary>
        ///  This method calls methods to load cars from file and to select suitable cars in catalog.
        /// </summary>
        public IEnumerable<Car> FindCarsFromCatalog(Car car,string path)
        {
            List<Car> list = LoadCarsFromFile(path);
            return SelectCars(list, car);
        }

        /// <summary>
        ///  This method find suitable cars in catalog.
        /// </summary>
        /// <returns>Returns the list of suitable cars </returns>
        public IEnumerable<Car> SelectCars(List<Car> list, Car car)
        {
            IEnumerable<Car> selectedCars = list.Where(c =>
            {
                return (car.Amount == 0 || car.Amount == c.Amount) &&
                    (car.Brand == null || car.Brand == c.Brand) &&
                    (car.ClimateManagement == null || car.ClimateManagement == c.ClimateManagement) &&
                    (car.Model == null || car.Model == c.Model) &&
                    (car.Power == 0 || car.Power == c.Power) &&
                    (car.TypeOfBody == null || car.TypeOfBody == c.TypeOfBody) &&
                    (car.TypeOfEngine == null || car.TypeOfEngine == c.TypeOfEngine) &&
                    (car.TypeOfInterior == null|| car.TypeOfInterior == c.TypeOfInterior) &&
                    (car.TypeOfTransmission == null|| car.TypeOfTransmission == c.TypeOfTransmission);
            });

            return selectedCars;
        }

        /// <summary>
        ///  This method calls methods to load cars from file and to select suitable cars in storage.
        /// </summary>
        public IEnumerable<Car> FindCarsFromStorage(Car car,string path)
        {
            List<Car> list = LoadCarsFromFile(path);
            return SelectCars(list, car);
        }

        /// <summary>
        ///  This method displays cars.
        /// </summary>
        public void DisplayCars(IEnumerable<Car> cars)
        {
            List<Car> list = new List<Car>(cars);
            int i = 1;
            foreach (var c in list)
            {
                Console.Write("#" + i++ + "\n");
                Console.WriteLine(c);
            }
        }
    }
}
