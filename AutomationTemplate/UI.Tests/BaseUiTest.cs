using System;
using Common;
using Common.Utils;
using Common.Utils.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using UI.Services;

namespace UI.Tests
{
    public class BaseUiTest : BaseTest
    {
        protected string BaseUrl;
        [ThreadStatic]
        protected static IWebDriver Driver;

        [ThreadStatic] protected static WebElementHelper WebElementHelper;

        [SetUp]
        public void SetUpUi()
        {
            Driver = Settings.Instance.GetDriver();

            Driver.Navigate()
                  .GoToUrl(Config.Instance.BaseUrl);

            WebElementHelper = new WebElementHelper(Driver);
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

        [OneTimeTearDown]
        public void OneTimeTearDownUi()
        {
        }
    }
}
