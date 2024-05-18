using System;
using System.Collections;

public class Entry 
    {
    private string Response = "";

    private string Prompt = "";

    private DateTime Date;
    
    public void DisplayEntry()
        {
            Console.WriteLine($"{this.Prompt} [{Date}]\n{this.Response}\n");   
        }

}





