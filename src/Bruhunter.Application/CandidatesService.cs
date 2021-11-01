using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private static readonly List<CandidateDocument> Candidates = new List<CandidateDocument>();

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            Candidates.Add(candidateDocument);
        }

        public async Task<List<CandidateDocument>> GetAllCandidates()
        {
            return Candidates;
        }

        public async Task DeleteCandidate(Guid guid)
        {
            Candidates.RemoveAll(o => o.Id == guid);
        }
    }
}
