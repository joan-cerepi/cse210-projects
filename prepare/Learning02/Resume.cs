using System;
using System.Collections.Generic;

public class Resume
{
    // Initialize member variables.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job object inside the jobs list.
        foreach (Job job in _jobs)
        {
            // Call the Display method on each job object.
            job.Display();
        }
    }
}