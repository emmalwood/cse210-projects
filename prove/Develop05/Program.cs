class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;

    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool running = true;

        //loop to display the menu and process user input
        while (running)
        {
            running = Menu.ChooseAndRun(userScore, goals);
        }
    }




    //create a new goal based on user input
    public static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, value));
                break;
            case "2":
                Console.Write("Enter times for completion: ");
                int timesForCompletion = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus value: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, value, timesForCompletion, bonus));
                break;
            case "3":
                goals.Add(new EternalGoal(name, description, value));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}