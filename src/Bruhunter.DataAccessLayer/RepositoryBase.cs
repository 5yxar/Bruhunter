using LiteDB;

namespace Bruhunter.DataAccessLayer
{
    public class RepositoryBase
    {
        protected readonly LiteDatabase db;

        public RepositoryBase(LiteDatabase db)
        {
            this.db = db;
        }
    }
}
