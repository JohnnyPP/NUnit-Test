using System;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestPositive()
        {
            int x = 10;
            int y = 10;

            Assert.AreEqual(x, y);
        }

        [Test]
        public void TestNegative()
        {
            if (true)
            {
                Assert.Fail("This is a failure");
                //Assert.Pass("This will pass");
            }
        }

        [Test,ExpectedException(typeof(NotSupportedException))]     //this will pass the test
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();
        }

        [Test,Ignore]                                               //this will be ignored
        public void NotImplementedException()
        {
            throw new NotImplementedException();
        }

    }
}
