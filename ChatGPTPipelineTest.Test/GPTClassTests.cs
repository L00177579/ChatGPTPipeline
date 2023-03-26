using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatGPTPipelineTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTPipelineTest.Tests
{
    [TestClass()]
    public class GPTClassTests
    {
        [TestMethod()]
        [DataRow("test")]
        public void gptfunctionTest(string test)
        {
            GPTClass gPTClass = new GPTClass();
            Assert.IsTrue(gPTClass.gptfunction(test));
        }
    }
}