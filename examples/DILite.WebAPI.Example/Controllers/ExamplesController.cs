using DILite.WebAPI.Example.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DILite.WebAPI.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly ISingleton singleton;
        private readonly IScoped scoped;

        public ExamplesController(ISingleton singleton, IScoped scoped)
        {
            this.singleton = singleton;
            this.scoped = scoped;
        }

        [HttpGet]
        public IActionResult Get()
        {
            singleton.DoSomething();
            scoped.DoSomething();

            return Ok();
        }
    }
}
