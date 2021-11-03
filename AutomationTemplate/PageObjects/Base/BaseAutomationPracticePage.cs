using OpenQA.Selenium;
using UI.PageObjects.Shared;

namespace UI.PageObjects.Base
{
    public abstract class BaseAutomationPracticePage : BasePage
    {
        public Header Header;
        public Footer Footer;

        protected BaseAutomationPracticePage(IWebDriver driver) : base(driver)
        {
            Header = new Header(driver);
            Footer = new Footer(driver);
        }
    }
}
