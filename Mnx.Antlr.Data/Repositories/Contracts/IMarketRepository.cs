using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mnx.Antlr.Data.Models;

namespace Mnx.Antlr.Data.Repositories.Contracts
{
    public interface IMarketRepository
    {
        City MatchText(string text);
    }
}
