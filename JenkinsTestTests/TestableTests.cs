using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest.Tests
{
    [TestClass()]
    public class TestableTests
    {
        [TestMethod()]
        public void GetNumTest()
        {
            Testable testable = new Testable();
            Assert.IsNotNull(testable);
        }
    }
}