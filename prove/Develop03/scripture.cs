using System;
using System.Collections.Generic;

public class Scripture
{
    // Private the list of Verse objects
    private List<Verse> verses;


    // Constructor for a single verse scripture
    public Scripture(string book, int chapter, int startVerse, string verseText)
    {
        verses = new List<Verse>
        {
            new Verse(verseText)
        };
    }

    // Constructor for multiple verses scripture
    public Scripture(string book, int chapter, int startVerse, int endVerse, string[] verseTexts)
    {
        verses = new List<Verse>();
        // Add each verse text as a Verse object to the list
        foreach (var verseText in verseTexts)
        {
            verses.Add(new Verse(verseText));
        }
    }

    // Method to get the entire scripture text
    public string GetScripture()
    {
        var scriptureText = "";
        // Concatenate the verses, adding new lines between them
        foreach (var verse in verses)
        {
            scriptureText += verse.GetVerse() + "\n";
        }
        return scriptureText.Trim(); // Remove the trailing newline
    }

    // Method to hide random words in each verse
    public void HideRandomWords()
    {
        foreach (var verse in verses)
        {
            verse.HideRandomWords();
        }
    }

    // Method to check if all verses are completely hidden
    public bool IsCompletelyHidden()
    {
        foreach (var verse in verses)
        {
            if (!verse.IsCompletelyHidden())
            {
                return false; // Return false if any verse is not completely hidden
            }
        }
        return true; // Return true if all verses are completely hidden
    }
}
