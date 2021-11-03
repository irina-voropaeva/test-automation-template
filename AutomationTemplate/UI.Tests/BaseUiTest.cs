using System;
using Common;
using Common.Utils;
using Common.Utils.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace UI.Tests
{
    public class BaseUiTest : BaseTest
    {
        protected string BaseUrl;
        [ThreadStatic]
        protected static IWebDriver Driver;

        [SetUp]
        public void SetUpUi()
        {
            Driver = Settings.Instance.GetDriver();
        }

        [TearDown]
        public void TearDownUi()
        {
            Driver.Quit();
        }

        [OneTimeSetUp]
        public void OneTimeSetUpUi()
        {
            BaseUrl = Config.Instance.BaseUrl;
        }

        public void OneTimeTearDownUi()
        {
        }
    }
}
