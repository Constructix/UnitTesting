namespace FakeItEasyDemo;

public class SupplierTests
{
    [Fact]
    public void GetTopSellingProduct()
    {
        var deckingProduct = A.Fake<Product>(x=>x.WithArgumentsForConstructor(()=> new Product("First", "12234")));
        var supplier = A.Fake<ISupplier>();
        A.CallTo(()=> supplier.GetTopSellingProduct()).Returns(deckingProduct);
        var selectedProduct = supplier.GetTopSellingProduct();
        A.CallTo(()=> supplier.GetTopSellingProduct()).MustHaveHappened();
        deckingProduct.Name.Should().Be("First");
    }
}