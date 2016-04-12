﻿using Mnx.Antlr.Data.Models;
using Mnx.Antlr.Data.Repositories.Contracts;

namespace Mnx.Antlr.Data.Repositories
{
    public class MarketRepository : BaseRepository<Market>, IMarketRepository
    {
        public int MarketId { get; set; }

        public MarketRepository(int marketId)
        {
            MarketId = marketId;
        }
        public Market Get(string key)
        {
            return Bucket.Get<Market>(key).Value;
        }

        public City MatchText(string text)
        {
            var market = Get("market_" + MarketId);
            return market.Cities.Find(c => text.Contains(c.Name.Split(',')[0]));
        }
    }
}
