using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public interface ICandidatesRepository
    {
        Task AddCandidate(CandidateDocument candidateDocument);
        Task<CandidateDocument> GetCandidate(Guid id);
        Task<IEnumerable<CandidateDocument>> GetAllCandidates();
        Task ChangeCandidate(CandidateDocument candidateDocument);
        Task DeleteCandidate(Guid guid);
    }
}