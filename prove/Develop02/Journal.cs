using System;

public class Journal

{
    private List<Entry> entries = new List<Entry>(); 

    // in python   list = []

    private List<string> prompts = new List<string>()
    {
        "What was the best part of my day?", 
        "What was the worst part of my day?",
        "How was the weather today?",
        "What happened in the news?",
        "Who did I interact with today?",
        "How did I see the Lord's hand in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do over one thing I did today, what would it be?",
        "What do I hope to do tomorrow?"
    };

    // in python   list = ["stuff", "stuff2"]

    public void NewEntry()
    {
        // python: prompts[0], prompts[0] 
        Random rnd = new Random();

        // python:   random.randint(0,8)
        string prompt =  prompts[rnd.Next(0,8)];

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

