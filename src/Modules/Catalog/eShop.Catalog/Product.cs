using eShop.SharedKernel;

namespace eShop.Catalog.Domain;

public class Product : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
