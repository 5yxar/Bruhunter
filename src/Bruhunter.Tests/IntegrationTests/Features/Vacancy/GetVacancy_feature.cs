using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Vacancy
{
    public partial class GetVacancy_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_should_be_received_from_database()
        {
            var vacancyId = Guid.NewGuid();

            await Runner.AddAsyncSteps(_ => Given_vacancy_in_database(
                                            GiveMe.Vacancy()
                                                    .WithId(vacancyId)
                                                    .Please()),
                                       _ => When_get_vacancy_with(vacancyId),
                                       _ => Then_received_vacancy_id_should_be_equal(vacancyId))
                         .RunAsync();
        }
    }
}
