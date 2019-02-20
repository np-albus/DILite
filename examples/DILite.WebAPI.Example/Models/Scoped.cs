using DILite.Attributes;
using DILite.Attributes.Enums;
using DILite.WebAPI.Example.Interfaces;

namespace DILite.WebAPI.Example.Models
{
    [DIService(DIServiceLifeCycle.Scoped, DIServiceRegisterType.Interface)]
    public class Scoped : IScoped
    {
        private readonly Greeter greeter;

        public Scoped(Greeter greeter)
        {
            this.greeter = greeter;
        }

        public void DoSomething()
        {
            greeter.Greet("Scoped");
        }
    }
}
