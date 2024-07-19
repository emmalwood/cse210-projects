public abstract class Event
        //base class
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public Address Address { get; private set; }

        protected Event(string title, string description, DateTime date, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nAddress: {Address}\n";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}\n";
        }
    }


 public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} {ZipCode}";
        }
    }
