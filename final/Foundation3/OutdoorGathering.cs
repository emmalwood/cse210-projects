public class OutdoorGathering : Event
        //inherit from event
    {
        public string WeatherForecast { get; private set; }

        public OutdoorGathering(string title, string description, DateTime date, Address address, string weatherForecast)
            : base(title, description, date, address)
        {
            WeatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}\n";
        }
    }