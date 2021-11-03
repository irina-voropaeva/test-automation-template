using OpenQA.Selenium;
using UI.PageObjects.Shared;

namespace UI.PageObjects.Base
{
    public abstract class BaseAutomationPracticePage : BasePage
    {
        public HeaderPage HeaderPage;
        public FooterPage FooterPage;

        protected BaseAutomationPracticePage(IWebDriver driver) : base(driver)
        {
            HeaderPage = new HeaderPage(driver);
            FooterPage = new FooterPage(driver);
        }
    }
}
