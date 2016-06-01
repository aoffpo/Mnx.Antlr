using Mnx.Antlr.Data.Models;
using NUnit.Framework;

namespace Mnx.Antlr.Post.Tests
{
    public class TestBase
    {
        public void AssertLocationsAreEqual(Location expected, Location actual)
        {
            Assert.IsNotNull(actual,"Location is null");
            Assert.AreEqual(expected.Address, actual.Address, "Address");
            Assert.AreEqual(expected.City, actual.City, "City");
            Assert.AreEqual(expected.Identifiers, actual.Identifiers, "Identifiers");
            Assert.AreEqual(expected.LocationName, actual.LocationName, "LocationName");
            Assert.AreEqual(expected.PostalCode, actual.PostalCode, "PostalCode");
            Assert.AreEqual(expected.Region, actual.Region, "Region");
        }
    }
}
