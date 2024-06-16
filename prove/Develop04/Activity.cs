using System;

class Menu
{
    public void MenuOptions()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        Console.WriteLine("Menu Option:\n 1.Start breathing activity \n 2.Start reflecting activity \n 3.Start listing activity \n 4.Quit");

        Console.WriteLine("Please select a menu option: \n ");
        
        string choice = Console.ReadLine();

            if (choice == "1")
                {
                    //Menu.Breathing Activity
                    //call from breathing.cs
                }
            else if (choice == "2")
                {
                    //Menu.ReflectingActivity
                    //call from reflecting.cs
                }
            else if (choice == "3")
                {
                    //Menu.ListingActivity
                    //call from listing.cs
                }
            else if (choice =="4")
                {
                    //exit program
                }
            else
                {
                    Console.WriteLine("Invalid choice");
                }
        }
}


abstract class Activity
{
        
    public virtual void Loading(int seconds = 3, int speed = 200) 
        {
        string[] spinner = { "|", "/", "-", "\\" }; 
        int runTime = seconds * 1000; //seconds to milliseconds
        while (runTime > 0) 
            {
            for (int i = 0; i < 3; i++) 
                {
                Console.Write(spinner[i]); //display spinner
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back one position
                System.Threading.Thread.Sleep(speed);
                runTime -= speed; //decrease remaining runtime by speed
                Console.Write(" "); //clear spinner
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back one position
                }
            }
    
        public abstract void Run();

        public virtual void Sleep(int seconds = 3) 
            {
            System.Threading.Thread.Sleep(seconds * 1000); // Convert seconds to milliseconds and pause the execution
            }
        }
}

