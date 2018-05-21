namespace task_DEV10
{
    /// <summary>
    ///  This class for create car with model and count
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public int CountCars { get; set; }

        public Car(string model, int count)
        {
            Model = model;
            CountCars = count;
        }

        public Car()
        { }
    }
}
