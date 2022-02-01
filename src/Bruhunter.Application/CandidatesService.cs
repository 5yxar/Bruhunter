using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using Bruhunter.DataAccessLayer;
using Microsoft.Extensions.Logging;
using System.Linq;
using Bruhunter.Shared.Projections;

namespace Bruhunter.Application
{
    public class CandidatesService
    {
        private readonly ICandidatesRepository candidatesRepository;
        private readonly ILogger<CandidatesService> logger;

        public CandidatesService(ICandidatesRepository candidatesRepository, ILogger<CandidatesService> logger)
        {
            this.candidatesRepository = candidatesRepository;
            this.logger = logger;
        }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            logger.LogInformation("Adding candidate {candidateDocument} to database ...",
                                   candidateDocument);

            var newGuid = Guid.NewGuid();

            candidateDocument.Id = newGuid;
            await candidatesRepository.AddCandidate(candidateDocument);

            logger.LogDebug("Candidate {candidateDocument} with id = {newGuid} was added to database.",
                            candidateDocument, candidateDocument.Id);
        }

        public async Task<CandidateDocument> GetCandidate(Guid id)
        {
            logger.LogInformation("Getting candidate witn id = {id} from database ...", id);

            var receivedCandidate = await candidatesRepository.GetCandidate(id);

            logger.LogDebug("Candidate {receivedCandidate} with id = {id} was received from database.",
                            receivedCandidate, id);

            return receivedCandidate;
        }

        public async Task UpdateCandidateVacancyProjection(CandidateVacancyDocumentProjection candidateVacancyDocumentProjection)
        {
            logger.LogInformation("Changing candidates vacancy with vacancy id = {VacancyId} in the database ...",
                                    candidateVacancyDocumentProjection.Id);

            var candidatesCollection = await candidatesRepository.GetAllCandidatesByVacancyId(candidateVacancyDocumentProjection.Id);

            var newCadndidatesCollection = candidatesCollection.Select(candidate => candidate with
                {
                    Vacancy = candidate.Vacancy with
                    {
                        Title = candidateVacancyDocumentProjection.Title
                    }
                });

            await candidatesRepository.UpdateCandidates(newCadndidatesCollection);

            logger.LogDebug("Candidates vacancy was changed to {candidateVacancyDocumentProjection}.",
                              candidateVacancyDocumentProjection);
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            logger.LogInformation("Getting all candidates from database ...");

            var receivedCandidates = await candidatesRepository.GetAllCandidates();

            logger.LogDebug("{candidatesCount} candidates was received from database.",
                            receivedCandidates.Count());

            return receivedCandidates;
        }

        public async Task ChangeCandidate(CandidateDocument candidateDocument)
        {
            logger.LogInformation("Changing candidate {candidateDocument} in the database ...",
                                    candidateDocument);

            await candidatesRepository.ChangeCandidate(candidateDocument);

            logger.LogDebug("Candidate was changed to {candidateDocument}.", candidateDocument);
        }

        public async Task DeleteCandidate(Guid guid)
        {
            logger.LogInformation("Deleting candidate with id {guid} in database ...", guid);

            await candidatesRepository.DeleteCandidate(guid);

            logger.LogDebug("Candidate with id = {guid} was deleted in database.", guid);
        }
    }
}
