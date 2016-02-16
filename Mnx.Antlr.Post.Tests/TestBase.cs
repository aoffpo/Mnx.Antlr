using Mnx.Antlr.Post.Listeners.Models;
using NUnit.Framework;

namespace Mnx.Antlr.Post.Tests
{
    public class TestBase
    {
        public void AssertLocationsAreEqual(Location expected, Location actual)
        {
            Assert.AreEqual(expected.Address, actual.Address);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.Identifiers, actual.Identifiers);
            Assert.AreEqual(expected.LocationName, actual.LocationName);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
            Assert.AreEqual(expected.Region, actual.Region);
        }
    }
}
