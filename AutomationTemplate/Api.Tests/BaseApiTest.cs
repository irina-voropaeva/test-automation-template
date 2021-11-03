using System;
using Common;
using NUnit.Framework;

namespace Api.Tests
{
    public abstract class BaseApiTest : BaseTest
    {
        [SetUp]
        public void SetUpApi()
        {
        }

        [TearDown]
        public void TearDownApi()
        {
        }

        [OneTimeSetUp]
        public void OneTimeSetUpApi()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTearDownApi()
        {
        }
    }
}
