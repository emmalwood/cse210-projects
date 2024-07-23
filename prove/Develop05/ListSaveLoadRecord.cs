class GoalManager
{
    private List<Goal> goals;
    private int userScore;

    //initialize the goal manager
    public GoalManager()
    {
        goals = new List<Goal>();
        userScore = 0;
    }



    // create a new goal based on user input
    public void CreateGoal()
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



    // records an event for a selected goal and return the points earned
    public int RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            int points = goals[choice].Complete();
            Console.WriteLine($"Recorded event for {goals[choice].Name}. You gained {points} points.");
            userScore += points;
            return points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return 0;
        }
    }


    // displays the list of goals
    public void ShowGoals()
    {
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }

    // save goals and user's score to a file
    public void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(userScore);
            foreach (var goal in goals)
            {
                goal.Save(writer);
            }
        }
        Console.WriteLine("Data saved.");
    }

    // load goals and user's score from a file
    public void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                userScore = int.Parse(reader.ReadLine());
                goals.Clear();
                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    Goal goal = null;
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal("", "", 0);
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal("", "", 0, 0, 0);
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal("", "", 0);
                            break;
                    }
                    goal.Load(reader);
                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Data loaded.");
    }

    // return current user score
    public int GetUserScore()
    {
        return userScore;
    }
}