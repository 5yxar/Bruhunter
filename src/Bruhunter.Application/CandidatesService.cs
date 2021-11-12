using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using Bruhunter.DataAccessLayer;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private readonly CandidatesRepository candidatesRepository;

        public CandidatesService(CandidatesRepository candidatesRepository)
        {
            this.candidatesRepository = candidatesRepository;
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            await candidatesRepository.AddCandidate(candidateDocument);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return await candidatesRepository.GetAllCandidates();
        }

        public async Task DeleteCandidate(Guid guid)
        {
            await candidatesRepository.DeleteCandidate(guid);
        }
    }
}
