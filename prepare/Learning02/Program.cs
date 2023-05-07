using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Bulonera Camba SRL";
        job1._jobTitle = "Administrativo";
        job1._startYear = 2014;
        job1._endYear = 2021;
        job1.DisplayJob();
    
    
        Job job2 = new Job();
        job2._company = "Degma SRL";
        job2._jobTitle = "Comprador";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.DisplayJob();

        
        Resume myResume = new Resume();
        myResume._name = "Cristian Delgado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        

        Console.WriteLine();
        myResume.Display();

    
    }
}