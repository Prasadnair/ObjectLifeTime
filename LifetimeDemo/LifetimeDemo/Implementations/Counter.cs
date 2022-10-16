using LifetimeDemo.Interfaces;

namespace LifetimeDemo.Implementations
{
    public class Counter : ICounter
    {
        private int _count;
        public int GetCount() => _count ;
        public void Increment() => _count++;
        
    }
}
