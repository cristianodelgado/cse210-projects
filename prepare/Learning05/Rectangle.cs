using System;

public class Rectangle : Shape
{
    private double _leng;
    private double _width;
    public Rectangle(string color, double lenght, double width) : base (color){
        _leng = lenght;
        _width = width;
   }

    public override double GetArea(){
        return _leng * _width;
    
   }
   
}