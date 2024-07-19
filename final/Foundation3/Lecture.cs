 public class Lecture : Event
            //inherit from event
    {
        public string Speaker { get; private set; }
        public int Capacity { get; private set; }

        public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity)
            : base(title, description, date, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}\n";
        }
    }