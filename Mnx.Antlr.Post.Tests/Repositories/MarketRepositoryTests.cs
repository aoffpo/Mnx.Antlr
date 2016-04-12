﻿using Couchbase;
using Couchbase.Core;
using Mnx.Antlr.Data.Repositories;
using NUnit.Framework;

namespace Mnx.Antlr.Post.Tests.Repositories
{
    [TestFixture]
    public class MarketRepositoryTests
    {
        private Cluster _cluster;
        private MarketRepository _marketRepository;

        [SetUp]
        public void Setup()
        {
            _cluster = new Cluster();
            _marketRepository = new MarketRepository(0)
            {
                Bucket =_cluster.OpenBucket("truck")
            };
        }

        [TearDown]
        public void TearDown()
        {
            _cluster.CloseBucket(_marketRepository.Bucket);
            if (_marketRepository.Bucket != null)
                _marketRepository.Bucket.Dispose();
            _cluster.Dispose();
        }
        [Test]
        public void GetAll_ReturnsInMarket([Range(0,12)] int id)
        {
                var result = _marketRepository.Get("market_" + id);
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.Cities[0].Name);
        }
        [Test]
        public void MatchText_ReturnsSingle()
        {
            const string data = "find Carythis text in string";
            var result = _marketRepository.MatchText(data);
            Assert.IsTrue(result.Name == "Cary,NC");
        }

        public void MatchText_ReturnsMany()
        {

        }

        public void MatchText_ReturnsNone()
        {

        }
    }
}