using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features
{
    public partial class ChangeCandidate_feature
    {
        Guid candidateId;
        public async Task Given_candidate_in_database(CandidateDocument candidateDocument)
        {
            candidateId = candidateDocument.Id;
            await CandidatesRepository.AddCandidate(candidateDocument);
        }

        public async Task When_changed_candidate(CandidateDocument candidateDocument)
        {
            await CandidatesService.ChangeCandidate(candidateDocument);
        }

        public async Task Then_candidate_first_name_in_database_should_be(string candidateFirstName)
        {
            var receivedCandidate = await CandidatesRepository.GetCandidate(candidateId);
            Assert.Equal(candidateFirstName, receivedCandidate.FirstName);
        }
    }
}
