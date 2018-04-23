namespace task_7
{
    /// <summary>
    /// Class implements creator interface and create car with type Land Rover
    /// </summary>
    /// <returns> Returns car Land Rover </returns>
    class CreatorLandRover : ICreator
    {
        public Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new LandRover(model, typeOfBody, typeOfTransmission, typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
