using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2003;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "UX design";
        job2._startYear = 2003;
        job2._endYear = 2010;

        Job job3 = new Job();
        job3._company = "Facebook/Meta";
        job3._jobTitle = "React Developer";
        job3._startYear = 2011;
        job3._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Diego Bravo A.";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);


        myResume.Display();


    }
}