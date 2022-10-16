using LifetimeDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LifetimeDemo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly IFirstInstanace _first;
        private readonly ISecondInstance _second;
        public CounterController(ISecondInstance second, 
                                 IFirstInstanace first) =>
            (_second,_first) = (second,first);

        [HttpGet]
        public int Get()
        {
            _first.IncrementAndGet();
            return _second.IncrementAndGet();
        }
    }
}
