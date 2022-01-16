using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public interface IVacanciesRepository
    {
        Task<IEnumerable<VacancyDocument>>GetAllVacancies();
        Task<VacancyDocument> GetVacancy(Guid id);
    }
}