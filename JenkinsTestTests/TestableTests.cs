using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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