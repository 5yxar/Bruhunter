using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineVacancy
{
    public partial class DeleteVacancy_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Vacancy_should_be_deleted_from_database()
        {
            var vacancyId = Guid.NewGuid();

            await Runner.AddAsyncSteps(_ => Given_vacancy_in_database(
                                            GiveMe.Vacancy()
                                                  .WithId(vacancyId)
                                                  .Please()),
                                        _ => When_delete_vacancies(vacancyId),
                                        _ => Then_database_should_not_contain_vacancies())
                        .RunAsync();
        }
    }
}
