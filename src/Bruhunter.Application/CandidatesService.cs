using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using Bruhunter.DataAccessLayer;
using System.Diagnostics;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private static readonly List<CandidateDocument> Candidates = new List<CandidateDocument>();
        private static readonly CandidatesRepository candidatesRepository = new CandidatesRepository(@$"Filename=C:\LiteDB\MyData.db; Connection=Shared;");
        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            Candidates.Add(candidateDocument);
            await candidatesRepository.AddCandidate(candidateDocument);
            Console.WriteLine("Complete");
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
