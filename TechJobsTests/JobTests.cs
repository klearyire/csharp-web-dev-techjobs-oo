using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job1;
        Employer acme;
        Location desert;
        PositionType qa;
        CoreCompetency persistence;

        [TestInitialize]
        public void CreateJobAndFields()
        {
            acme = new Employer("ACME");
            desert = new Location("Desert");
            qa = new PositionType("Quality control");
            persistence = new CoreCompetency("Persistence");

            test_job1 = new Job("Product tester", acme, desert, qa, persistence);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(test_job1.Name == "Product tester");
            Assert.IsTrue(test_job1.EmployerName.Value == "ACME");
            Assert.IsTrue(test_job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(test_job1.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(test_job1.JobType.Value == "Quality control");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("name", new Employer("employer"), new Location("location"), new PositionType("type"), new CoreCompetency("persistence"));
            Job job2 = new Job("name", new Employer("employer"), new Location("location"), new PositionType("type"), new CoreCompetency("persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobsToString()
        {
            Assert.AreEqual(test_job1.ToString().Substring(0, 1), "\n");
            Assert.AreEqual(test_job1.ToString().Substring(test_job1.ToString().Length - 1, 1), "\n");
            Assert.IsTrue(test_job1.ToString().Contains($"Id: " + test_job1.Id));
            Assert.IsTrue(test_job1.ToString().Contains($"Name: " + test_job1.Name));
            Assert.IsTrue(test_job1.ToString().Contains($"Employer: " + test_job1.EmployerName.Value));
            Assert.IsTrue(test_job1.ToString().Contains($"Location: " + test_job1.EmployerLocation.Value));
            Assert.IsTrue(test_job1.ToString().Contains($"Position type: " + test_job1.JobType.Value));
            Assert.IsTrue(test_job1.ToString().Contains($"Core competency: " + test_job1.JobCoreCompetency.Value));

            Job jobToStringTest2 = new Job("", new Employer(""), desert, qa, persistence);
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Name: Data not available"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Employer: Data not available"));

            Job jobToStringTest3 = new Job();
            Assert.AreEqual(jobToStringTest3.ToString(), "Oops! This job does not seem to exist.");

        }
    }
}
