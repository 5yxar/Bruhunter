using System;
using System.Collections.Generic;
using Bruhunter.Shared.Documents;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        public CandidatesService()
        {
                       
        }

        private static readonly List<CandidateDocument> Candidates = new List<CandidateDocument>();

        public void AddCandidate(CandidateDocument candidateDocument)
        {
            Candidates.Add(candidateDocument);
        }
        public List<CandidateDocument> GetAllCandidates()
        {
            return Candidates;
        }

    }
}
