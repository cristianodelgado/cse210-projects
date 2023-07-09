using System;

public class Product
{
    private string _nameProduct;
    private int _id;
    private int _quantity;
    private double _price;

    public Product(string nameProduct, int id, int quantity, double price){
        _nameProduct = nameProduct;
        _id = id;
        _quantity = quantity;
        _price = price;
    }
    public string GetNameProduct(){
        return _nameProduct;
    }
    public int GetId(){
        return _id;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public double GetPrice(){
        return _price;
    }

}