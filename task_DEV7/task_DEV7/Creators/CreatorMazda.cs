namespace task_7
{
    /// <summary>
    /// Class implements creator interface and create car with type Mazda
    /// </summary>
    /// <returns> Returns car Mazda</returns>
    class CreatorMazda : ICreator
    {
        public Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                   int amount, int power, string climateManagement, string typeOfInterior)
        {
            return new Mazda(model, typeOfBody, typeOfTransmission, typeOfEngine,
                            amount, power, climateManagement, typeOfInterior);
        }
    }
}
