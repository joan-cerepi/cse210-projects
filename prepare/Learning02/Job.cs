using System;

public class Job
{
    // Initialize member variables.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Display all the above data after it has been added to an object.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}