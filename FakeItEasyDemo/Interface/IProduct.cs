namespace FakeItEasyDemo;

public interface IProduct{}

public class Product
{
    public string Name { get;  set; }
    public string  Id { get; set; }

    
    public Product(string name, string id)
    {
        Name = name;
        Id = id;
    }
}