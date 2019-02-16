using System;
using DILite.Attributes.Enums;

namespace DILite.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class DIServiceAttribute : Attribute
    {
        public DIServiceLifeCycle LifeCycle { get; }
        public DIServiceRegisterType RegisterType { get; }

        public DIServiceAttribute(DIServiceLifeCycle lifeCycle, DIServiceRegisterType registerType)
        {
            this.LifeCycle = lifeCycle;
            this.RegisterType = registerType;
        }
    }
}
