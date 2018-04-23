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

        public Car()
        {
        }

        /// <summary>
        /// Ovveriding method ToString for Car.
        /// </summary>
        /// <returns> Returns Car as a string </returns>
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

        /// <summary>
        /// Ovveriding method Equals for Car.
        /// </summary>
        /// <returns> Returns result of compare Cars </returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }
            Car other = (Car) obj;

            return (Brand.Equals(other.Brand) && Model.Equals(other.Model) && TypeOfBody.Equals(other.TypeOfBody) 
                && TypeOfEngine.Equals(other.TypeOfEngine) && TypeOfTransmission.Equals(other.TypeOfTransmission) 
                && Amount.Equals(other.Amount) && Power.Equals(other.Power) && TypeOfInterior.Equals(other.TypeOfInterior)
                && ClimateManagement.Equals(other.ClimateManagement));
        }

        /// <summary>
        /// Ovveriding method GerHashCode for Car.
        /// </summary>
        /// <returns> Returns hashCode </returns>
        public override int GetHashCode()
        {
            return (Model.GetHashCode()+ TypeOfBody.GetHashCode());
        }
    }
}
