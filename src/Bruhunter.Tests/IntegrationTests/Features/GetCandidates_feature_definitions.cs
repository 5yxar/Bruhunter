using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class GetCandidates_feature
    {
        IEnumerable<CandidateDocument> candidates;
        public async Task Given_candidate_in_database(CandidateDocument candidateDocument)
        {
            await CandidatesRepository.AddCandidate(candidateDocument);
        }
        public async Task When_receive_candidates()
        {
            candidates = await CandidatesService.GetAllCandidates();
        }

        public async Task Then_received_candidates_count_should_be(int candidatesCount)
        {
            Assert.Equal(candidatesCount, candidates.ToList().Count);
        }
    }
}
