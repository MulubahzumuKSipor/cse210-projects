using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs newJobs = new Jobs();
        newJobs._companyName = "Sipor's Sweats";
        newJobs._jobTitle = "CEO";
        newJobs._startYear = 2024;
        newJobs._endYear = 2026;

        Jobs Jobs2 = new Jobs();
        Jobs2._companyName = "WAICTNET";
        Jobs2._jobTitle = "CEO";
        Jobs2._startYear = 2024;
        Jobs2._endYear = 2026;


        Resume fullResume = new Resume();
        fullResume.name = "Peter Spoon";
        fullResume._jobs.Add(newJobs);
        fullResume._jobs.Add(Jobs2);
        fullResume.DisplayResume();
    }


}