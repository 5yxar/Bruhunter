using Bruhunter.Tests.IntegrationTests;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineVacancy
{
    public partial class GetVacancies_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Vacancies_should_be_received_from_db()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_vacancy_in_database(GiveMe.Vacancy().Please()),
                    _ => Given_vacancy_in_database(GiveMe.Vacancy().Please()),
                    _ => When_receive_vacancies(),
                    _ => Then_received_vacancies_count_should_be(2))
                .RunAsync();
        }
    }
}
