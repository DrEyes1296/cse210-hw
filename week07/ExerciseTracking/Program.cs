using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Running run1 = new Running("03 Nov 2022", 30, 3.0); // 3 miles in 30 minutes
        Cycling cycle1 = new Cycling("03 Nov 2022", 40, 12.0); // 12 mph for 40 min
        Swimming swim1 = new Swimming("03 Nov 2022", 30, 20); // 20 laps in 30 minutes

        // Store all activities in a list
        List<Activity> activities = new List<Activity> { run1, cycle1, swim1 };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
