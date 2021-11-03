using OpenQA.Selenium;
using UI.PageObjects.Base;

namespace UI.PageObjects.Shared
{
    public class Header : BasePage
    {
        public By SearchFieldBy => By.Id("search_query_top");

        public By SearchButton => By.Name("submit_search");

        public Header(IWebDriver driver) : base(driver)
        {
        }

        public Header ClickSearchField()
        {
            FindElement(SearchFieldBy)
                .Click();

            return this;
        }

        public Header EnterSearchText(string text)
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
