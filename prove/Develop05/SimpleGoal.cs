class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value)
        : base(name, description, value) { }

    // save simple goal to file
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("SimpleGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Completed);
    }

    // loads simple goal from file
    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Completed = bool.Parse(reader.ReadLine());
    }
}