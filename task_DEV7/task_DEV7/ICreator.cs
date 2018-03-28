namespace task_7
{
    /// <summary>
    /// Interface to inheriting and implementing his method for craeting car
    /// </summary>
    public interface ICreator
    {
        Car Create(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                                  int amount, int power, string climateManagement, string typeOfInterior);
        
    }
}
