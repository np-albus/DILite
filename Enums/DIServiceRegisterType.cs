namespace DILite.Attributes.Enums
{
    public enum DIServiceRegisterType
    {
        Interface,
        Class
    }

    internal static class DIServiceRegisterTypeExtensions
    {
        public static bool IsInterface(this DIServiceRegisterType type) => type == DIServiceRegisterType.Interface;
        public static bool IsClass(this DIServiceRegisterType type) => type == DIServiceRegisterType.Class;
    }
}
