using System;

public class Fraction
{
    private int _numerador;
    private int _denominador;

    public Fraction()
    {
        _numerador = 1;
        _denominador = 1;

    }

    public Fraction(int numerador)
    {

        _numerador = numerador;
        _denominador = 1;

    }
    public Fraction(int numerador, int denominador)
    {

        _numerador = numerador;
        _denominador = denominador;

    }

   

    public string getFractionString()
    {
        return $"{_numerador}/{_denominador}";
    }

    public double getDecimalValue()
    {

        return (double)_numerador / (double)_denominador;
    }


}