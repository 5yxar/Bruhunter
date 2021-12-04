using Bruhunter.Shared.Documents;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Bruhunter.DataAccessLayer
{
    public class CandidatesRepository : RepositoryBase, ICandidatesRepository
    {
        private readonly ILiteCollection<CandidateDocument> collection;

        public CandidatesRepository(LiteDatabase db) : base(db)
        {
            collection = db.GetCollection<CandidateDocument>("candidates");
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            collection.Insert(candidateDocument);
        }

        public async Task<CandidateDocument> GetCandidate(Guid id)
        {
            return collection.FindById(id);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return collection.FindAll().ToList();
        }

        public async Task ChangeCandidate(CandidateDocument candidateDocument)
        {
            collection.Upsert(candidateDocument);
        }

        public async Task DeleteCandidate(Guid guid)
        {
            collection.Delete(guid);
        }
    }
}
