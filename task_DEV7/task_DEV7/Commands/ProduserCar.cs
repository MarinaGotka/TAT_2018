namespace task_7
{
    class ProduserCar : ICommand
    {
        Receiver receiver;
        public ProduserCar(Receiver rec)
        {
            receiver = rec;
        }

        public void Execute(Car car)
        {
           receiver.ProduceCar(car);
        }
    }
}
