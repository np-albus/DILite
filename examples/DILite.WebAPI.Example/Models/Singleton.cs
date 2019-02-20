using DILite.Attributes;
using DILite.Attributes.Enums;
using DILite.WebAPI.Example.Interfaces;

namespace DILite.WebAPI.Example.Models
{
    [DIService(DIServiceLifeCycle.Singleton, DIServiceRegisterType.Interface)]
    public class Singleton : ISingleton
    {
        private readonly Greeter greeter;

        public Singleton(Greeter greeter)
        {
            this.greeter = greeter;
        }

        public void DoSomething()
        {
            greeter.Greet("Singleton");
        }
    }
}
