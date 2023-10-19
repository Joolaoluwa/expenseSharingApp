using System;

namespace expenseSharingProject;

public class Person : IPerson
{
    public string? FirstName()
    {
        Console.WriteLine("Please What is your first name: ");
        return Console.ReadLine();
    }

    public string? LastName()
    {
        Console.WriteLine("Please What is your last name: ");
        return Console.ReadLine();
    }

    public virtual string? Password()
    {
        Console.WriteLine("Please input a password: ");
        return Console.ReadLine();
    }

    public virtual string? FullName()
    {
        return $"{FirstName()} {LastName()}";
    }
}

