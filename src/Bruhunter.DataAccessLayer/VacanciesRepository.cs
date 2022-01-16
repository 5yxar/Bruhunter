using Bruhunter.Shared.Documents;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public class VacanciesRepository : RepositoryBase, IVacanciesRepository
    {
        private readonly ILiteCollection<VacancyDocument> collection;

        public VacanciesRepository(LiteDatabase db) : base(db)
        {
            collection = db.GetCollection<VacancyDocument>("vacancies");
        }

        public Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            throw new NotImplementedException();
        }

        public Task<VacancyDocument> GetVacancy(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
