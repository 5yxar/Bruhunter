using Bruhunter.Tests.IntegrationTests;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class DeleteCandidates_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_should_be_deleted_from_database()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_candidate_in_database(GiveMe.Candidate().Please()),
                    _ => When_delete_candidates(),
                    _ => Then_database_should_not_contain_candidates())
                .RunAsync();
        }
    }
}
