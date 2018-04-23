using System.Runtime.Serialization;

namespace task_7
{
    /// <summary>
    /// Class create car with type BMV
    /// </summary>
    [DataContract]
    public class BMW : Car
    {
        public override string Brand { get; set; }
        public BMW(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                    int amount, int power, string climateManagement, string typeOfInterior) : base(model, typeOfBody, typeOfTransmission, typeOfEngine,
                    amount, power, climateManagement, typeOfInterior)
        {
            Brand = "BMW";
        }
    }
}
