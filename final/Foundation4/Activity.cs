abstract class Activity
     //base class
    {
        private DateTime date;
        private int minutes;

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public DateTime Date => date;
        public int Minutes => minutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();


        public string GetSummary()
            //time and math is dumb >:(
        {
            return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Minutes} min): " +
                   $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} minutes per mile";
        }
    }