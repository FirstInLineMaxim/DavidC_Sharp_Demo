using Microsoft.AspNetCore.Mvc;
using WebApplication1.Servecices.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : Controller

    {
        private ICounterService _counterService;
        public CounterController(ICounterService counterService)
        {
            _counterService = counterService;
        }
        //<server>/counter/getcurrentcounter
        [HttpGet(nameof(Counter))]
        public IActionResult Counter()
        {
            return new OkObjectResult(_counterService.GetCounter());
        }

        [HttpGet(nameof(Increment))]
        public IActionResult Increment()
        {
         _counterService.Increment();
            return new OkObjectResult("SUCCESS");
        }
    }
}
