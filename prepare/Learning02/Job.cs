using System;

public class Job
{ 

    public string __jobTitle;

    public string _company;

    public string _startYear;

    public string _endYear;

    public void Display()

    {
        Console.WriteLine($"{__jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}