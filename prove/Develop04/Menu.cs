using System;

class Menu
{   
    private string[] menuItems = 
    {
    "1.Start breathing activity", 
    "2.Start reflecting activity", 
    "3.Start listing activity",
    "4.Quit"
    }; 
      
    public bool MenuOptions()
    {
        Console.WriteLine("\n Menu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    BreathingActivity.Run();
                    break;
                case 2:
                    //Reflecting reflecting = new Reflecting();
                    //reflecting.Run();
                    break;
                case 3:
                    //Listing listing = new Listing();
                    //listing.Run();
                    break;
                case 4:
                    Console.WriteLine("Quitting now...");
                    return false;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
                }
        return true;
        }
}
