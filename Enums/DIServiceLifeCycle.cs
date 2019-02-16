namespace DILite.Attributes.Enums
{
    public enum DIServiceLifeCycle
    {
        Transient,
        Scoped,
        Singleton
    }

    internal static class DIServiceLifeCycleExtensions
    {
        public static bool IsTransient(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Transient;
        public static bool IsScoped(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Scoped;
        public static bool IsSingleton(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Singleton;
    }
}
