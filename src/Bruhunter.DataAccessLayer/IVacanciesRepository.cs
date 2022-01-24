using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public interface IVacanciesRepository
    {
        Task AddVacancy(VacancyDocument vacancyDocument);
        Task<VacancyDocument> GetVacancy(Guid id);
        Task<IEnumerable<VacancyDocument>>GetAllVacancies();
        Task ChangeVacancy(VacancyDocument vacancyDocument);
        Task DeleteVacancy(Guid id);
    }
}