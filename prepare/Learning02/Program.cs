using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Alcatraz Escape Games";
        job1._jobTitle = "Shift Lead";
        job1._startYear = "2019";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._company = "Realities Edge Space Center";
        job2._jobTitle = "Second Chair";
        job2._startYear = "2018";
        job2._endYear = "2021";
    }
}