using OpenQA.Selenium;

namespace UI.PageObjects
{
    public class SearchResultsPage : BaseAutomationPracticePage
    {

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public By GetSearchResultBy(string searchResultText)
        {
            return By.XPath($"//h5/a[@title='{searchResultText}']");
        }
    }
}
