using System;

public class Word
{
    private string _visibleText;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string wordText)
    {
        _visibleText = wordText;
        _hiddenText = "";
        _isHidden = false;
    }

    public void HideWord()
    {
        int charCount = _visibleText.Length;
        _hiddenText = new string('_', charCount);
        _isHidden = true;
    }

    public string GetText()
    {
        return _isHidden ? _hiddenText : _visibleText;
    }

    public bool GetVisibility()
    {
        return _isHidden;
    }
}