using System;
using System.Collections.Generic;
public class Scripture
{
    public Reference Reference;
    private string _text;
    
    public List<Words> _words;
    
    

    public Scripture(Reference reference, string text)
    {

        Reference = reference;
        _text = text;
        _words = new List<Words>();

        string [] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Words(word));
        }

    }
    public void HideRandomWord()
    {
        Random _randomWord = new Random();
        int _random;
        do
        {
            _random = _randomWord.Next(_words.Count);

        }
        while (_words[_random]._hidden);
        _words[_random].Hide();
    }
    
    public void ShowScripture()
    {
        Console.WriteLine($"{Reference}-{_text}");
    }

}
