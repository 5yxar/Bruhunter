using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.Vacancy
{
    public partial class DeleteVacancy_feature
    {
        public async Task Given_vacancy_in_database(VacancyDocument vacancyDocument)
        {
            await VacanciesRepository.AddVacancy(vacancyDocument);
        }

        public async Task When_delete_vacancies(Guid id)
        {
            await VacanciesService.DeleteVacancy(id);
        }

        public async Task Then_database_should_not_contain_vacancies()
        {
            Assert.Empty(await VacanciesRepository.QueryVacancies(null));
        }
    }
}
