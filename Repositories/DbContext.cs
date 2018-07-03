using System.Data;

namespace readit_copy.Repositories
{
    public abstract class DbContext
    {
        protected readonly IDbConnection _db;

        public DbContext(IDbConnection db)
        {
            _db = db;
        }
    }
}