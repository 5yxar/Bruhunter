using Bruhunter.Application;
using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features
{
    public partial class GetCandidate_feature
    {
        private CandidateDocument receivedCandidate;

        private async Task Given_candidate_in_database(CandidateDocument candidateDocument)
        {
            await CandidatesRepository.AddCandidate(candidateDocument);
        }

        private async Task When_get_candidate_with(Guid candidateId)
        {
            receivedCandidate = await CandidatesService.GetCandidate(candidateId);
        }

        private async Task Then_received_candidate_id_should_be_equal(Guid candidateId)
        {
            Assert.Equal(candidateId, receivedCandidate.Id);
        }
    }
}
