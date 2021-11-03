using NUnit.Framework;

namespace Common
{
    public abstract class BaseTest
    {

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}
