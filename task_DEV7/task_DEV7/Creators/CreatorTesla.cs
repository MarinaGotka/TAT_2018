

namespace task_7
{
    /// <summary>
    /// Class implements creator interface and create car with type Tesla
    /// </summary>
    /// <returns> Returns car Tesla </returns>
    class CreatorTesla : ICreator
    {
        public Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new Tesla(model, typeOfBody, typeOfTransmission, typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
