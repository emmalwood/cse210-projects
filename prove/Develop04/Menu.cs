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
