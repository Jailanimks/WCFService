using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobServiceAssignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JobService : IJobService
    {
        
        private List<JobOpenings> consumeJobOpenings()
        {
            List<JobOpenings> LstJobs = new List<JobOpenings>();
            JobOpenings Job1 = new JobOpenings();
            Job1.JobRole = "Developer";
            Job1.JobDesc = "Big Data Developer";
            LstJobs.Add(Job1);

            JobOpenings Job2 = new JobOpenings();
            Job2.JobRole = "Developer";
            Job2.JobDesc = "Spark Developer";
            LstJobs.Add(Job2);

            JobOpenings Job3 = new JobOpenings();
            Job3.JobRole = "Developer";
            Job3.JobDesc = "DOT NET Developer";
            LstJobs.Add(Job3);

            JobOpenings Job4 = new JobOpenings();
            Job4.JobRole = "Developer";
            Job4.JobDesc = "Java Developer";
            LstJobs.Add(Job4);


            JobOpenings Job5 = new JobOpenings();
            Job5.JobRole = "Associate";
            Job5.JobDesc = "Angular JS";
            LstJobs.Add(Job5);

            JobOpenings Job6 = new JobOpenings();
            Job6.JobRole = "Associate";
            Job6.JobDesc = "React JS";
            LstJobs.Add(Job6);

            JobOpenings Job7 = new JobOpenings();
            Job7.JobRole = "Team Lead";
            Job7.JobDesc = "DOT NET";
            LstJobs.Add(Job7);

            JobOpenings Job8 = new JobOpenings();
            Job8.JobRole = "Team Lead";
            Job8.JobDesc = "Java";
            LstJobs.Add(Job8);


            JobOpenings Job9 = new JobOpenings();
            Job9.JobRole = "Project Lead";
            Job9.JobDesc = "Java";
            LstJobs.Add(Job9);

            return LstJobs;
        }

      public List<JobOpenings> GetAllJobOpenings ()
        {
            return consumeJobOpenings();
        }


        public List<JobOpenings> GetJobOpeningsByRole(string Role)
        {
            return consumeJobOpenings().Where(x => x.JobRole == Role || Role == null).ToList();
           
        }

    }
}
