using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class GetCandidates_feature
    {
        private CandidateDocument candidateBeforeAddition;

        public async Task Given_candidate(CandidateDocument candidateDocument)
        {
            candidateBeforeAddition = candidateDocument;
        }
        public async Task When_add_candidate()
        {
            await CandidatesService.AddCandidate(candidateBeforeAddition);
        }

        public async Task Then_we_should_have_candidates()
        {
            var candidates = await CandidatesService.GetAllCandidates();
            Assert.NotEmpty(candidates);
        }
    }
}
