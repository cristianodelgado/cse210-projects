using System;

class Order
{
    private List<Product> _products; 
    private Customer _customer;
    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProducts(Product product){
        _products.Add(product);
    }
    public double GetTotalPrice(){
        double totalPrice = 0;
        foreach(Product product in _products)
        {
            totalPrice += product.GetPrice() * product.GetQuantity();
        }
        if(_customer.Address.IsFromUsa()){
           totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
    public string GetPackingLabel(){
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += $"Name:   {product.GetNameProduct()}, Product ID: {product.GetId()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel(){
        
        return $"Name: {_customer.GetName()}\nAddress: {_customer.Address.GetAddress()}";
    }
    



}