using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestSample.Test
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.IsTrue(true);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 6)]
        public void RowTest(int a, int b, int result)
        {
            Assert.AreEqual(result, a + b);
        }
    }
}
