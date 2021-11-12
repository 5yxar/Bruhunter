using System;
using LiteDB;

namespace Bruhunter.DataAccessLayer
{
    public class RepositoryBase
    {
        protected readonly LiteDatabase db;

        public RepositoryBase(string connectionString)
        {
            db = new LiteDatabase(connectionString);
        }
    }
}
