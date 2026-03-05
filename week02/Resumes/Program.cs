using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2019;
        job1._endYear = 2024;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2012;
        job2._endYear = 2018;
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._personName = "Bob Dobbs";
        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);

        resume1.DisplayResume();
    }
}