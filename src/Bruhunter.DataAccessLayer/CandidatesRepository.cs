using Bruhunter.Shared.Documents;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruhunter.DataAccessLayer
{
    public class CandidatesRepository : RepositoryBase
    {
        private static ILiteCollection<CandidateDocument> col;
        public CandidatesRepository(string connectionString) : base(connectionString)
        {
            col = db.GetCollection<CandidateDocument>("candidates");
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            col.Insert(candidateDocument);
        }

    }
}
