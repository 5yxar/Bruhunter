using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineVacancy
{
    public partial class GetVacancies_feature
    {
        IEnumerable<VacancyDocument> vacancies;

        public async Task Given_vacancy_in_database(VacancyDocument vacancyDocument)
        {
            await VacanciesRepository.AddVacancy(vacancyDocument);
        }

        public async Task When_receive_vacancies()
        {
            vacancies = await VacanciesService.GetAllVacancies();
        }

        public async Task Then_received_vacancies_count_should_be(int vacanciesCount)
        {
            Assert.Equal(vacanciesCount, vacancies.ToList().Count);
        }
    }
}
