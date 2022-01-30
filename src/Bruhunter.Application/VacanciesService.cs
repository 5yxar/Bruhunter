using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.Application
{
    public class VacanciesService
    {
        private readonly IVacanciesRepository vacanciesRepository;
        private readonly CandidatesService candidatesService;

        public VacanciesService(IVacanciesRepository vacanciesRepository, CandidatesService candidatesService)
        {
            this.vacanciesRepository = vacanciesRepository;
            this.candidatesService = candidatesService;
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

        public async Task<IEnumerable<VacancyDocument>> QueryVacancies(DateTime? minCloseDateTime = null)
        {
            return await vacanciesRepository.QueryVacancies(minCloseDateTime);
        }

        public async Task ChangeVacancy(VacancyDocument vacancyDocument)
        {
            await vacanciesRepository.ChangeVacancy(vacancyDocument);

            await candidatesService.UpdateCandidateVacancyTitles(vacancyDocument.ToCandidateVacancyDocumentProjection());
        }

        public async Task DeleteVacancy(Guid id)
        {
            await vacanciesRepository.DeleteVacancy(id);
        }
    }
}
