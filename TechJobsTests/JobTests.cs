using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();

            Assert.IsFalse(test_job1 == test_job2);
        }
    }
}
