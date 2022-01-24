using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Vacancy
{
    public partial class ChangeVacancy_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Vacancy_address_should_be_changed_in_database()
        {
            var vacancyId = Guid.NewGuid();
            var expectedVacancyAddress = "Пенза";

            await Runner.AddAsyncSteps(_ => Given_vacancy_in_database(
                                                GiveMe.Vacancy()
                                                      .WithId(vacancyId)
                                                      .Please()),
                                       _ => When_changed_vacancy(
                                                GiveMe.Vacancy()
                                                      .WithId(vacancyId)
                                                      .WithAddress(expectedVacancyAddress)
                                                      .Please()),
                                      _ => Then_vacancy_address_in_database_should_be(expectedVacancyAddress))
                        .RunAsync();
        }
    }
}
