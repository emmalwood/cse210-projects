using System;

public class Journal

{
    private List<Entry> entries = new List<Entry>(); 

    // in python   list = []

    private List<string> prompts = new List<string>()
    {
        "What was the best part of your day?", 
        "What was the worst part of your day?",
        "How was the weather today?",
        "What happened in the news?",
        "Who did you interact with today?"
    };

    // in python   list = ["stuff", "stuff2"]

    public void NewEntry()
    {
        // python: prompts[0], prompts[0] 
        Random rnd = new Random();

        // python:   random.randint(0,4)
        string prompt =  prompts[rnd.Next(0,4)];

        Console.WriteLine(prompt);

        DateTime theCurrentTime = DateTime.Now;

        string Response = Console.ReadLine();

        string dateText = theCurrentTime.ToShortDateString();

        Entry entry = new Entry(dateText, prompt, Response);

        entries.Add(entry);

    }


    public void DisplayEntries() 
    {
        Console.WriteLine("Journal Entries");
        Console.WriteLine("                ");
        foreach (Entry entry in entries) 
        {
            entry.DisplayEntry();
        }
    }


    public void DisplayLastEntry() 
    {
        if (entries.Count > 0)
        {
            Console.WriteLine("Last Entry");
            Console.WriteLine("-----------------");
            entries[entries.Count - 1].DisplayEntry();
        } 
        else 
        {
            Console.WriteLine("No entries yet.");
        }
    }


}

