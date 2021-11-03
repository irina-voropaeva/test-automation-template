using NUnit.Framework;
using UI.PageObjects.Shared;

namespace UI.Tests.GeneralTests
{
    public class BaseGeneralTest : BaseUiTest
    {
        protected HeaderPage Header;

        [SetUp]
        public void GeneralSetUp()
        {
            Header = new HeaderPage(Driver);
        }
    }
}
