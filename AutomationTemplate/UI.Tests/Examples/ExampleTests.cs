using System;
using Common.Utils;
using Common.Utils.Configuration;
using NUnit.Framework;

namespace UI.Tests.Examples
{
    [TestFixture]
    public class ExampleTests : BaseUiTest
    {
        [Test]
        public void ExampleTest()
        {
            var url = Config.Instance.BaseUrl;
            Console.WriteLine("url is " + url);
        }
    }
}
