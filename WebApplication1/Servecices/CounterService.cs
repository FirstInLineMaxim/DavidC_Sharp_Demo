namespace WebApplication1.Servecices
{
    public class CounterService : Interfaces.ICounterService
    {
        //Random Comment
        private int _counter;
        public CounterService() { _counter = 0; }
        public int GetCounter()
        {
            return _counter;
        }

        public void Increment()
        {
            _counter++;
        }
    }
}
