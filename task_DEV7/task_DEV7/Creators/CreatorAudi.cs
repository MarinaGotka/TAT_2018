
namespace task_7
{
    /// <summary>
    /// Class implements creator interface and create car with type Audi
    /// </summary>
    /// <returns> Returns car Audi </returns>
    class CreatorAudi : ICreator
    {
        public Car Create( string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new Audi(model,typeOfBody, typeOfTransmission,typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
