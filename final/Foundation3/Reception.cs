public class Reception : Event
        //inherit from event
    {
        public string RSVPEmail { get; private set; }

        public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
            : base(title, description, date, address)
        {
            RSVPEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}Type: Reception\nRSVP Email: {RSVPEmail}\n";
        }
    }