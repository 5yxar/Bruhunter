using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineVacancy
{
    public partial class GetVacancy_feature
    {
        private VacancyDocument receivedVacancy;

        private async Task Given_vacancy_in_database(VacancyDocument vacancyDocument)
        {
            await VacanciesRepository.AddVacancy(vacancyDocument);
        }

        private async Task When_get_vacancy_with(Guid vacancyId)
        {
            receivedVacancy = await VacanciesService.GetVacancy(vacancyId);
        }

        private async Task Then_received_vacancy_id_should_be_equal(Guid vacancyId)
        {
            Assert.Equal(vacancyId, receivedVacancy.Id);
        }
    }
}
