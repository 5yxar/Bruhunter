using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bruhunter.Application
{
    public class VacanciesService
    {
        private readonly IVacanciesRepository vacanciesRepository;

        public VacanciesService(IVacanciesRepository vacanciesRepository)
        {
            this.vacanciesRepository = vacanciesRepository;
        }

        public async Task AddVacancy(VacancyDocument vacancyDocument)
        {
            vacancyDocument.Id = Guid.NewGuid();

            await vacanciesRepository.AddVacancy(vacancyDocument);
        }

        public async Task<VacancyDocument> GetVacancy(Guid candidateId)
        {
            return await vacanciesRepository.GetVacancy(candidateId);
        }

        public async Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            return await vacanciesRepository.GetAllVacancies();
        }

        public async Task ChangeVacancy(VacancyDocument vacancyDocument)
        {
            await vacanciesRepository.ChangeVacancy(vacancyDocument);
        }

        public async Task DeleteVacancy(Guid id)
        {
            await vacanciesRepository.DeleteVacancy(id);
        }

        public async Task<IEnumerable<CandidateVacancyDocumentProjection>> GetAllCandidateVacancies()
        {
            return (await vacanciesRepository.GetAllVacancies()).Select(x => new CandidateVacancyDocumentProjection
                                                                                        { Id = x.Id, Title = x.Title });
        }
    }
}
