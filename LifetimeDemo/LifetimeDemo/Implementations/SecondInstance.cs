using LifetimeDemo.Interfaces;

namespace LifetimeDemo.Implementations
{
    public class SecondInstance : ISecondInstance
    {
        private ICounter _counter;
        public SecondInstance(ICounter counter)=>
            _counter = counter;
        
        public int IncrementAndGet()
        {
            _counter.Increment();
            return _counter.GetCount();
        }
    }
}
