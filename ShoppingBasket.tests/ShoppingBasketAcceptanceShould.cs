using Moq;

namespace ShoppingBasket.tests;

public class ShoppingBasketAcceptanceShould
{
    [Fact]
    public void ReturnTheBillWhenAddingFiveDifferentProducts()
    {
        Mock<IPrinter> printer = new();
        var shoppingBasket = new ShoppingBasket(printer.Object, new ProductRepository(), new Cart());
        
        var expectedItems = """
--------------------------------------------
| Product name | Price with VAT | Quantity |
| -----------  | -------------- | -------- |
| Iceberg 🥬   | 2.17 €         | 1        |
| Tomato 🍅    | 0.73 €         | 1        |
| Chicken 🍗   | 1.83 €         | 1        |
| Bread 🍞     | 0.88 €         | 1        |
| Corn 🌽      | 1.50 €         | 1        |
|------------------------------------------|
| Promotion:                               |
--------------------------------------------
| Total products: 5                        |
| Total price: 7.11 €                      |
--------------------------------------------
""";
        
        shoppingBasket.AddItem("Iceberg 🥬");
        shoppingBasket.AddItem("Tomato 🍅");
        shoppingBasket.AddItem("Chicken 🍗");
        shoppingBasket.AddItem("Bread 🍞");
        shoppingBasket.AddItem("Corn 🌽");
        
        shoppingBasket.PrintShoppingCart();

        printer.Verify(_ => _.Print(expectedItems), Times.Once);
    }
}