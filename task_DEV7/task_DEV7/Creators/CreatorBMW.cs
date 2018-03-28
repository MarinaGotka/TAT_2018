
namespace task_7
{ 
    /// <summary>
    /// Class implements creator interface and create car with type BMV
    /// </summary>
    /// <returns> Returns car BMV </returns>
class CreatorBMW : ICreator
    {
        public Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new BMW(model, typeOfBody, typeOfTransmission, typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
