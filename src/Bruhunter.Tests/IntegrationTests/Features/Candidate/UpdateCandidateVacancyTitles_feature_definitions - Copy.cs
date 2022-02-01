using Bruhunter.Shared.Documents;
using Bruhunter.Shared.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.IntegrationTests.Features.Candidate
{
    public partial class UpdateCandidateVacancyTitles_feature
    {
        private Guid vacancyId;

        public async Task Given_candidate_in_database(CandidateDocument candidateDocument)
        {
            vacancyId = candidateDocument.Vacancy.Id;

            await CandidatesRepository.AddCandidate(candidateDocument);
        }

        public async Task When_changed_candidates_vacancy_titles(CandidateVacancyDocumentProjection сandidateVacancyDocumentProjection)
        {
            await CandidatesService.UpdateCandidateVacancyTitles(сandidateVacancyDocumentProjection);
        }

        public async Task Then_candidates_vacancy_title_in_database_should_be(string candidatesVacancyTitle)
        {
            var receivedCandidates = await CandidatesRepository.GetAllCandidatesByVacancyId(vacancyId);

            foreach (var candidate in receivedCandidates)
            {
                Assert.Equal(candidatesVacancyTitle, candidate.Vacancy.Title);
            }
        }
    }
}
