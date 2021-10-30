using System;
using System.Collections.Generic;
using Bruhunter.Shared.Documents;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private static readonly List<CandidateDocument> Candidates = new List<CandidateDocument>();

        public void AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            Candidates.Add(candidateDocument);
        }
        public List<CandidateDocument> GetAllCandidates()
        {
            return Candidates;
        }
        public void DeleteCandidate(Guid guid)
        {
            foreach (var candidate in Candidates)
            {
                if (candidate.Id == guid)
                {
                    Candidates.Remove(candidate);
                    break;
                }
            }
        }
    }
}
