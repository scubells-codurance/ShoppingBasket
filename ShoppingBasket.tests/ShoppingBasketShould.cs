using Moq;

namespace ShoppingBasket.tests;

public class ShoppingBasketShould
{
    [Fact]
    public void AddOneProduct()
    {
        Mock<IProductRepository> productRepository = new();
        Mock<ICart> cart = new();
        var shoppingBasket = new ShoppingBasket(new Printer(), productRepository.Object, cart.Object);
        var productName = "something 😇";
        var product = new Product(productName, 1.55f, 15, new Tax("normal", 21));
        productRepository.Setup(_ => _.GetProductBy(productName))
            .Returns(product);
        
        shoppingBasket.AddItem(productName);
        
        cart.Verify(_ => _.AddProduct(product), Times.Once());
    }
}