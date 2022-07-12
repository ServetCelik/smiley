using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;

namespace SmileyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExistence()
        {
            LogicClass lc = new LogicClass();
            bool test = lc.CheckUserExistence("superAdmin", "abcd@gmail.com");

            Assert.AreEqual(test, true);
        }

    }
}
