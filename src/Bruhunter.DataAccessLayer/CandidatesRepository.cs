using Bruhunter.Shared.Documents;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Bruhunter.DataAccessLayer
{
    public class CandidatesRepository : RepositoryBase
    {
        private ILiteCollection<CandidateDocument> collection;

        public CandidatesRepository(string connectionString) : base(connectionString)
        {
            collection = db.GetCollection<CandidateDocument>("candidates");
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            collection.Insert(candidateDocument);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return collection.FindAll().ToList();
        }

        public async Task DeleteCandidate(Guid guid)
        {
            collection.Delete(guid);
        }
    }
}
