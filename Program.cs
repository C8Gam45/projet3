using System;

namespace projet3;

public class Customer
{
    private string? firstName;
    private string? lastName;
    private string? email;

    public string? FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string? LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string? Email
    {
        get { return email; }
        set { email = value; }
    }
}
public class Item
{
    private string? name;
    private float price;
    private int quantity;

    public string? Name
    {
        get { return name; }
        set { name = value; }
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.FirstName = "Alice";
        customer.LastName = "Martin";
        customer.Email = "alice@email.com";

        Console.WriteLine("Prénom : " + customer.FirstName);
        Console.WriteLine("Nom : " + customer.LastName);
        Console.WriteLine("Email : " + customer.Email);

        Item item = new Item();
        item.Name = "Smartphone";
        item.Price = 800;
        item.Quantity = 25;

        Console.WriteLine("Nom : " + item.Name);
        Console.WriteLine("Prix : " + item.Price);
        Console.WriteLine("Quantité : " + item.Quantity);

        Supplier supplier = new Supplier();
        supplier.Name = "TechSupply";
        supplier.City = "Paris";
        supplier.Phone = "0102030405";

        Console.WriteLine("Nom du fournisseur : " + supplier.Name);
        Console.WriteLine("Ville : " + supplier.City);
        Console.WriteLine("Téléphone : " + supplier.Phone);

        Category category1 = new Category();
        category1.Name = "Electronics";
        category1.Description = "Electronic devices";

        Category category2 = new Category();
        category2.Name = "Books";
        category2.Description = "Books and literature";

        Category category3 = new Category();
        category3.Name = "Clothing";
        category3.Description = "Clothes and accessories";

        Console.WriteLine("Nom : " + category1.Name);
        Console.WriteLine("Description : " + category1.Description);
        Console.WriteLine("Nom : " + category2.Name);
        Console.WriteLine("Description : " + category2.Description);
        Console.WriteLine("Nom : " + category3.Name);
        Console.WriteLine("Description : " + category3.Description);
    }
}
