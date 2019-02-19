namespace DILite.Attributes.Enums
{
    public enum DIServiceLifeCycle
    {
        /// <summary>
        /// Transient lifetime services are created each time they're requested.
        /// This lifetime works best for lightweight, stateless services.
        /// </summary>
        Transient,
        /// <summary>
        /// Scoped lifetime services are created once per request.
        /// </summary>
        Scoped,
        /// <summary>
        /// Singleton lifetime services are created the first time they're requested
        /// (or when ConfigureServices is run and an instance is specified with the service registration). 
        /// </summary>
        Singleton
    }

    internal static class DIServiceLifeCycleExtensions
    {
        public static bool IsTransient(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Transient;
        public static bool IsScoped(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Scoped;
        public static bool IsSingleton(this DIServiceLifeCycle type) => type == DIServiceLifeCycle.Singleton;
    }
}
