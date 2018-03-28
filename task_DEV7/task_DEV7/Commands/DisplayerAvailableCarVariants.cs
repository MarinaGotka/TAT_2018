namespace task_7
{
    class DisplayerAvailableCarVariants : ICommand
    {
        Receiver receiver;
        public DisplayerAvailableCarVariants(Receiver rec)
        {
            receiver = rec;
        }
        
        public void Execute(Car car)
        {
            receiver.DisplayAvailableCarVariants();
        }
    }
}
