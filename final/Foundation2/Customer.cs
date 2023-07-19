using System;

class Customer
{
    private string _name;
    private Address _address;
    
    
    
    public string GetName()
    {
        return _name;
    }
    public Address Address
    {
        get {return _address; }
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}