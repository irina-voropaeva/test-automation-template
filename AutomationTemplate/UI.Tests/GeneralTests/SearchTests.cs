using FluentAssertions;
using NUnit.Framework;

namespace UI.Tests.GeneralTests
{
    [TestFixture]
    public class SearchTests : BaseGeneralTest
    {
        [Test]
        public void Search_EnterValidData_ValidOutput()
        {
            //arrange
            const string searchData = "faded";
            const string searchResultText = "Faded Short Sleeve T-shirts";

            //act
            var searchResultBy = Header.ClickSearchField()
                  .EnterSearchText(searchData)
                  .ClickSearchButton()
                  .GetSearchResultBy(searchResultText);

            //assert
            WebElementHelper.IsElementPresented(searchResultBy)
                            .Should()
                            .BeTrue();
        }
    }
}
