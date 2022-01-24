using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Candidate
{
    public partial class ChangeCandidate_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_first_name_should_be_changed_in_database()
        {
            var candidateId = Guid.NewGuid();
            var expectedCandidateFirstName = "Василий";

            await Runner.AddAsyncSteps(_ => Given_candidate_in_database(
                                                GiveMe.Candidate()
                                                .WithId(candidateId)
                                                .Please()),
                                       _ => When_changed_candidate(
                                                GiveMe.Candidate()
                                                .WithId(candidateId)
                                                .WithFirstName(expectedCandidateFirstName)
                                                .Please()),
                                      _ => Then_candidate_first_name_in_database_should_be(expectedCandidateFirstName))

                        .RunAsync();
        }
    }
}
