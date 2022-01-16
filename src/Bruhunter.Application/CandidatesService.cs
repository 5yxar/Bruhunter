using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using Bruhunter.DataAccessLayer;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private readonly ICandidatesRepository candidatesRepository;

        public CandidatesService(ICandidatesRepository candidatesRepository)
        {
            this.candidatesRepository = candidatesRepository;
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidateDocument.Id = Guid.NewGuid();
            await candidatesRepository.AddCandidate(candidateDocument);
        }

        public Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            throw new NotImplementedException();
        }

        public async Task<CandidateDocument> GetCandidate(Guid id)
        {
            return await candidatesRepository.GetCandidate(id);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return await candidatesRepository.GetAllCandidates();
        }

        public async Task ChangeCandidate(CandidateDocument candidateDocument)
        {
            await candidatesRepository.ChangeCandidate(candidateDocument);
        }

        public async Task DeleteCandidate(Guid guid)
        {
            await candidatesRepository.DeleteCandidate(guid);
        }
    }
}
