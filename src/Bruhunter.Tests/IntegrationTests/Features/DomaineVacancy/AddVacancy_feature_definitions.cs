using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineCandidate
{
    public partial class AddVacancy_feature
    {
        private VacancyDocument vacancyBeforeAddition;

        public async Task Given_vacancy(VacancyDocument vacancyDocument)
        {
            vacancyBeforeAddition = vacancyDocument;
        }

        public async Task When_add_vacancy()
        {
            await VacanciesService.AddVacancy(vacancyBeforeAddition);
        }

        public async Task Then_database_should_contain_vacancy_with(Guid id)
        {
            var vacancies = await VacanciesRepository.GetVacancy(id);

            Assert.Equal(id,vacancies.Id);
        }
    }
}
