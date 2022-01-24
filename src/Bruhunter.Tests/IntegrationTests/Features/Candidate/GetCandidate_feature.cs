using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Candidate
{
    public partial class GetCandidate_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_should_be_received_from_database()
        {
            var candidateId = Guid.NewGuid();

            await Runner.AddAsyncSteps(_ => Given_candidate_in_database(
                                            GiveMe.Candidate()
                                                    .WithId(candidateId)
                                                    .Please()),
                                       _ => When_get_candidate_with(candidateId),
                                       _ => Then_received_candidate_id_should_be_equal(candidateId))
                         .RunAsync();
        }
    }
}
