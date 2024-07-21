class Swimming : Activity
        //child
    {
        private int laps;

        public Swimming(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (laps * 50) / 1000.0 * 0.62; // Convert to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }
    }

   