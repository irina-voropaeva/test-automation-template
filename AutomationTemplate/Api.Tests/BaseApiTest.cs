﻿using System;
using Common;

namespace Api.Tests
{
    public abstract class BaseApiTest : BaseTest
    {
        [SetUp]
        public void SetUpUi()
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void TearDownUi()
        {
            throw new NotImplementedException();
        }

        [OneTimeSetUp]
        public void OneTimeSetUpUi()
        {
            throw new NotImplementedException();
        }

        public void OneTimeTearDownUi()
        {
            throw new NotImplementedException();
        }
    }
}