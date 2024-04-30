using System;

class Program
{static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Seller";
        job1._nameofCompany = "Optica";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Coach";
        job2._nameofCompany = "MacOnline";
        job2._startYear= 2021;
        job2._endYear = 2025;

        Resume myResume = new Resume ();
        myResume._name = "Benjamin Claros";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}