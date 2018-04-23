using System.Runtime.Serialization;

namespace task_7
{
    /// <summary>
    /// Class create car with type Mazda
    /// </summary>
    [DataContract]
    public class Mazda : Car
    {
        public override string Brand { get; set; }
        public Mazda(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                    int amount, int power, string climateManagement, string typeOfInterior) : base(model, typeOfBody, typeOfTransmission, typeOfEngine,
                    amount, power, climateManagement, typeOfInterior)
        {
            Brand = "Mazda";
        }
    }
}
