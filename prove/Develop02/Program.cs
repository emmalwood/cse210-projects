using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        bool run = true; 
        while(run)

        { //brackets are most important
          Console.WriteLine("Choose an option: \n 1.Write \n 2.Display \n 3.Load \n 4.Save \n 5.Quit");

            switch(int.Parse(Console.ReadLine()))
            // c#: Console.ReadLine(),    python: input()

            // int() = int.Parse()
            //switch = if, case = then
            {
                case 1:
                    journal.NewEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Load Journal...");
                    break;
                case 4:
                    Console.WriteLine("Save Journal...");
                    break;
                case 5:
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }   

        } 

      
    }
}