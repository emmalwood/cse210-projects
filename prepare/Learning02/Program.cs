using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1.__jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2011;
        job1._endYear = 2013;

        Job job2 = new Job();

        job2.__jobTitle = "Electrical Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2014;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "John Egbert";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}