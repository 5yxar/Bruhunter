using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Vacancy
{
    public partial class AddVacancy_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Vacancy_should_be_saved_in_database()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_vacancy(GiveMe.Vacancy().Please()),
                    _ => When_add_vacancy(),
                    _ => Then_database_should_contain_vacancy())
                .RunAsync();
        }
    }
}
