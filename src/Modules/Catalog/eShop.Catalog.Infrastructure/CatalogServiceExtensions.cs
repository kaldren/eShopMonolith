using eShop.Catalog.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Catalog.Infrastructure;

public static class CatalogServiceExtensions
{
    public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services)
    {
        // Add db context, repositories, and other services related to the Catalog module.
        // Example: services.AddDbContext<CatalogDbContext>(options => ...);
        services.AddDbContext<CatalogDbContext>(x => x.UseSqlServer("Server=localhost;Database=eShop;Trusted_Connection=True;TrustServerCertificate=True;"));
        return services;
    }
}
