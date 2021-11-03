using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects.Shared
{
    public class HeaderPage : BasePage
    {
        public By SearchFieldBy => By.Id("search_query_top");

        public By SearchButton => By.Name("submit_search");

        public HeaderPage(IWebDriver driver) : base(driver)
        {
        }

        public HeaderPage ClickSearchField()
        {
            FindElement(SearchFieldBy)
                .Click();

            return this;
        }

        public HeaderPage EnterSearchText(string text)
        {
            FindElement(SearchFieldBy)
                .SendKeys(text);
            return this;
        }

        public SearchResultsPage ClickSearchButton()
        {
            FindElement(SearchButton)
                .Click();

            return new SearchResultsPage(Driver);
        }
    }
}
