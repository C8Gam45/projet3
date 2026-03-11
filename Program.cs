using System;

namespace projet3;

public class Customer
{
    private string firstName;
    private string lastName;
    private string email;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
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
    }
}
