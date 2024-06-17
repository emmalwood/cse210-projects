using System;
using System.Collections;

class Entry 
    {
    private string Response = "";

    private string Prompt = "";

    private string Date = "";
    
    public Entry(string date, string prompt, string content)
     {
        this.Date = date;
        this.Prompt = prompt;
        this.Response = content;
     }

    public void DisplayEntry()
        {
            Console.WriteLine($"{this.Prompt} [{Date}]\n{this.Response}\n");   
        }

}





