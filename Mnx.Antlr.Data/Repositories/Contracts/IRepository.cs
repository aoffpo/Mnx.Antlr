using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couchbase;
using Couchbase.Annotations;
using Couchbase.Core;

namespace Mnx.Antlr.Data.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IBucket Bucket { get; set; }
        T Get(int id);
        List<T> GetAll();
    }
}
