using System;
using System.Collections.Generic;
public class Words
{
    private string _text;
    public bool _hidden;

    public Words(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

}