using MyFinancialHub.Application.CQRS.Handlers.Dispatchers;

namespace MyFinancialHub.Application.CQRS
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCqrs(this IServiceCollection services)
        {
            return services
                .AddScoped<IDispatcher, Dispatcher>()
                .AddHandlers();
        }

        private static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            return services;
        }
    }
}
