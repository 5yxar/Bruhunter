using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public interface ICandidatesRepository
    {
        Task AddCandidate(CandidateDocument candidateDocument);
        Task DeleteCandidate(Guid guid);
        Task<IEnumerable<CandidateDocument>> GetAllCandidates();
    }
}