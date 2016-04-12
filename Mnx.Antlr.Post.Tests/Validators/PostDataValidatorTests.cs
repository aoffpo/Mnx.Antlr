using Mnx.Antlr.Post.Listeners.Validators;
using NUnit.Framework;

namespace Mnx.Antlr.Post.Tests.Validators
{
    [TestFixture]
    public class PostDataValidatorTests : TestBase
    {
        [Test]
        public void SimpleTestOk()
        {
            var data = TestData.BasicData();
            var validator = new PostDataValidator();
            var result = validator.Validate(data);
            Assert.IsTrue(result.IsValid);
        }
    }
}
