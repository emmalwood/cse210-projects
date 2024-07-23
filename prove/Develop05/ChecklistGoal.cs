class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TimesForCompletion { get; set; }
    public int Bonus { get; set; }

    // initialize checklist goal
    public ChecklistGoal(string name, string description, int value, int timesForCompletion, int bonus)
        : base(name, description, value)
    {
        TimesForCompletion = timesForCompletion;
        TimesCompleted = 0;
        Bonus = bonus;
    }

    // displays checklist goal details
    public override void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description}: {Value} points, Completed {TimesCompleted}/{TimesForCompletion} times");
    }

    // save checklist goal to file
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("ChecklistGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Completed);
        writer.WriteLine(TimesCompleted);
        writer.WriteLine(TimesForCompletion);
        writer.WriteLine(Bonus);
    }

    // Load the checklist goal from file
    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Completed = bool.Parse(reader.ReadLine());
        TimesCompleted = int.Parse(reader.ReadLine());
        TimesForCompletion = int.Parse(reader.ReadLine());
        Bonus = int.Parse(reader.ReadLine());
    }

    // Complete the checklist goal and return its value or bonus if fully completed
    public override int Complete()
    {
        TimesCompleted++;
        if (TimesCompleted >= TimesForCompletion)
        {
            Completed = true;
            return Value + Bonus;
        }
        return Value;
    }
}
