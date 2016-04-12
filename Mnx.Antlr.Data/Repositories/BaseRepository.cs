using System.Collections.Generic;
using Couchbase;
using Couchbase.Core;
using Mnx.Antlr.Data.Repositories.Contracts;

namespace Mnx.Antlr.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T>
    {
        public IBucket Bucket { get; set; }

        public T Get(int id)
        {
            return Bucket.Get<T>(id.ToString()).Value;          
        }

        public virtual List<T> GetAll()
        {
            return null;
        }
    }
}
