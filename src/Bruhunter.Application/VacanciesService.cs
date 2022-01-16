using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
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
    }
}
