using FluentAssertions;
using ShoppingBasket.tests.utils;

namespace ShoppingBasket.tests;

public class ProductRepositoryShould
{
    [Fact]
    public void GetExistingProductByName()
    {
        var productRepository = new ProductRepository();
        var productName = "Chicken 🍗";

        var product = productRepository.GetProductBy(productName);

        var something = MockProduct.GetChicken();
        product.Should().BeEquivalentTo(something);
    }
    
    [Fact]
    public void DontGetNonExistingProductByName()
    {
        var productRepository = new ProductRepository();
        var productName = "Chicken 🦢";

        var product = productRepository.GetProductBy(productName);

        product.Should().BeNull();
    }
}