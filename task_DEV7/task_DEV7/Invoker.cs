﻿using System;
using System.Collections.Generic;
using task_DEV7.Commands;

namespace task_7
{
    /// <summary>
    ///  This class contains the methods for dialogue with the user and accepting input data
    /// </summary>
    public class Invoker
    {
        Receiver receiver;

        string brand;
        string model;
        string typeOfBody;
        string typeOfTransmission;
        string typeOfEngine;
        int amount;
        int power;
        string climateManagement;
        string typeOfInterior;

        public Invoker(Receiver rec)
        {
            this.receiver = rec;
        }

        /// <summary>
        ///  This method for accepting input data
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("Input the options you are interested in: ");
            Console.Write("Number of brand:");
            brand = InputBrand();

            Console.WriteLine("Number of model:");
            model = InputModel();

            Console.WriteLine("Number of type of Body:");
            typeOfBody = InputTypeOfBody();

            Console.WriteLine("Number of type of transmission:");
            typeOfTransmission = InputTypeOfTransmission();

            Console.WriteLine("Number of type of engine:");
            typeOfEngine = InputTypeOfEngine();

            Console.WriteLine("Amount (in cubic centimeter):");
            amount = InputEngineAmount();

            Console.WriteLine("Power (in hp):");
            power = InputEnginePower();

            Console.WriteLine("Number of climat management:");
            climateManagement = InputClimateManagement();
            
            Console.WriteLine("Number of type of interior:");
            if (typeOfTransmission == "Automatic")
            {
                typeOfInterior = "Leather";
                Console.WriteLine("Automatic type of transmission was choosen and type of interior can be " +
                                  "only leather.");
            }
            else
            {
                typeOfInterior = InputTypeOfInterior();
            }
           
            Car car = CreateCar(brand,model, typeOfBody, typeOfTransmission, typeOfEngine,
                                amount, power, climateManagement, typeOfInterior);
            bool storage = false;
            Console.Write("View first cars in storage? (yes/no): ");  
            storage = (Console.ReadLine() == "yes") ? true :  false;
            if (storage)
            {
                Console.WriteLine("Available variants in storage:  ");
                ICommand command = new FindCarsFromStorage(receiver);
                IEnumerable<Car> cars = command.Execute(car);
                receiver.DisplayCars(cars);
                ChooseCarForProduse(cars);
            }
            else
            {
                Console.WriteLine("Available variants in catalog:  ");
                ICommand command = new FindCarsFromCatalog(receiver);
                IEnumerable<Car> cars = command.Execute(car);
                receiver.DisplayCars(cars);
                ChooseCarForProduse(cars);
            }
        }

        /// <summary>
        ///  This methods for choosing the model of car
        /// </summary>
        /// <returns>Returns the model </returns>
        public string InputModel()
        {
            string model = Console.ReadLine();
            if(model == String.Empty)
            {
                model = null;
            }
            return model;
        }

        /// <summary>
        ///  This methods for choosing the engine power of car
        /// </summary>
        /// <returns>Returns the power </returns>
        public int InputEnginePower()
        {
            int power = 0;
            int.TryParse(Console.ReadLine(), out power);
            return power;
        }

        /// <summary>
        ///  This methods for choosing the engine amount of car
        /// </summary>
        /// <returns>Returns the amount</returns>
        public int InputEngineAmount()
        {
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            return amount;
        }

