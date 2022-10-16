using LifetimeDemo.Interfaces;

namespace LifetimeDemo.Implementations
{
    public class FirstInstance : IFirstInstanace
    {
        private ICounter _counter;
        public FirstInstance(ICounter counter)=>
            _counter = counter;
        
        public int IncrementAndGet()
        {
            _counter.Increment();
            return _counter.GetCount();
        }
    }
}
