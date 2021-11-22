using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class GetCandidates_feature
    {
        private CandidateDocument candidateBeforeInsert;

        public async Task Given_candidate(CandidateDocument candidateDocument)
        {
            candidateBeforeInsert = candidateDocument;
        }
        public async Task When_add_candidate()
        {
            await CandidatesService.AddCandidate(candidateBeforeInsert);
        }

        public async Task Then_we_should_have_candidates()
        {
            var candidates = await CandidatesService.GetAllCandidates();
            Assert.NotEmpty(candidates);
        }
    }
}
