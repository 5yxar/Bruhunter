using Bruhunter.Tests.IntegrationTests;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class GetCandidates_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidates_should_be_received_from_db()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_candidate(GiveMe.Candidate()
                                               .WithId(Guid.Empty)
                                               .WithFirstName("Первое")
                                               .WithSecondName("Второе")
                                               .Please()),
                    _ => When_add_candidate(),
                    _ => Given_candidate(GiveMe.Candidate()
                                               .WithId(Guid.Empty)
                                               .WithFirstName("Первое Первое")
                                               .WithSecondName("Второе Второе")
                                               .Please()),
                    _ => When_add_candidate(),
                    _ => Then_we_should_have_candidates())
                .RunAsync();
        }
    }
}
