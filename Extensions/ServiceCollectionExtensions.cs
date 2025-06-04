using Microsoft.Extensions.DependencyInjection;

namespace BlazorQueryBuilder.Extensions
{
    /// <summary>
    /// Extension methods for configuring Blazor QueryBuilder services
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Blazor QueryBuilder services to the service collection
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <returns>The service collection for chaining</returns>
        public static IServiceCollection AddBlazorQueryBuilder(this IServiceCollection services)
        {
            // Currently no services to register, but this provides extensibility
            return services;
        }
    }
}