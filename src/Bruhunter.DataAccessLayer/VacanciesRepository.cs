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

        public async Task AddVacancy(VacancyDocument vacancyDocument)
        {
            collection.Insert(vacancyDocument);
        }

        public async Task<VacancyDocument> GetVacancy(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            return collection.FindAll();
        }
    }
}
