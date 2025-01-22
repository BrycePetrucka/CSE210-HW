using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Hollywood Feed";
        job1._endYear = 2024;
        job1._startYear = 2022;
        job1._jobTitle = "Sales associate";

        Job job2 = new Job();
        job2._company = "AVALan Wireless";
        job2._endYear = 2020;
        job2._startYear = 2019;
        job2._jobTitle = "Floor Worker";

        Resume yourResume = new Resume();
        yourResume._name = "Bryce Petrucka";
        yourResume._jobs.Add(job1);
        yourResume._jobs.Add(job2);

        yourResume.DisplayResume();

    }
}