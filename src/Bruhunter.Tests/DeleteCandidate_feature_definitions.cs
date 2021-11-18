using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests
{
    public partial  class DeleteCandidate_feature
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
