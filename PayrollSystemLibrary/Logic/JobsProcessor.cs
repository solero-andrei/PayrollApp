using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class JobsProcessor
    {
        public JobsProcessor()
        {

        }

        private string JobName = "";
        public JobsProcessor(string JobName)
        {
            this.JobName = JobName;
        }
        public List<JobPositions> Jobs()
        {
            List<JobPositions> jobs = new List<JobPositions>();
            JobRepository jobRepository = new JobRepository();
            var jobsFound = jobRepository.GetJobs();

            foreach (var job in jobsFound)
            {
                jobs.Add(new JobPositions
                {
                    JobID = job.JobID,
                    JobName = job.JobName,
                    MonthlySalary = job.MonthlySalary
                });
            }

            return jobs;
        }

        public JobPositions FilterJob(string jobName)
        {
            JobRepository jobRepo = new JobRepository();
            return jobRepo.Filter(jobName);
        }
    }
}