        /// <summary>
        ///  This methods for choosing the brand of car
        /// </summary>
        /// <returns>Returns the brand </returns>
        public string InputBrand()
        {
            Console.WriteLine("\n1.BMW\n" +
                "2.Audi\n" + "3.Mazda\n" + "4.Tesla\n" + "5.Volkswagen\n" +
                "6.Land Rover\n");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    brand = "BMW";
                    break;
                case 2:
                    brand = "Audi";
                    break;
                case 3:
                    brand = "Mazda";
                    break;
                case 4:
                    brand = "Tesla";
                    break;
                case 5:
                    brand = "Volksvagen";
                    break;
                case 6:
                    brand = "Land Rover";
                    break;
                default:
                    brand = null;
                    break;
            }
            return brand;
        }

        /// <summary>
        ///  This methods for choosing the type of body of car
        /// </summary>
        /// <returns>Returns the type of body</returns>
        public string InputTypeOfBody()
        {
            Console.WriteLine("1.Estate car\n2.Sedan\n3.Minivan\n" +
                "4.Coupe");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    typeOfBody = "Estate car";
                    break;
                case 2:
                    typeOfBody = "Sedan";
                    break;
                case 3:
                    typeOfBody = "Minivan";
                    break;
                case 4:
                    typeOfBody = "Coupe";
                    break;
                default:
                    typeOfBody = null;
                    break;
            }
            return typeOfBody;
        }

        /// <summary>
        ///  This methods for choosing the type of transmission of car
        /// </summary>
        /// <returns>Returns the type of transmission</returns>
        public string InputTypeOfTransmission()
        {
            Console.WriteLine("1.Manual\n2.Automatic");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    typeOfTransmission = "Manual";
                    break;
                case 2:
                    typeOfTransmission = "Automatic";
                    break;
                default:
                    typeOfTransmission = null;
                    break;
            }
            return typeOfTransmission;
        }

        /// <summary>
        ///  This methods for choosing the type of engine of car
        /// </summary>
        /// <returns>Returns the type of engine</returns>
        public string InputTypeOfEngine()
        {
            Console.WriteLine("1.Petrol\n2.Diesel\n3.Electric");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    typeOfEngine = "Petrol";
                    break;
                case 2:
                    typeOfEngine = "Diesel";
                    break;
                case 3:
                    typeOfEngine = "Electric";
                    break;
                default:
                    typeOfEngine = null;
                    break;
            }
            return typeOfEngine;
        }

        /// <summary>
        ///  This methods for choosing the climate management of car
        /// </summary>
        /// <returns>Returns the climate management</returns>
        public string InputClimateManagement()
        {
            Console.WriteLine("1.Air conditioning\n2.Climate control\n3.No");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    climateManagement = "Air conditioning";
                    break;
                case 2:
                    climateManagement = "Climate control";
                    break;
                case 3:
                    climateManagement = "No";
                    break;
                default:
                    climateManagement = null;
                    break;
            }
            return climateManagement;
        }

        /// <summary>
        ///  This methods for choosing the type of interior of car
        /// </summary>
        /// <returns>Returns the type of interior</returns>
        public string InputTypeOfInterior()
        {
            Console.WriteLine("1.Leather\n2.Tissue\n3.Combi");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    typeOfInterior = "Leather";
                    break;
                case 2:
                    typeOfInterior = "Tissue";
                    break;
                case 3:
                    typeOfInterior = "Combi";
                    break;
                default:
                    typeOfInterior = null;
                    break;
            }
            return typeOfInterior;
        }

        /// <summary>
        ///  This methods for choosing the car for producing
        /// </summary>
        /// <returns>Returns the model </returns>
        public void ChooseCarForProduse(IEnumerable<Car> cars)
        {
            List<Car> carList = new List<Car>(cars);
            Console.WriteLine("Choose number of car for producing:  ");
            string stringNumber = Console.ReadLine();
            int n = 0;
            int.TryParse(stringNumber, out n);
            Car choosenCar = null;
            if (n <= carList.Count && n > 0)
            {
                choosenCar = carList[n - 1];
                receiver.ProduceCar(choosenCar);
            }
        }
        
        public Car CreateCar(string brand, string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                             int amount, int power, string climateManagement, string typeOfInterior)
        {
            Car car = null;
            switch (brand)
            {
                case "BMW":
                    car = new BMW(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                  amount, power, climateManagement, typeOfInterior);
                    break;
                case "Audi":
                    car = new Audi(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                   amount, power, climateManagement, typeOfInterior);
                    break;
                case "LandRover":
                    car = new LandRover(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                        amount, power, climateManagement, typeOfInterior);
                    break;
                case "Mazda":
                    car = new Mazda(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                    amount, power, climateManagement, typeOfInterior);
                    break;
                case "Tesla":
                    car = new Tesla(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                    amount, power, climateManagement, typeOfInterior);
                    break;
                case "Volksvagen":
                    car = new Volksvagen(model, typeOfBody, typeOfTransmission, typeOfEngine,
                                      amount, power, climateManagement, typeOfInterior);
                    break;
                default:
                    car = null;
                    break;
            }
            return car;
        }
    }
}