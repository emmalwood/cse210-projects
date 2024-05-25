using System;
using System.Collections.Generic;

public class Verse
{
    // Private to store the list of Word objects
    private List<Word> words;

    //giving verse a string of scripture
    public Verse(string scripture)
    {
        words = new List<Word>();

        //splitting scripture into singular words and making Word object things
        foreach (var word in scripture.Split(' '))
        {
            words.Add(new Word(word));
        }
    }


    // Method to get the text of the verse, with hidden words as "____"
    public string GetVerse()
    {
        var verseText = "";
        foreach (var word in words)
        //put spaces between words
        {
            verseText += word.GetWord() + " ";
        }
        return verseText.Trim();
        //get rid of extra spaces
    }



    //hide random words in verse
    public void HideRandomWords()
    {
        var rand = new Random();
        int index = rand.Next(words.Count);
        //find word not already hidden
        while (words[index].IsHidden())
        {
            index = rand.Next(words.Count);
        }
        words[index].HideWord();
    }


    //checks if all words are hidden!
    public bool IsCompletelyHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
