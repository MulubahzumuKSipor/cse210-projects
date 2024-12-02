using System;
using System.Collections.Generic;

class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetName()
    {
        return Name;
    }

    public string GetAddress()
    {
        return Address.FullAddress();
    }
}
