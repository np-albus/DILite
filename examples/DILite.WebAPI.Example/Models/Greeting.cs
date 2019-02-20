using DILite.Attributes;
using DILite.Attributes.Enums;
using Microsoft.Extensions.Logging;

namespace DILite.WebAPI.Example.Models
{
    [DIService(DIServiceLifeCycle.Singleton, DIServiceRegisterType.Class)]
    public class Greeter
    {
        private readonly ILogger<Greeter> logger;

        public Greeter(ILogger<Greeter> logger)
        {
            this.logger = logger;
        }

        public void Greet(string message)
        {
            logger.LogInformation($"Hello, I'm {message}.");
        }
    }
}
