using Moq;

namespace ShoppingBasket.tests;

public class ShoppingBasketTest

/*
 *--------------------------------------------
| Product name | Price with VAT | Quantity |
| -----------  | -------------- | -------- |
| Iceberg 🥬   | 2.17 €         | 1        |
| Tomatoe 🍅   | 0.73 €         | 1        |
| Chicken 🍗   | 1.83 €         | 1        |
| Bread 🍞     | 0.88 €         | 1        |
| Corn 🌽      | 1.50 €         | 1        |
|------------------------------------------|
| Promotion:                               |
--------------------------------------------
| Total productos: 5                       |
| Total price: 7.11 €                      |
--------------------------------------------
 * 
 */

{
    [Fact]
    public void ShouldReturnTheBillWhenAddingFiveDifferentProducts()
    {
        var iceberg = new Product("Iceberg 🥬");
        var tomato = new Product("Tomato 🍅");
        var chicken = new Product("Chicken 🍗");
        var bread = new Product("Bread 🍞");
        var corn = new Product("Corn 🌽");
        Mock<IPrinter> printer = new();
        var expectedItems = """
--------------------------------------------
| Product name | Price with VAT | Quantity |
| -----------  | -------------- | -------- |
| Iceberg 🥬   | 2.17 €         | 1        |
| Tomatoe 🍅   | 0.73 €         | 1        |
| Chicken 🍗   | 1.83 €         | 1        |
| Bread 🍞     | 0.88 €         | 1        |
| Corn 🌽      | 1.50 €         | 1        |
|------------------------------------------|
| Promotion:                               |
--------------------------------------------
| Total productos: 5                       |
| Total price: 7.11 €                      |
--------------------------------------------
""";
        
        var shoppingBasket = new ShoppingBasket(printer.Object);
        shoppingBasket.AddItem(iceberg);
        shoppingBasket.AddItem(tomato);
        shoppingBasket.AddItem(chicken);
        shoppingBasket.AddItem(bread);
        shoppingBasket.AddItem(corn);

        printer.Setup(_ => _.Print(expectedItems)).Verifiable();
        
        shoppingBasket.PrintShoppingCart();

        printer.Verify(_ => _.Print(expectedItems), Times.Once);
    }
}