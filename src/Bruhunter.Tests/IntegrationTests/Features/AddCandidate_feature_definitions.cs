using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class AddCandidate_feature
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

        public async Task Then_database_should_contain_candidate()
        {
            var candidates = await CandidatesRepository.GetAllCandidates();
            Assert.Single(candidates);
        }
    }
}
