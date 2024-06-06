using System;
using System.Collections.Generic;
using FitnessCenter;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of activities
            List<Activity> activities = new List<Activity>();

            // Add some activities to the list
            activities.Add(new Running(new DateTime(2024, 03, 3), 54, 6.2));
            activities.Add(new Cycling(new DateTime(2024, 01, 27), 156, 72));
            activities.Add(new Swimming(new DateTime(2024, 04, 21), 76, 10));

            // Display the summary of each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}