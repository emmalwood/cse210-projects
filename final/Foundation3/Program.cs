class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("100 Weesnaw Dr", "Nashville", "TN", "10109");
            Address address2 = new Address("222 Dogwood St", "Townsville", "NY", "70001");
            Address address3 = new Address("007 Secret St", "Bondtown", "IL", "60801");

            Event lecture = new Lecture("How to Be Cool", "A talk on the latest social manipulation skills.", new DateTime(2027, 8, 1, 18, 0, 0), address1, "James Bond", 100);
            Event reception = new Reception("Royal Wedding", "An event celebrating the marriage of Mrs.Piggy and Kermit.", new DateTime(2026, 6, 5, 19, 0, 0), address2, "rsvp@Muppets.com");
            Event outdoorGathering = new OutdoorGathering("National Freeze-Tag Tournament", "The national tournament of the game Freeze-Tag along with live music, food, and vendors.", new DateTime(2025, 8, 17, 14, 0, 0), address3, "Sunny with light breezes.");

            Event[] events = { lecture, reception, outdoorGathering };

            foreach (var ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine("Full Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine("-------------");
            }
        }
    }
