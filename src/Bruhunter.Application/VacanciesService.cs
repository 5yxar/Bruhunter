using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.Application
{
    public class VacanciesService
    {
        private readonly IVacanciesRepository vacanciesRepository;

        public VacanciesService(IVacanciesRepository vacanciesRepository)
        {
            this.vacanciesRepository = vacanciesRepository;
        }

        public static Task AddVacancy(VacancyDocument VacancyDocument)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            throw new NotImplementedException();
        }
    }
}
