using System.Runtime.Serialization;

namespace task_7
{
    /// <summary>
    /// This class for inheriting and implementing. Contains car characteristics
    /// </summary>
    [KnownType(typeof(Audi))]
    [KnownType(typeof(BMW))]
    [KnownType(typeof(LandRover))]
    [KnownType(typeof(Mazda))]
    [KnownType(typeof(Tesla))]
    [KnownType(typeof(Volksvagen))]
    [DataContract]
    public abstract class Car
    {
        [DataMember]
        public abstract string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string TypeOfBody { get; set; }
        [DataMember]
        public string TypeOfTransmission { get; set; }
        [DataMember]
        public string TypeOfEngine { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int Power { get; set; }
        [DataMember]
        public string ClimateManagement { get; set; }
        [DataMember]
        public string TypeOfInterior { get; set; }

        public Car(string model, string typeOfBody, string typeOfTransmission, string typeOfEngine,
                    int amount, int power, string climateManagement, string typeOfInterior)
        {
            Model = model;
            TypeOfBody = typeOfBody;
            TypeOfTransmission = typeOfTransmission;
            TypeOfEngine = typeOfEngine;
            Amount = amount;
            Power = power;
            ClimateManagement = climateManagement;
            TypeOfInterior = typeOfInterior;
        }

        public override string ToString()
        {
            string line = "Brand: " + Brand +"\n";
            line += "Model: " + Model + "\n" + "Type of body: " + TypeOfBody + "\n";
            line += "Engine: " + TypeOfEngine + "\n";
            line += "Transmission: " + TypeOfTransmission + "\n";
            line += "Interior: " + TypeOfInterior + "\n";
            line += "Engine volume: " + Amount + "\n";
            line += "Engine capacity: " + Power + "\n";
            line += "Climate: " + ClimateManagement + "\n";
            return line;
        }

        public Car()
        {
        }

    }
}
