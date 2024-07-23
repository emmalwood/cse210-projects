class EternalGoal : Goal
{
    public int Streak { get; set; }

    // Constructor to initialize eternal goal
    public EternalGoal(string name, string description, int value)
        : base(name, description, value)
    {
        Streak = 0;
    }

    // Save the eternal goal to file
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("EternalGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Completed); // This might not be necessary for EternalGoal
        writer.WriteLine(Streak);
    }

    // Load the eternal goal from file
    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Completed = bool.Parse(reader.ReadLine()); // This might not be necessary for EternalGoal
        Streak = int.Parse(reader.ReadLine());
    }

    // Complete the eternal goal and return its value
    public override int Complete()
    {
        Streak++;
        return Value;
    }
}