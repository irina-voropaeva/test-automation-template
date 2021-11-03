using NUnit.Framework;
using UI.PageObjects.Shared;

namespace UI.Tests.GeneralTests
{
    public class BaseGeneralTest : BaseUiTest
    {
        protected Header Header;

        [SetUp]
        public void GeneralSetUp()
        {
            Header = new Header(Driver);
        }
    }
}
