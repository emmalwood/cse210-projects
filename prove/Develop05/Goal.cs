
abstract class Goal
{
    //goal base
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

        //initializes goals
        public Goal(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
            Completed = false;
        }
        
        //goal details
        public virtual void Display()
        {
            string status = Completed ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {Name} - {Description}: {Value} points");
        }
    public abstract void Save(StreamWriter writer);
    public abstract void Load(StreamReader reader);

    //for when goal is complete
    public virtual int Complete()
    {
        Completed = true;
        return Value;
    }
}