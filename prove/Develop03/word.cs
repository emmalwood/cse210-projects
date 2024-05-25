using System;

public class Word
{
    private string text;
    private bool hidden;

    
    //words are not hidden at default
    public Word(string word)
    {
        text = word;
        hidden = false;
    }



    //sees if word is set as hidden and if so replaces it with "____"
    public string GetWord()
    {
        return hidden ? "____" : text;
    }



    //Hiding word stuff
    public void HideWord()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }
}
