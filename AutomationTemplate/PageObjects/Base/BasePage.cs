using OpenQA.Selenium;
using UI.PageObjects.Shared;

namespace UI.PageObjects
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement FindElement(By by)
        {
            return Driver.FindElement(by);
        }
    }
}
