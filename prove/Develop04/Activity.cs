using System;

abstract class Activity
{
    public virtual void Loading(int seconds = 3, int speed = 200) 
        {
        string[] spinner = { "|", "/", "-", "\\" }; 
        int runTime = seconds * 1000; //seconds to milliseconds
        while (runTime > 0) 
            {
            for (int i = 0; i < 3; i++) 
                {
                Console.Write(spinner[i]); //display spinner
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); //move cursor
                System.Threading.Thread.Sleep(speed);
                runTime -= speed; //decrease remaining runtime by speed
                Console.Write(" "); //clear spinner
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); //move cursor
                }
            }
    
        public abstract void Run();

        public virtual void Sleep(int seconds = 3) 
            {
            System.Threading.Thread.Sleep(seconds * 1000);
            }
        }
}

