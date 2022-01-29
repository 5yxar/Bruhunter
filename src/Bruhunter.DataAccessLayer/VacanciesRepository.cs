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
            return collection.FindById(id);
        }

        public async Task<IEnumerable<VacancyDocument>> QueryVacancies(DateTime? minCloseDateTime)
        {
            return collection.Find(o => minCloseDateTime == null || (minCloseDateTime != null && o.JobClosingDate > minCloseDateTime));
        }

        public async Task ChangeVacancy(VacancyDocument vacancyDocument)
        {
            collection.Update(vacancyDocument);
        }

        public async Task DeleteVacancy(Guid id)
        {
            collection.Delete(id);
        }
    }
}
