namespace DILite.Attributes.Enums
{
    public enum DIServiceRegisterType
    {
        /// <summary>
        /// Register by interface name.
        /// 'I' prefix will be added automatically to the class name.
        /// </summary>
        Interface,
        /// <summary>
        /// Register by class name.
        /// </summary>
        Class
    }

    internal static class DIServiceRegisterTypeExtensions
    {
        public static bool IsInterface(this DIServiceRegisterType type) => type == DIServiceRegisterType.Interface;
        public static bool IsClass(this DIServiceRegisterType type) => type == DIServiceRegisterType.Class;
    }
}
