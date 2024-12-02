using System;
using System.Collections.Generic;

class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Trim().ToLower() == "usa";
    }

    public string FullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}