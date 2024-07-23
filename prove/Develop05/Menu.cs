class Menu
{
    private string[] menuItems =
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };


    //display the menu and process user input
    public bool ChooseAndRun(GoalManager goalManager)
    {
        // show menu options and points
        Console.WriteLine($"\nYou currently have {goalManager.GetUserScore()} points \nMenu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }

        // read user input
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                goalManager.CreateGoal();
                break;
            case 2:
                goalManager.ShowGoals();
                break;
            case 3:
                goalManager.SaveData();
                break;
            case 4:
                goalManager.LoadData();
                break;
            case 5:
                goalManager.RecordEvent();
                break;
            case 6:
                Console.WriteLine("Quitting...");
                return false;
            default:
                Console.WriteLine("Invalid option!!! Please try again.");
                break;
        }
        return true;
    }
}