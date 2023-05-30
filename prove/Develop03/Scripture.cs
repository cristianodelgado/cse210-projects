using System;
using System.Collections.Generic;
public class Scripture
{
    public Reference Reference;
    private string _text;
    
    public List<Words> _words;
    private List<int> hiddenWord;
    
    

    public Scripture(Reference reference, string text)
    {

        Reference = reference;
        _text = text;
        _words = new List<Words>();

        string [] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            Words word = new Words(words[i], i);
            _words.Add(word);
        }
        hiddenWord = new List<int>();

    }
    public void HideWords()
    {
        List<int> availableWordIndices = Enumerable.Range(0, _words.Count).ToList();
        List<int> indicesToHide = new List<int>();

        Random random = new Random();

        
        for (int i = 0; i <= 2; i++)
        {
            
            int randomIndex = random.Next(0, availableWordIndices.Count);
            int wordIndex = availableWordIndices[randomIndex];
            indicesToHide.Add(wordIndex);
            availableWordIndices.RemoveAt(randomIndex);
            
        }

        foreach (int index in indicesToHide)
        {
            _words[index].Hide();
            hiddenWord.Add(index);
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWord.Count == _words.Count;
    }

    public void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine($"{Reference.getReference()} -");

        foreach (var word in _words)
        {
            if (hiddenWord.Contains(word.Index))
            {
                Console.Write("- ");
                
            }
            else
            {
                Console.Write(word + " ");
            }
        }

        Console.WriteLine();
    }
    
}
