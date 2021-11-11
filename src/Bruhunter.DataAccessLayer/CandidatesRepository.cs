using Bruhunter.Shared.Documents;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public class CandidatesRepository : RepositoryBase
    {
        private static ILiteCollection<CandidateDocument> col;
        public CandidatesRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            await UpdateCollection();
            candidateDocument.Id = Guid.NewGuid();
            col.Insert(candidateDocument);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            var candidates = new List<CandidateDocument>();
            await UpdateCollection();
            foreach (var item in col.FindAll())
            {
                candidates.Add(item);
            }
            return candidates;
        }

        public async Task DeleteCandidate(Guid guid)
        {
            var sqlRequest = "DELETE candidates WHERE _id = {\"$guid\": \" " + guid.ToString() + " \"}";
            db.Execute(sqlRequest);
        }

        private async Task UpdateCollection()
        {
            col = db.GetCollection<CandidateDocument>("candidates");
        }
    }
}
