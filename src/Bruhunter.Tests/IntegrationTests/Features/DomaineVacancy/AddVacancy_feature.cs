using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.DomaineCandidate
{
    public partial class AddVacancy_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Vacancy_should_be_saved_in_database()
        {
            var vacancyId = Guid.NewGuid();

            await Runner.AddAsyncSteps(
                    _ => Given_vacancy(GiveMe.Vacancy()
                                             .WithId(vacancyId)
                                             .Please()),
                    _ => When_add_vacancy(),
                    _ => Then_database_should_contain_vacancy_with(vacancyId))
                .RunAsync();
        }
    }
}
