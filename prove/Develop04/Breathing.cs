using System;

class BreathingActivity : Activity
{
     public override void Run()
    {
        // Print a message to the console indicating that the Breathing activity is running
        Console.WriteLine("Running Breathing Activity");

        // Call the Loading method of the current instance
        this.Loading();
    }
    //Activty Description "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."

    //int Time "How long would you like this activty to be in seconds?"

    //clear screen

    //"Get Ready"
    //animation spinner

    //clear screen

    //"Breath in...(countdown from 3)
    //Breathe out.. (countdown from 3)
    //repeat until time is up

    //clearscreen

    //"Well done! \n You've completed (Time) seconds of the Breathing Activity"

    //animation spinner

    //clear screen

    //take back to menu


}
