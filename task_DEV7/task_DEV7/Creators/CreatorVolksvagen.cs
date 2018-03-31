namespace task_7
{
    /// <summary>
    /// Class implements creator interface and create car with type Volksvagen
    /// </summary>
    /// <returns> Returns car Volksvagen </returns>
    class CreatorVolksvagen : ICreator
    {
        public Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new Volksvagen(model, typeOfBody, typeOfTransmission, typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
