using Bruhunter.Shared.Documents;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineVacancy
{
    public partial class ChangeVacancy_feature
    {
        private Guid vacancyId;

        public async Task Given_vacancy_in_database(VacancyDocument vacancyDocument)
        {
            vacancyId = vacancyDocument.Id;

            await VacanciesRepository.AddVacancy(vacancyDocument);
        }

        public async Task When_changed_vacancy(VacancyDocument vacancyDocument)
        {
            await VacanciesService.ChangeVacancy(vacancyDocument);
        }

        public async Task Then_vacancy_address_in_database_should_be(string expectedVacancyAddress)
        {
            var receivedVacancy = await VacanciesRepository.GetVacancy(vacancyId);

            Assert.Equal(expectedVacancyAddress, receivedVacancy.Address);
        }
    }
}
