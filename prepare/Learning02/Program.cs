using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Back-end Developer";
        job1._nameCompany = "Microsoft";
        job1._initialYear = 2014;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Back-end Developer";
        job2._nameCompany = "TechCompany";
        job2._initialYear = 2013;
        job2._endYear = 2014;


        
      Resume my_Resume = new Resume();
      my_Resume._name = "Rafael Antunes";

      my_Resume._jobs.Add(job1);
       my_Resume._jobs.Add(job2);

      my_Resume.Display();


    }

    

      
}