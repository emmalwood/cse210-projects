using System;

class ReflectingActivity : Activity
{
     public override void Run()
    {
        // Print a message to the console indicating that the Breathing activity is running
        Console.WriteLine("Running Reflecting Activity");

        // Call the Loading method of the current instance
        this.Loading();
    }

}