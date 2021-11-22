using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial  class DeleteCandidate_feature
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
        public async Task When_delete_candidates()
        {
            var candidates = await GetCandidates();

            foreach (CandidateDocument candidate in candidates)
            {
                await CandidatesService.DeleteCandidate(candidate.Id);
            }
        }
        public async Task Then_database_should_not_contain_candidate()
        {
            Assert.Empty(await GetCandidates());
        }

        private async Task<List<CandidateDocument>> GetCandidates()
        {
            return (List<CandidateDocument>)await CandidatesRepository.GetAllCandidates();
        }
    }
}
