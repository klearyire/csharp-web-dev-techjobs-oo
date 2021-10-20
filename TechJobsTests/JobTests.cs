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
            Assert.IsTrue(test_job1.JobCoreCompetency.Value == "Quality control");
            Assert.IsTrue(test_job1.JobType.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {

        }
    }
}
