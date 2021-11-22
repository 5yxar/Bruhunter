using Bruhunter.Tests.IntegrationTests;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class DeleteCandidate_feature:FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_should_be_deleted_in_database()
        {
            await Runner.AddAsyncSteps(_ => Given_candidate(GiveMe.Candidate()
                                                            .WithId(Guid.Empty)
                                                            .WithFirstName("FirstName")
                                                            .WithSecondName("SecondName")
                                                            .Please()),
                                _ => When_add_candidate(),
                                _ => When_delete_candidates(),
                                _ => Then_database_should_not_contain_candidate())
                               .RunAsync();
        }
    }
}
