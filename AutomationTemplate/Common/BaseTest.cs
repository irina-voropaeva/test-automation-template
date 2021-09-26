using System;

namespace Common
{
    public abstract class BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void TearDown()
        {
            throw new NotImplementedException();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            throw new NotImplementedException();
        }

        public void OneTimeTearDown()
        {
            throw new NotImplementedException();
        }
    }
}
