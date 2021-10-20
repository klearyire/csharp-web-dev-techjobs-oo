using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestInitialize]
        public void Job()
        {

        }
    }
}
