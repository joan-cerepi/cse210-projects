using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private string _updatedText;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _updatedText = text;
        AddWords();
    }

    private void AddWords()
    {
        string[] text = _text.Split();
        _words = text.Select(word => new Word(word)).ToList();
    }

    public void HideWords()
    {
        Random randomGenerator = new Random();
        int wordIndex;
        do
        {
            wordIndex = randomGenerator.Next(0, _words.Count); 
        } while (_words[wordIndex].GetVisibility());
        _words[wordIndex].HideWord();
    }

    public void UpdateText()
    {
        List<string> updatedWords = _words.Select(word => word.GetText()).ToList();
        _updatedText = string.Join(" ", updatedWords);
    }

    public void Display()
    {
        string reference = _reference.GetString();
        Console.WriteLine($"{reference} {_updatedText}");
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.GetVisibility());
    }
}