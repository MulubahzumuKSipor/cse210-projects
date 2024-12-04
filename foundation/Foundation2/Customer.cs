using System;
using System.Collections.Generic;

class Customer
{
    private string UserName;
    private Address ClientAddress;

    public Customer(string _userName, Address _userAddress)
    {
        UserName = _userName;
        ClientAddress = _userAddress;
    }

    public bool LivesIn()
    {
        return ClientAddress.IsIn();
    }

    public string GetName()
    {
        return UserName;
    }

    public string GetAddress()
    {
        return ClientAddress.ClientsFullAddress();
    }
}
