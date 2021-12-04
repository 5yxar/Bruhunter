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
        Task DeleteCandidate(Guid guid);
    }
}