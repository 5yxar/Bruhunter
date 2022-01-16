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

        public async Task AddVacancy(VacancyDocument vacancyDocument)
        {
            vacancyDocument.Id = Guid.NewGuid();

            await vacanciesRepository.AddVacancy(vacancyDocument);
        }

        public async Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            return await vacanciesRepository.GetAllVacancies();
        }
    }
}
